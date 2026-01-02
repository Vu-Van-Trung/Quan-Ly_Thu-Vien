# Change: Thêm nghiệp vụ quản lý tác giả

## Why
Cần có giao diện và backend để quản lý thông tin tác giả (thêm, sửa, xóa, xem) nhằm hỗ trợ việc quản lý sách và các chức năng liên quan.

## What Changes
- **UI**: Thêm form `QuanLiTacGia` với DataGridView hiển thị danh sách tác giả, các TextBox để nhập tên, quốc tịch, sinh nhật, tiểu sử và các nút Thêm, Cập nhật, Xóa.
- **Menu**: Thêm nút "Quản Lý Tác Giả" vào thanh menu bên trái.
- **Service**: Tạo lớp `AuthorService` để thực hiện CRUD thông qua `LibraryContext`.
- **Model**: Sử dụng model `Author` hiện có.

## Impact
- Các form liên quan tới sách sẽ hiển thị tên tác giả từ bảng `Authors`.
- Người dùng có thể quản lý tác giả một cách trực quan.
