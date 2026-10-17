#include "lc_reader.h"

#include <algorithm>
#include <cmath>
#include <cstdlib>
#include <cstring>
#include <iomanip>
#include <limits>
#include <map>
#include <memory>
#include <set>
#include <sstream>
#include <stdexcept>
#include <string>
#include <vector>

namespace {
constexpr size_t kMaxProfileBytes = 128 * 1024;
constexpr size_t kMaxFields = 128;
constexpr size_t kMaxHeroes = 64;
constexpr size_t kMaxCalls = 16384;
constexpr size_t kMaxReadBytes = 2 * 1024 * 1024;
constexpr size_t kMaxIssues = 256;
constexpr uint64_t kMinAddress = 0x10000;
constexpr uint64_t kMaxAddress = 0x00007fffffffffffULL;
constexpr uint64_t kMaxOffset = 0x3fffffff;

struct Failure : std::runtime_error {
    int32_t code;
    Failure(int32_t c, const std::string &s) : std::runtime_error(s), code(c) {}
};

struct Json {
    enum Kind { Null, Bool, Number, String, Array, Object } kind = Null;
    bool boolean = false;
    std::string scalar;
    std::vector<Json> array;
    std::map<std::string, Json> object;
    static Json str(std::string s) { Json v; v.kind=String; v.scalar=std::move(s); return v; }
    static Json num(std::string s) { Json v; v.kind=Number; v.scalar=std::move(s); return v; }
    static Json integer(uint64_t n) { return num(std::to_string(n)); }
    static Json signed_integer(int64_t n) { return num(std::to_string(n)); }
    static Json truth(bool b) { Json v; v.kind=Bool; v.boolean=b; return v; }
    static Json obj() { Json v; v.kind=Object; return v; }
    static Json arr() { Json v; v.kind=Array; return v; }
};

void append_utf8(std::string &s, uint32_t cp) {
    if(cp <= 0x7f) s.push_back(static_cast<char>(cp));
    else if(cp <= 0x7ff) { s.push_back(static_cast<char>(0xc0 | (cp>>6))); s.push_back(static_cast<char>(0x80 | (cp&63))); }
    else if(cp <= 0xffff) { s.push_back(static_cast<char>(0xe0 | (cp>>12))); s.push_back(static_cast<char>(0x80 | ((cp>>6)&63))); s.push_back(static_cast<char>(0x80 | (cp&63))); }
    else { s.push_back(static_cast<char>(0xf0 | (cp>>18))); s.push_back(static_cast<char>(0x80 | ((cp>>12)&63))); s.push_back(static_cast<char>(0x80 | ((cp>>6)&63))); s.push_back(static_cast<char>(0x80 | (cp&63))); }
}

bool valid_utf8(const std::string &s) {
    size_t i=0;
    while(i<s.size()) {
        unsigned char a=static_cast<unsigned char>(s[i++]);
        if(a<0x80) continue;
        size_t n; uint32_t cp, min;
        if(a>=0xc2 && a<=0xdf) { n=1;cp=a&31;min=0x80; }
        else if(a>=0xe0 && a<=0xef) { n=2;cp=a&15;min=0x800; }
        else if(a>=0xf0 && a<=0xf4) { n=3;cp=a&7;min=0x10000; }
        else return false;
        if(i+n>s.size()) return false;
        for(size_t j=0;j<n;++j) { unsigned char b=static_cast<unsigned char>(s[i++]); if((b&0xc0)!=0x80) return false; cp=(cp<<6)|(b&63); }
        if(cp<min || cp>0x10ffff || (cp>=0xd800 && cp<=0xdfff)) return false;
    }
    return true;
}

class Parser {
    const char *p_, *end_;
    [[noreturn]] void bad(const char *m) const { throw Failure(LC_READER_INVALID_PROFILE, std::string("Invalid profile JSON: ")+m); }
    void ws() { while(p_<end_ && (*p_==' ' || *p_=='\n' || *p_=='\r' || *p_=='\t')) ++p_; }
    uint32_t hex4() {
        if(end_-p_<4) bad("short unicode escape");
        uint32_t v=0;
        for(int i=0;i<4;++i) { char c=*p_++; uint32_t d; if(c>='0'&&c<='9') d=c-'0'; else if(c>='a'&&c<='f') d=c-'a'+10; else if(c>='A'&&c<='F') d=c-'A'+10; else bad("invalid unicode escape"); v=(v<<4)|d; }
        return v;
    }
    std::string string() {
        if(p_==end_ || *p_++!='"') bad("string expected");
        std::string s;
        while(p_<end_) {
            unsigned char c=static_cast<unsigned char>(*p_++);
            if(c=='"') { if(!valid_utf8(s)) bad("invalid UTF-8"); return s; }
            if(c<0x20) bad("control character in string");
            if(c=='\\') {
                if(p_==end_) bad("incomplete escape");
                char e=*p_++;
                switch(e) {
                    case '"':s+='"';break; case '\\':s+='\\';break;case '/':s+='/';break;
                    case 'b':s+='\b';break;case 'f':s+='\f';break;case 'n':s+='\n';break;case 'r':s+='\r';break;case 't':s+='\t';break;
                    case 'u': { uint32_t cp=hex4(); if(cp>=0xd800&&cp<=0xdbff) { if(end_-p_<2 || p_[0]!='\\' || p_[1]!='u') bad("unpaired surrogate"); p_+=2; uint32_t low=hex4(); if(low<0xdc00||low>0xdfff) bad("unpaired surrogate"); cp=0x10000+((cp-0xd800)<<10)+(low-0xdc00); } else if(cp>=0xdc00&&cp<=0xdfff) bad("unpaired surrogate"); append_utf8(s,cp); break; }
                    default:bad("unknown escape");
                }
            } else s.push_back(static_cast<char>(c));
            if(s.size()>8192) bad("string too long");
        }
        bad("unterminated string");
    }
    Json value(size_t depth) {
        if(depth>24) bad("nesting limit");
        ws(); if(p_==end_) bad("value expected");
        if(*p_=='"') return Json::str(string());
        if(*p_=='{' || *p_=='[') {
            bool object=*p_++=='{'; Json v=object?Json::obj():Json::arr(); ws();
            char closing=object?'}':']'; if(p_<end_ && *p_==closing) {++p_;return v;}
            for(size_t count=0;;++count) {
                if(count>=1024) bad("collection limit");
                if(object) { ws(); std::string k=string();ws();if(p_==end_||*p_++!=':')bad("colon expected"); Json child=value(depth+1); if(!v.object.emplace(k,std::move(child)).second)bad("duplicate key"); }
                else v.array.push_back(value(depth+1));
                ws();if(p_==end_)bad("unterminated collection");char c=*p_++;if(c==closing)return v;if(c!=',')bad("comma expected");
            }
        }
        auto literal=[&](const char *s) { size_t n=std::strlen(s);if(static_cast<size_t>(end_-p_)<n || std::memcmp(p_,s,n)!=0)bad("invalid literal");p_+=n; };
        if(*p_=='t') {literal("true");return Json::truth(true);}
        if(*p_=='f') {literal("false");return Json::truth(false);}
        if(*p_=='n') {literal("null");return Json();}
        const char *start=p_;
        if(*p_=='-')++p_;
        if(p_==end_)bad("invalid number");
        if(*p_=='0')++p_;else { if(*p_<'1'||*p_>'9')bad("invalid number");while(p_<end_&&*p_>='0'&&*p_<='9')++p_; }
        if(p_<end_&&*p_=='.') {++p_;const char *q=p_;while(p_<end_&&*p_>='0'&&*p_<='9')++p_;if(p_==q)bad("invalid fraction");}
        if(p_<end_&&(*p_=='e'||*p_=='E')) {++p_;if(p_<end_&&(*p_=='+'||*p_=='-'))++p_;const char *q=p_;while(p_<end_&&*p_>='0'&&*p_<='9')++p_;if(p_==q)bad("invalid exponent");}
        return Json::num(std::string(start,p_));
    }
public:
    Parser(const char *p,size_t n):p_(p),end_(p+n){}
    Json parse() {Json v=value(0);ws();if(p_!=end_)bad("trailing content");return v;}
};

std::string quoted(const std::string &s) {
    const char *hex="0123456789abcdef";std::string out="\"";
    for(unsigned char c:s) {
        if(c=='"'||c=='\\') {out+='\\';out+=static_cast<char>(c);}
        else if(c<0x20) {out+="\\u00";out+=hex[c>>4];out+=hex[c&15];}
        else out+=static_cast<char>(c);
    }
    return out+'"';
}
std::string dump(const Json &v) {
    switch(v.kind) {
        case Json::Null:return "null";case Json::Bool:return v.boolean?"true":"false";
        case Json::Number:return v.scalar;case Json::String:return quoted(v.scalar);
        case Json::Array: {std::string s="[";bool first=true;for(const auto &x:v.array){if(!first)s+=',';first=false;s+=dump(x);}return s+"]";}
        case Json::Object: {std::string s="{";bool first=true;for(const auto &x:v.object){if(!first)s+=',';first=false;s+=quoted(x.first)+":"+dump(x.second);}return s+"}";}
    }
    return "null";
}
const Json &member(const Json &v,const char *key) {
    if(v.kind!=Json::Object)throw Failure(LC_READER_INVALID_PROFILE,std::string("Object expected for ")+key);
    auto it=v.object.find(key);if(it==v.object.end())throw Failure(LC_READER_INVALID_PROFILE,std::string("Missing property: ")+key);return it->second;
}
const Json *optional(const Json &v,const std::string &key) {auto it=v.object.find(key);return it==v.object.end()?nullptr:&it->second;}
std::string text_value(const Json &v,const char *name) {if(v.kind!=Json::String || v.scalar.empty() || v.scalar.size()>2048)throw Failure(LC_READER_INVALID_PROFILE,std::string("Nonempty string expected: ")+name);return v.scalar;}
uint64_t unsigned_value(const Json &v,const char *name) {
    if(v.kind!=Json::Number || v.scalar.empty() || v.scalar.find_first_not_of("0123456789")!=std::string::npos)throw Failure(LC_READER_INVALID_PROFILE,std::string("Unsigned integer expected: ")+name);
    try {return std::stoull(v.scalar);}catch(...){throw Failure(LC_READER_INVALID_PROFILE,std::string("Integer out of range: ")+name);}
}
void only_keys(const Json &v,std::initializer_list<const char *> allowed) {
    if(v.kind!=Json::Object)throw Failure(LC_READER_INVALID_PROFILE,"Object expected");
    for(const auto &kv:v.object) {bool found=false;for(const char *k:allowed)if(kv.first==k)found=true;if(!found)throw Failure(LC_READER_INVALID_PROFILE,"Unsupported property: "+kv.first);}
}
std::string digest(std::string s) {
    if(s.size()!=64)throw Failure(LC_READER_INVALID_PROFILE,"SHA-256 must contain 64 hex characters");
    for(char &c:s) {if(c>='A'&&c<='F')c=static_cast<char>(c-'A'+'a');if(!((c>='0'&&c<='9')||(c>='a'&&c<='f')))throw Failure(LC_READER_INVALID_PROFILE,"Invalid SHA-256");}return s;
}
std::vector<std::string> field_path(const std::string &s) {
    if(s.size()>128)throw Failure(LC_READER_INVALID_PROFILE,"Field path too long");
    std::vector<std::string> result;size_t start=0;
    while(start<s.size()) {size_t end=s.find('.',start);if(end==std::string::npos)end=s.size();std::string x=s.substr(start,end-start);if(x.empty()||x.size()>48)throw Failure(LC_READER_INVALID_PROFILE,"Invalid field path");for(size_t i=0;i<x.size();++i){char c=x[i];if(!((c>='a'&&c<='z')||(c>='A'&&c<='Z')||c=='_'||(i>0&&c>='0'&&c<='9')))throw Failure(LC_READER_INVALID_PROFILE,"Invalid field path character");}result.push_back(x);if(result.size()>8)throw Failure(LC_READER_INVALID_PROFILE,"Field path depth exceeded");start=end+1;}
    if(result.empty()||s.back()=='.')throw Failure(LC_READER_INVALID_PROFILE,"Invalid field path");
    return result;
}

struct Field {
    std::string path,root,type,evidence;
    std::vector<std::string> parts;
    uint64_t offset=0;
    std::vector<uint64_t> deref;
    size_t max_bytes=0;
};
struct Profile {
    std::string id,module,version,sha256,status,runtime_evidence;
    std::vector<Field> fields;
    Json evidence;
};
Profile parse_profile(const char *json,size_t length) {
    Json p=Parser(json,length).parse();
    only_keys(p,{"schemaVersion","profileId","target","validation","evidence","fields"});
    if(unsigned_value(member(p,"schemaVersion"),"schemaVersion")!=1)throw Failure(LC_READER_INVALID_PROFILE,"Unsupported profile schemaVersion");
    Profile r;r.id=text_value(member(p,"profileId"),"profileId");
    const Json &target=member(p,"target");only_keys(target,{"module","version","sha256"});
    r.module=text_value(member(target,"module"),"module");r.version=text_value(member(target,"version"),"version");r.sha256=digest(text_value(member(target,"sha256"),"sha256"));
    const Json &validation=member(p,"validation");only_keys(validation,{"status","note","runtimeEvidenceId"});
    r.status=text_value(member(validation,"status"),"validation.status");
    if(r.status!="verified"&&r.status!="fixture-only"&&r.status!="static-derived"&&r.status!="unverified")throw Failure(LC_READER_INVALID_PROFILE,"Unknown validation status");
    if(const Json *v=optional(validation,"note"))text_value(*v,"validation.note");
    if(const Json *v=optional(validation,"runtimeEvidenceId"))r.runtime_evidence=text_value(*v,"runtimeEvidenceId");
    r.evidence=member(p,"evidence");if(r.evidence.kind!=Json::Array||r.evidence.array.empty()||r.evidence.array.size()>128)throw Failure(LC_READER_INVALID_PROFILE,"Evidence array must have 1..128 entries");
    std::set<std::string> ids;
    for(const Json &e:r.evidence.array) {only_keys(e,{"id","source","sha256","note"});std::string id=text_value(member(e,"id"),"evidence.id");if(!ids.insert(id).second)throw Failure(LC_READER_INVALID_PROFILE,"Duplicate evidence id");text_value(member(e,"source"),"evidence.source");if(const Json *v=optional(e,"sha256"))digest(text_value(*v,"evidence.sha256"));if(const Json *v=optional(e,"note"))text_value(*v,"evidence.note");}
    if(r.status=="verified" && (r.runtime_evidence.empty()||!ids.count(r.runtime_evidence)))throw Failure(LC_READER_INVALID_PROFILE,"Verified profile requires runtimeEvidenceId referencing evidence");
    const Json &fields=member(p,"fields");if(fields.kind!=Json::Array||fields.array.empty()||fields.array.size()>kMaxFields)throw Failure(LC_READER_INVALID_PROFILE,"Fields array must have 1..128 entries");
    for(const Json &x:fields.array) {
        only_keys(x,{"path","root","offset","type","evidenceId","derefOffsets","maxBytes"});Field f;
        f.path=text_value(member(x,"path"),"path");f.parts=field_path(f.path);
        f.root=text_value(member(x,"root"),"root");if(f.root!="hero"&&f.root!="module")throw Failure(LC_READER_INVALID_PROFILE,"Field root must be hero or module");
        if(f.root=="module"&&f.parts.front()=="heroes")throw Failure(LC_READER_INVALID_PROFILE,"Module fields cannot overwrite heroes");
        f.offset=unsigned_value(member(x,"offset"),"offset");if(f.offset>kMaxOffset)throw Failure(LC_READER_INVALID_PROFILE,"Field offset exceeds bound");
        f.type=text_value(member(x,"type"),"type");const std::set<std::string> types={"u8","i8","u16","i16","u32","i32","u64","i64","f32","f64","bool","vec3","utf8"};if(!types.count(f.type))throw Failure(LC_READER_INVALID_PROFILE,"Unsupported field type");
        f.evidence=text_value(member(x,"evidenceId"),"evidenceId");if(!ids.count(f.evidence))throw Failure(LC_READER_INVALID_PROFILE,"Field references unknown evidence");
        if(const Json *v=optional(x,"derefOffsets")) {if(v->kind!=Json::Array||v->array.size()>8)throw Failure(LC_READER_INVALID_PROFILE,"Pointer chain exceeds bound");for(const Json &n:v->array){uint64_t o=unsigned_value(n,"derefOffsets");if(o>kMaxOffset)throw Failure(LC_READER_INVALID_PROFILE,"Pointer offset exceeds bound");f.deref.push_back(o);}}
        if(const Json *v=optional(x,"maxBytes"))f.max_bytes=static_cast<size_t>(unsigned_value(*v,"maxBytes"));
        if(f.type=="utf8") {if(f.max_bytes<1||f.max_bytes>1024)throw Failure(LC_READER_INVALID_PROFILE,"UTF-8 maxBytes must be 1..1024");}
        else if(f.max_bytes!=0)throw Failure(LC_READER_INVALID_PROFILE,"maxBytes applies only to utf8");
        for(const Field &old:r.fields)if(old.root==f.root && (old.path==f.path || old.path.compare(0,f.path.size()+1,f.path+".")==0 || f.path.compare(0,old.path.size()+1,old.path+".")==0))throw Failure(LC_READER_INVALID_PROFILE,"Duplicate or overlapping field paths");
        r.fields.push_back(std::move(f));
    }
    return r;
}

void error_clear(lc_reader_error *error) {if(error){error->code=0;error->message[0]='\0';}}
int32_t error_set(lc_reader_error *error,int32_t code,const std::string &message) {if(error){error->code=code;std::strncpy(error->message,message.c_str(),sizeof(error->message)-1);error->message[sizeof(error->message)-1]='\0';}return code;}
bool address_ok(uint64_t a,size_t n) {return n>0 && a>=kMinAddress && a<=kMaxAddress && n-1<=kMaxAddress-a;}
bool add_address(uint64_t a,uint64_t b,uint64_t &out) {if(a>kMaxAddress||b>kMaxAddress-a)return false;out=a+b;return address_ok(out,1);}
Json real_value(double value) {if(!std::isfinite(value))return Json();std::ostringstream s;s.imbue(std::locale::classic());s<<std::setprecision(std::numeric_limits<double>::max_digits10)<<value;return Json::num(s.str());}
void put(Json &root,const std::vector<std::string> &parts,Json value) {Json *p=&root;for(size_t i=0;i+1<parts.size();++i){Json &n=p->object[parts[i]];if(n.kind==Json::Null)n=Json::obj();p=&n;}p->object[parts.back()]=std::move(value);}
int32_t buffer(const Json &json,char **out,size_t *length,lc_reader_error *error) {
    if(!out||!length)return error_set(error,LC_READER_INVALID_ARGUMENT,"Output buffer and length required");
    std::string s=dump(json);char *p=static_cast<char *>(std::malloc(s.size()+1));if(!p)throw std::bad_alloc();std::memcpy(p,s.c_str(),s.size()+1);*out=p;*length=s.size();return LC_READER_OK;
}
}

