# Change: Chuẩn hóa dữ liệu đầu vào (Trim Whitespace)

## Why
Hiện tại, hệ thống có thể chấp nhận dữ liệu với khoảng trắng thừa ở đầu hoặc cuối (ví dụ: " Nguyen Van A " thay vì "Nguyen Van A"), dẫn đến:
- Dữ liệu không nhất quán.
- Khó khăn khi tìm kiếm chính xác.
- Tiềm ẩn lỗi logic khi so sánh chuỗi.
- Tốn dung lượng lưu trữ vô ích.

## What Changes
- Thực hiện chuẩn hóa dữ liệu bằng cách sử dụng phương thức `.Trim()` cho tất cả các trường nhập liệu dạng văn bản (Text) trên các Form quản lý trước khi thực hiện Validation và Lưu dữ liệu.
- Các Form áp dụng:
    - Quản lý Sách (`QuanLiSach`)
    - Quản lý Tác giả (`QuanLiTacGia`)
    - Quản lý Độc giả (`FormMember`)
    - Quản lý Nhân viên (`FormStaff`)
    - Quản lý Nhà xuất bản (`FormPublisher`)

## Impact
- **Data Integrity**: Dữ liệu mới sẽ luôn sạch, không có khoảng trắng thừa.
- **User Experience**: Người dùng không cần lo lắng về việc lỡ tay nhập dấu cách thừa.
- **Validation**: Các quy tắc validation (như required) sẽ hoạt động chính xác hơn (chuỗi chỉ có dấu cách sẽ bị coi là rỗng sau khi trim).
