#include "lc_reader.h"

#include <cstring>
#include <string>
#ifdef _WIN32
#define WIN32_LEAN_AND_MEAN
#include <windows.h>
#endif

namespace {
int32_t fail(lc_reader_error *error,int32_t code,const char *message) {
    if(error) {error->code=code;std::strncpy(error->message,message,sizeof(error->message)-1);error->message[sizeof(error->message)-1]='\0';}return code;
}
}

extern "C" {
int32_t lc_reader_win32_open(uint32_t process_id,void **out_context,lc_reader_error *error) {
    if(out_context)*out_context=nullptr;
    if(error){error->code=0;error->message[0]='\0';}
    if(!out_context||process_id==0)return fail(error,LC_READER_INVALID_ARGUMENT,"Valid process ID and output required");
#ifdef _WIN32
    if(sizeof(void *)!=8)return fail(error,LC_READER_UNSUPPORTED_PLATFORM,"Win32 read adapter requires an x64 host");
    HANDLE h=OpenProcess(PROCESS_VM_READ|PROCESS_QUERY_LIMITED_INFORMATION,FALSE,process_id);
    if(!h)return fail(error,LC_READER_INVALID_ARGUMENT,"OpenProcess read-only access failed");
    *out_context=h;return LC_READER_OK;
#else
    return fail(error,LC_READER_UNSUPPORTED_PLATFORM,"ReadProcessMemory adapter requires Windows");
#endif
}
size_t lc_reader_win32_read(void *context,uint64_t address,void *destination,size_t requested) {
#ifdef _WIN32
    if(!context||!destination||!requested)return 0;
    SIZE_T read=0;
    ReadProcessMemory(static_cast<HANDLE>(context),reinterpret_cast<LPCVOID>(static_cast<uintptr_t>(address)),destination,requested,&read);return static_cast<size_t>(read);
#else
    (void)context;(void)address;(void)destination;(void)requested;return 0;
#endif
}
void lc_reader_win32_close(void *context) {
#ifdef _WIN32
    if(context)CloseHandle(static_cast<HANDLE>(context));
#else
    (void)context;
#endif
}
}
