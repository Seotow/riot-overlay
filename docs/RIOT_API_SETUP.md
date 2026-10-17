# Nhập Riot API và tải postgame — 13/10/2026

## Lượt kiểm thật 17/10/2026

Key được người dùng nhập vào RAM backend ở chế độ Standard. Load custom
VN2_1607368559 trả 404; control trận thường VN2_1607651234 trả 403. Chưa
xác nhận key được Match-V5 chấp nhận; không kết luận 403 chỉ do custom.
Không publish hoặc in secret, không thử biến API key thành RSO token.
Chưa có RSO/Tournament entitlement mới nên không gọi hai nhánh đó bằng key
Standard để thử vượt quyền. Nguồn khác đọc được là metadata replay local,
xem [ROFL_POSTGAME_FINDINGS](ROFL_POSTGAME_FINDINGS.md).

## Bạn cần thao tác gì?

1. Build và khởi động lại backend nếu phiên cũ đang chạy:

   ```powershell
   npm run build
   npm start
   ```

   Dừng phiên backend cũ bằng Ctrl+C trước khi chạy lại cùng port. Không khởi
   động lại game/LB cho bước này. `npm start` chạy source backend + frontend dist.
2. Mở **Sau trận** (`/?page=postgame`). Khối Riot nằm đầu trang, trước preview
   overlay đang phát. Chọn **Production Standard** theo quyền đã xác nhận.
3. Nhập key trong ô password → **Lưu key/token trong phiên**. Ô nhập xóa sau
   khi server nhận. Lưu không phải kết quả xác thực; cần request match tiếp theo.
4. Nhập **Riot match ID** dạng `VN2_<id>` của trận đã kết thúc và số ván.
   Đây không phải ID trận nội bộ LB. Key không xác định bạn muốn lấy trận nào.
5. **Tải match + timeline / kiểm tra quyền**. Backend chỉ GET vào Riot SEA,
   không đổi OBS. Xem bản chờ duyệt, các số còn thiếu, patch và cảnh báo role.
6. Đối chiếu đúng trận, đội và cấu hình branding → đánh dấu xác nhận →
   **Dùng dữ liệu Riot cho postgame**. Backend publish cùng snapshot tới Studio
   và OBS; URL `/overlay?scene=postgame` vẫn giữ như trước.

Không gửi key vào chat. Không cần API key của LB hoặc sửa game.cfg. Trận normal
cũ có thể dùng làm control để kiểm tra key/routing; không coi control đó chứng
minh custom có thể truy cập bằng Standard.

## RSO / custom

Nếu đã có **player RSO access token** được cấp hợp lệ, đổi kiểu xác thực rồi
nhập token đó. Backend dùng Bearer và `/lol/rso-match/v1/matches/…`, không gửi
API key vào Authorization để giả token. Phần cấu hình này không tạo OAuth
client, đăng nhập/refresh token hoặc xin quyền Tournament. Token hết hạn cần
được cấp lại qua luồng RSO của bạn.

Standard không mặc định lấy được custom thường/Practice Tool. 403/404 không
được vượt bằng endpoint nội bộ hoặc tự fallback sang dữ liệu mẫu. Hướng RSO/
Tournament còn cần kiểm chứng và quyền tương ứng, xem
[RIOT_POSTGAME_API_FINDINGS](RIOT_POSTGAME_API_FINDINGS.md).

## Bảo vệ key

- Secret chỉ giữ trong RAM backend, không lưu đĩa, theme, export, localStorage,
  browser storage, snapshot WS hoặc dữ liệu gửi OBS. Ô password ở Studio chỉ
  giữ giá trị tạm trước POST; không có cơ chế đọc secret trở lại từ backend.
- Restart backend cần nhập lại. **Xóa key/token** xóa credential và candidate
  đang chờ, hủy request pending; không xóa kết quả đã publish.
- HTTP local chỉ bind 127.0.0.1, Host/Origin guard, JSON POST có Origin same-app,
  giới hạn body 16 KB. Secret không nằm trong URL/query hoặc error body.
- Egress chỉ HTTPS SEA, literal endpoint GET, ID VN2 được validate, không có
  ô URL proxy tùy ý. Không follow redirect, timeout 12s/request, response tối
  đa 8MB; lỗi upstream chỉ trả mã đã lọc, không echo raw payload/header/token.
