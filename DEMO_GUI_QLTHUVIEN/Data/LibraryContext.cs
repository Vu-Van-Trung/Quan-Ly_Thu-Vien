using Microsoft.EntityFrameworkCore;
using LibraryManagement.Models;
using DoAnDemoUI.Model;
namespace LibraryManagement.Data
{
    public class LibraryContext : DbContext
    {
        // Constructor dùng cho Dependency Injection (thường dùng trong ASP.NET Core)
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
        }

        // Hoặc Constructor mặc định nếu dùng Console App/WPF
        public LibraryContext() { }

        // Khai báo các bảng dữ liệu
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Loan> Loans { get; set; }

        public virtual DbSet<User> Users { get; set; }
        // Cấu hình chuỗi kết nối (Nếu không dùng Dependency Injection)
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Thay thế chuỗi kết nối của bạn vào đây
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=LibraryDb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
            }
        }
    }
}