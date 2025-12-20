using System;
using System.Windows.Forms;

namespace DoAnDemoUI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool isRunning = true;

            while (isRunning)
            {
                // 1. Khởi tạo và hiện Form Login
                Login1 frmLogin = new Login1();

                // Chờ kết quả từ Form Login
                DialogResult result = frmLogin.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // 2. Nếu đăng nhập thành công -> Chạy Form Chính
                    // Lúc này Form Login đã đóng, Form Chính bắt đầu chạy
                    QuanLiThuVien frmMain = new QuanLiThuVien();
                    Application.Run(frmMain);

                    // --- CHÚ Ý ---
                    // Khi Application.Run kết thúc (tức là Form QuanLiThuVien bị đóng bằng lệnh Close),
                    // code sẽ chạy xuống dưới đây -> Hết vòng lặp -> Quay lại đầu vòng lặp -> Mở lại Login.
                }
                else
                {
                    // 3. Nếu người dùng bấm Cancel hoặc đóng Form Login -> Thoát vòng lặp
                    isRunning = false;
                }
            }
        }
    }
}