# Core Data Handling

## MODIFIED Requirements

### [Generic] Input Normalization
Hệ thống phải tự động loại bỏ khoảng trắng thừa ở đầu và cuối chuỗi ký tự (Trim) cho mọi trường dữ liệu văn bản trước khi xử lý logic hoặc lưu trữ.

#### Scenario: Người dùng nhập tên có khoảng trắng thừa
- **Given**: Người dùng đang ở màn hình thêm mới hoặc cập nhật (Sách, Độc giả, Tác giả...).
- **When**: Người dùng nhập "  Nguyen Van A  " vào trường Tên.
- **Then**: Hệ thống phải lưu giá trị là "Nguyen Van A".
- **And**: Không báo lỗi định dạng nếu sau khi trim dữ liệu hợp lệ.
- **And**: Báo lỗi "Bắt buộc nhập" nếu chuỗi nhập vào chỉ toàn khoảng trắng (sau khi trim trở thành rỗng).