struct lc_reader {
    Profile profile;
    uint64_t module_base=0;
    lc_reader_read_fn read=nullptr;
    void *context=nullptr;
};

namespace {
struct Capture {
    lc_reader &reader;
    size_t calls=0,bytes=0,issue_count=0;
    Json issues=Json::arr();
    explicit Capture(lc_reader &r):reader(r){}
    void issue(const Field &f,int64_t index,const std::string &reason) {
        ++issue_count;if(issues.array.size()>=kMaxIssues)return;Json x=Json::obj();x.object["field"]=Json::str(f.path);x.object["root"]=Json::str(f.root);x.object["reason"]=Json::str(reason);if(index>=0)x.object["heroIndex"]=Json::integer(static_cast<uint64_t>(index));issues.array.push_back(std::move(x));
    }
    size_t read(uint64_t address,void *dest,size_t n,std::string &reason) {
        if(!address_ok(address,n)){reason="invalid_address";return 0;}
        if(calls>=kMaxCalls||n>kMaxReadBytes-bytes){reason="read_budget_exceeded";return 0;}
        ++calls;bytes+=n;size_t actual=reader.read(reader.context,address,dest,n);if(actual>n){reason="invalid_read_callback_result";return 0;}if(actual!=n)reason="read_failed";return actual;
    }
    template<class T> bool scalar(uint64_t address,T &value,std::string &reason) {return read(address,&value,sizeof(value),reason)==sizeof(value);}
    Json field(const Field &f,uint64_t base,int64_t index) {
        std::string reason;uint64_t address=base;
        for(uint64_t step:f.deref) {
            uint64_t at=0,next=0;if(!add_address(address,step,at)){issue(f,index,"invalid_address");return Json();}
            if(!scalar(at,next,reason)){issue(f,index,reason);return Json();}
            if(!address_ok(next,1)){issue(f,index,"invalid_pointer");return Json();}address=next;
        }
        if(!add_address(address,f.offset,address)){issue(f,index,"invalid_address");return Json();}
        Json value;
        if(f.type=="utf8") {
            std::string result;size_t consumed=0;
            while(consumed<f.max_bytes) {
                char chunk[64];size_t want=std::min(sizeof(chunk),f.max_bytes-consumed);uint64_t at=0;if(!add_address(address,consumed,at)){reason="invalid_address";break;}
                size_t got=read(at,chunk,want,reason);
                for(size_t i=0;i<got;++i)if(chunk[i]=='\0') {result.append(chunk,i);if(!valid_utf8(result)){issue(f,index,"invalid_utf8");return Json();}return Json::str(result);}
                if(got!=want)break;
                result.append(chunk,got);consumed+=got;
            }
            issue(f,index,reason.empty()?"string_not_terminated":reason);return Json();
        }
        if(f.type=="vec3") {
            float v[3];if(read(address,v,sizeof(v),reason)!=sizeof(v)){issue(f,index,reason);return Json();}
            for(float x:v)if(!std::isfinite(x)){issue(f,index,"non_finite");return Json();}
            value=Json::obj();value.object["x"]=real_value(v[0]);value.object["y"]=real_value(v[1]);value.object["z"]=real_value(v[2]);return value;
        }
#define READ_INT(TYPE, NAME, CONVERT) if(f.type==NAME){TYPE v{};if(!scalar(address,v,reason)){issue(f,index,reason);return Json();}return Json::CONVERT(v);}
        READ_INT(uint8_t,"u8",integer) READ_INT(int8_t,"i8",signed_integer)
        READ_INT(uint16_t,"u16",integer) READ_INT(int16_t,"i16",signed_integer)
        READ_INT(uint32_t,"u32",integer) READ_INT(int32_t,"i32",signed_integer)
        READ_INT(uint64_t,"u64",integer) READ_INT(int64_t,"i64",signed_integer)
#undef READ_INT
        if(f.type=="bool"){uint8_t v=0;if(!scalar(address,v,reason)){issue(f,index,reason);return Json();}return Json::truth(v!=0);}
        double n=0;
        if(f.type=="f32"){float v=0;if(!scalar(address,v,reason)){issue(f,index,reason);return Json();}n=v;}
        else {if(!scalar(address,n,reason)){issue(f,index,reason);return Json();}}
        if(!std::isfinite(n)){issue(f,index,"non_finite");return Json();}return real_value(n);
    }
};

Json profile_info(const lc_reader &r) {
    Json info=Json::obj();info.object["apiVersion"]=Json::integer(LC_READER_API_VERSION);info.object["profileId"]=Json::str(r.profile.id);info.object["profileValidation"]=Json::str(r.profile.status);info.object["runtimeVerified"]=Json::truth(r.profile.status=="verified");info.object["targetIdentityMatched"]=Json::truth(true);info.object["objectDiscoveryAvailable"]=Json::truth(false);info.object["authenticationRequired"]=Json::truth(false);info.object["originalLibraryLoaded"]=Json::truth(false);info.object["fieldCount"]=Json::integer(r.profile.fields.size());info.object["evidence"]=r.profile.evidence;
    Json target=Json::obj();target.object["module"]=Json::str(r.profile.module);target.object["version"]=Json::str(r.profile.version);target.object["sha256"]=Json::str(r.profile.sha256);info.object["target"]=std::move(target);return info;
}
}

