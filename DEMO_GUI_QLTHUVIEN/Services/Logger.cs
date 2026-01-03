using System;
using LibraryManagement.Data;
using LibraryManagement.Models;

namespace DoAnDemoUI.Services
{
    public static class Logger
    {
        public static void Log(string function, string action, string content)
        {
            try
            {
                using (var db = new LibraryContext())
                {
                    var log = new SystemLog
                    {
                        TenDangNhap = Session.CurrentUsername ?? "Unknown",
                        ChucNang = function,
                        HanhDong = action,
                        NoiDung = content,
                        ThoiGian = DateTime.Now
                    };
                    db.SystemLogs.Add(log);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                // Optionally handle logging failure (e.g. write to file)
            }
        }
    }
}
