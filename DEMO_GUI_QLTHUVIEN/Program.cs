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

            // SỬA DÒNG NÀY: Đổi thành new Login1()
            Application.Run(new Login1());
        }
    }
}