extern "C" {
uint32_t lc_reader_api_version(void) {return LC_READER_API_VERSION;}

int32_t lc_reader_create(const char *json,size_t length,const lc_reader_target *target,
                        lc_reader_read_fn read,void *context,uint32_t flags,
                        lc_reader **out,lc_reader_error *error) {
    error_clear(error);if(out)*out=nullptr;
    try {
        const uint16_t endian=1;if(*reinterpret_cast<const uint8_t *>(&endian)!=1)return error_set(error,LC_READER_UNSUPPORTED_PLATFORM,"Only little-endian hosts supported");
        if(!out||!json||!length||!target||target->struct_size!=sizeof(lc_reader_target)||!read||!target->module_name||!target->version||!target->sha256)return error_set(error,LC_READER_INVALID_ARGUMENT,"Profile, target identity, read callback and output are required");
        if(length>kMaxProfileBytes)return error_set(error,LC_READER_LIMIT_EXCEEDED,"Profile exceeds 128 KiB");
        if(flags & ~(LC_READER_ALLOW_FIXTURE|LC_READER_ALLOW_UNVERIFIED))return error_set(error,LC_READER_INVALID_ARGUMENT,"Unknown reader flags");
        if(!address_ok(target->module_base,1))return error_set(error,LC_READER_INVALID_ARGUMENT,"Invalid module base");
        auto r=std::make_unique<lc_reader>();r->profile=parse_profile(json,length);
        std::string actual_hash;
        try {actual_hash=digest(target->sha256);}catch(const Failure &){return error_set(error,LC_READER_INVALID_ARGUMENT,"Invalid target SHA-256");}
        if(r->profile.module!=target->module_name||r->profile.version!=target->version||r->profile.sha256!=actual_hash)return error_set(error,LC_READER_TARGET_MISMATCH,"Profile does not match measured target module/version/SHA-256");
        if(r->profile.status=="fixture-only" && !(flags&LC_READER_ALLOW_FIXTURE))return error_set(error,LC_READER_PROFILE_NOT_VERIFIED,"Fixture profile requires LC_READER_ALLOW_FIXTURE");
        if((r->profile.status=="unverified"||r->profile.status=="static-derived") && !(flags&LC_READER_ALLOW_UNVERIFIED))return error_set(error,LC_READER_PROFILE_NOT_VERIFIED,"Unverified profile requires LC_READER_ALLOW_UNVERIFIED");
        r->module_base=target->module_base;r->read=read;r->context=context;*out=r.release();return LC_READER_OK;
    }catch(const Failure &f){return error_set(error,f.code,f.what());}catch(const std::exception &e){return error_set(error,LC_READER_INTERNAL_ERROR,e.what());}catch(...){return error_set(error,LC_READER_INTERNAL_ERROR,"Unexpected reader exception");}
}

int32_t lc_reader_snapshot(lc_reader *reader,const lc_reader_request *request,
                          char **out,size_t *length,lc_reader_error *error) {
    error_clear(error);if(out)*out=nullptr;if(length)*length=0;
    try {
        if(!reader||!request||request->struct_size!=sizeof(lc_reader_request)||!out||!length)return error_set(error,LC_READER_INVALID_ARGUMENT,"Reader, snapshot request and outputs are required");
        if(request->heroes_known>1||(!request->heroes_known&&request->hero_count)||(!request->hero_addresses&&request->hero_count))return error_set(error,LC_READER_INVALID_ARGUMENT,"Invalid caller-supplied hero roots");
        if(request->hero_count>kMaxHeroes)return error_set(error,LC_READER_LIMIT_EXCEEDED,"Hero root count exceeds 64");
        Capture capture(*reader);Json data=Json::obj();
        for(const Field &f:reader->profile.fields)if(f.root=="module")put(data,f.parts,capture.field(f,reader->module_base,-1));
        Json heroes;
        if(request->heroes_known) {
            heroes=Json::arr();
            for(size_t i=0;i<request->hero_count;++i) {
                Json hero=Json::obj();for(const Field &f:reader->profile.fields)if(f.root=="hero")put(hero,f.parts,capture.field(f,request->hero_addresses[i],static_cast<int64_t>(i)));heroes.array.push_back(std::move(hero));
            }
        }
        data.object["heroes"]=std::move(heroes);Json result=Json::obj();result.object["schemaVersion"]=Json::integer(1);result.object["source"]=Json::str("independent-memory-reader");result.object["synthetic"]=Json::truth(reader->profile.status=="fixture-only");result.object["data"]=std::move(data);
        Json meta=profile_info(*reader);meta.object["rootsProvidedByCaller"]=Json::truth(request->heroes_known!=0);meta.object["readCalls"]=Json::integer(capture.calls);meta.object["bytesRequested"]=Json::integer(capture.bytes);meta.object["issueCount"]=Json::integer(capture.issue_count);meta.object["issuesTruncated"]=Json::truth(capture.issue_count>capture.issues.array.size());meta.object["issues"]=std::move(capture.issues);result.object["metadata"]=std::move(meta);return buffer(result,out,length,error);
    }catch(const Failure &f){return error_set(error,f.code,f.what());}catch(const std::exception &e){return error_set(error,LC_READER_INTERNAL_ERROR,e.what());}catch(...){return error_set(error,LC_READER_INTERNAL_ERROR,"Unexpected snapshot exception");}
}

int32_t lc_reader_profile_info(const lc_reader *reader,char **out,size_t *length,lc_reader_error *error) {
    error_clear(error);if(out)*out=nullptr;if(length)*length=0;
    try {if(!reader||!out||!length)return error_set(error,LC_READER_INVALID_ARGUMENT,"Reader and outputs required");return buffer(profile_info(*reader),out,length,error);}catch(const std::exception &e){return error_set(error,LC_READER_INTERNAL_ERROR,e.what());}catch(...){return error_set(error,LC_READER_INTERNAL_ERROR,"Unexpected metadata exception");}
}
void lc_reader_free_buffer(char *p) {std::free(p);}
void lc_reader_destroy(lc_reader *r) {delete r;}
}
