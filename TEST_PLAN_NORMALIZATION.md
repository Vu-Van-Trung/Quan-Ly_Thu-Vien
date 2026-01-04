# Kế hoạch Kiểm thử: Chuẩn hóa Dữ liệu (Trim Whitespace)

## Mục tiêu
Xác nhận rằng hệ thống tự động loại bỏ khoảng trắng thừa ở đầu và cuối chuỗi nhập liệu trên các Form quản lý trước khi lưu vào cơ sở dữ liệu.

## 1. Kiểm tra qua Nhật ký Hoạt động (System Log)
Đây là cách nhanh nhất để xác minh dữ liệu đã được xử lý (Trim) hay chưa mà không cần truy cập Database trực tiếp.
*Lý do:* Hệ thống ghi log sử dụng chính giá trị đã được gán vào object model (đã qua xử lý Trim). Nếu log hiển thị không có khoảng trắng thừa, nghĩa là dữ liệu lưu DB cũng vậy.

### Form: Quản lý Sách (`QuanLiSach`)
1.  **Bước 1**: Mở form Quản lý Sách > Thêm mới.
2.  **Bước 2**: Nhập Tên sách: `"   Lap Trinh C#   "` (có cách đầu/cuối).
3.  **Bước 3**: Nhập Vị trí: `"   Ke A-1   "`
4.  **Bước 4**: Lưu.
5.  **Bước 5**: Mở **Quan Lý Nhật Ký**.
6.  **Kết quả mong đợi**:
    *   Log ghi: `Thêm sách: Lap Trinh C# ...` (Không có khoảng trắng thừa).
    *   Log ghi: `Vị trí: Ke A-1`.

---

## 2. Kịch bản Kiểm thử Thủ công (Manual Test Cases)

| Form | Trường dữ liệu | Giá trị nhập thử (Input) | Kết quả mong đợi (Expected) | Ghi chú |
| :--- | :--- | :--- | :--- | :--- |
| **Quản lý Sách** | Tên sách | `"  Doremon  "` | `"Doremon"` | Lưu thành công |
| **Quản lý Sách** | Tên sách | `"     "` (Chỉ khoảng trắng) | **Lỗi Validation** | Báo lỗi "Tên sách là bắt buộc" |
| **Tác giả** | Tên tác giả | `"  Nguyen Nhat Anh  "` | `"Nguyen Nhat Anh"` | |
| **Tác giả** | Quốc tịch | `"  Viet Nam  "` | `"Viet Nam"` | |
| **Độc giả** | Email | `"  email@test.com  "` | `"email@test.com"` | Validate Email thành công |
| **Độc giả** | Số ĐT | `"  0987654321  "` | `"0987654321"` | Validate Số ĐT thành công |
| **Nhân viên** | Họ tên | `"  Tran Van B  "` | `"Tran Van B"` | |

## 3. Kiểm tra Hồi quy (Regression Test)
Đảm bảo logic cũ vẫn hoạt động đúng sau khi thêm `Trim()`.

1.  **Validate Rỗng**: Nhập `"   "` vào trường bắt buộc -> Phải báo lỗi (đã fix code dùng `string.IsNullOrWhiteSpace` hoặc `.Trim().Length == 0`).
2.  **Validate Regex**:
    *   SĐT: Nhập `" 0912345678 "` -> Trim thành `"0912345678"` -> Regex `^\d+$` khớp -> **Hợp lệ**.
    *   Email: Nhập `" test@mail.com "` -> Trim thành `"test@mail.com"` -> Regex Email khớp -> **Hợp lệ**.

## 4. Trạng thái Build
`Build Succeeded`. Mã nguồn đã sẵn sàng để chạy thử.