- Không auto retry. 429 giữ cooldown theo Retry-After; đổi/xóa key không dùng
  để né cooldown. Không tạo provider/tournament/code hay publish ra Internet.
- Thiết kế vẫn là một máy local, không có authentication cho nhiều máy.
  Không expose server lên LAN/public. Extension/người dùng cùng máy có quyền
  local cần được xem là một phần môi trường tin cậy; đây không phải vault OS.

## Data và độ tin cậy

Nhánh mẫu version 1 / asset15.20.1 giữ nguyên. Nhánh Riot version2 được
backend normalize, source=riot; command WS/import mẫu không thể tự gắn nhãn
Riot. JSON xuất kết quả không có credentials hoặc tên/PUUID người chơi; import
ở trang này chỉ nhận bộ mẫu, không restore nguồn observed từ file chưa xác minh.

Adapter kiểm tra metadata matchId, platform VN2, roster10 người/5 mỗi đội,
participant IDs và team100/200. KDA/gold cộng năm người; damage dùng
totalDamageDealtToChampions, không tổng damage mọi mục tiêu. Player icons dùng
catalog live16.20.1, không nâng baseline demo. Patch khác giữ cảnh báo.

Role xếp theo teamPosition dự đoán của Riot. Nếu thiếu/không duy nhất, giữ
participant order và ghi P1…P5 thay vì giả lane. Các số thiếu giữ null/—.
Horde→grubs vẫn cần payload thật đối chiếu semantics patch, đặc biệt khi zero.

Timeline bị lỗi vẫn có thể duyệt thống kê Match đã tải, kèm cảnh báo thiếu
chart. Gold dùng sample quan sát, frame thiếu player tạo gap; không dựng đường
liên tục giả. Tách elemental/Elder chỉ khi timeline có coverage đầu/cuối,
event subtype/team nhận diện được và counter match phù hợp; thiếu giữ —.
Mapping event-specific này đã test tổng hợp, **chưa xác minh payload live**.
Dataset partial/aborted ghi isFinal=false; operator phải đối chiếu trước khi phát.

## Endpoint local

| Endpoint | Công dụng |
| --- | --- |
| GET `/api/riot-postgame/status` | configured/mode/SEA/candidate không secret |
| POST `/api/riot-postgame/credential` | nhập `{mode,secret}` hoặc `{clear:true}`; không WS |
| POST `/api/riot-postgame/load` | `{matchId,gameNumber}` → tải/stage sanitized result |
| POST `/api/riot-postgame/publish` | chỉ `{matchId}` khớp candidate server → phát snapshot |

Publish không nhận payload Riot từ browser, nên JSON forged/mock response
chỉ có thể xuất hiện ở preview client chứ không giả observed data trên server.
Candidate/kết quả/key đều không tự persist qua restart; JSON export để đối
chiếu, muốn phát observed sau restart phải tải lại từ Riot được cấp quyền.

## Kiểm chứng đã làm / còn chờ

- Build TypeScript/Vite; 116 unit/regression; integration backend cô lập.
- Unit request Riot là **synthetic**, kiểm tra headers/host/GET, rate-limit,
  redaction, thiếu damage/role/timeline, từ chối sai trận/roster, clear pending.
- Integration kiểm tra Host/Origin/method, secret RAM không echo, input invalid
  không tạo upstream call, publish khi không candidate bị từ chối; kiểm tra
  load→stage→publish→snapshot với fixture fetch chỉ nạp bằng `--import` trong
  process test, không có cấu hình mock Riot trong app production.
- Edge QA1920/1280: password/save/clear, không localStorage, ID validation,
  Standard/RSO, same renderer candidate, staged không đổi OBS, browser forged
  candidate không publish được. Test UI dùng credential/response tổng hợp;
  **không gọi Riot thật**, không thay theme cá nhân.
- Postgame sample browser regression đạt. Ảnh config ready ở
  `.npm-cache/visual-audit/riot-api-config-ready.png`.
- Chưa có production key/match của người dùng trong lần triển khai. Không
  kết luận quyền Standard custom, độ trễ postgame, Elder/horde hoặc mọi patch
  đã đạt. Bước tiếp là bạn nhập key + match ID rồi kiểm tra response thực.
