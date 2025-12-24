using Microsoft.EntityFrameworkCore;
using LibraryManagement.Models;
using DoAnDemoUI.Model;

namespace LibraryManagement.Data
{
    public class LibraryContext : DbContext
    {
        // Constructor dùng cho Dependency Injection
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
        }

        // Constructor mặc định
        public LibraryContext() { }

        // Khai báo các DbSet (bảng dữ liệu)
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<LoanDetail> LoanDetails { get; set; }
        public DbSet<Fine> Fines { get; set; }

        // Cấu hình chuỗi kết nối
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Connection string đến database QuanLyThuVien
                optionsBuilder.UseSqlServer(
                    "Server=.;Database=QuanLyThuVien;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True"
                );
            }
        }

        // Cấu hình Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ===== AUTHOR (TAC_GIA) =====
            modelBuilder.Entity<Author>(entity =>
            {
                entity.HasKey(e => e.AuthorId);
                entity.Property(e => e.Name).IsRequired();
            });

            // ===== CATEGORY (THE_LOAI) =====
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CategoryId);
                entity.Property(e => e.Name).IsRequired();
                entity.HasIndex(e => e.Name).IsUnique();
            });

            // ===== PUBLISHER (NHA_XUAT_BAN) =====
            modelBuilder.Entity<Publisher>(entity =>
            {
                entity.HasKey(e => e.PublisherId);
                entity.Property(e => e.TenNhaXuatBan).IsRequired();
            });

            // ===== STAFF (NHAN_VIEN) =====
            modelBuilder.Entity<Staff>(entity =>
            {
                entity.HasKey(e => e.StaffId);
                entity.Property(e => e.HoTen).IsRequired();
                entity.Property(e => e.ChucVu).IsRequired();
            });

            // ===== MEMBER (DOC_GIA) =====
            modelBuilder.Entity<Member>(entity =>
            {
                entity.HasKey(e => e.MemberId);
                entity.Property(e => e.FullName).IsRequired();
                entity.HasIndex(e => e.CMND).IsUnique();
                entity.HasIndex(e => e.PhoneNumber);
                entity.HasIndex(e => e.TrangThai);
            });

            // ===== BOOK (SACH) =====
            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(e => e.BookId);
                entity.Property(e => e.Title).IsRequired();
                entity.Property(e => e.GiaTien).HasColumnType("decimal(18,2)");

                // Relationships
                entity.HasOne(b => b.Author)
                    .WithMany(a => a.Books)
                    .HasForeignKey(b => b.AuthorId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(b => b.Category)
                    .WithMany(c => c.Books)
                    .HasForeignKey(b => b.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(b => b.Publisher)
                    .WithMany(p => p.Books)
                    .HasForeignKey(b => b.PublisherId)
                    .OnDelete(DeleteBehavior.Restrict);

                // Indexes
                entity.HasIndex(e => e.Title);
                entity.HasIndex(e => e.AuthorId);
                entity.HasIndex(e => e.CategoryId);
                entity.HasIndex(e => e.TrangThai);
            });

            // ===== USER (TAI_KHOAN) =====
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Username).IsRequired();
                entity.Property(e => e.Password).IsRequired();
                entity.HasIndex(e => e.Username).IsUnique();

                // Relationship: 1-1 với Staff
                entity.HasOne(u => u.Staff)
                    .WithOne(s => s.User)
                    .HasForeignKey<User>(u => u.StaffId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            // ===== LOAN (PHIEU_MUON) =====
            modelBuilder.Entity<Loan>(entity =>
            {
                entity.HasKey(e => e.LoanId);
                entity.Property(e => e.DueDate).IsRequired();

                // Relationships
                entity.HasOne(l => l.Member)
                    .WithMany(m => m.Loans)
                    .HasForeignKey(l => l.MemberId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(l => l.Staff)
                    .WithMany(s => s.Loans)
                    .HasForeignKey(l => l.StaffId)
                    .OnDelete(DeleteBehavior.Restrict);

                // Indexes
                entity.HasIndex(e => e.MemberId);
                entity.HasIndex(e => e.LoanDate);
                entity.HasIndex(e => e.TrangThai);
            });

            // ===== LOAN DETAIL (CHI_TIET_PHIEU_MUON) =====
            modelBuilder.Entity<LoanDetail>(entity =>
            {
                entity.HasKey(e => e.LoanDetailId);

                // Relationships
                entity.HasOne(ld => ld.Loan)
                    .WithMany(l => l.LoanDetails)
                    .HasForeignKey(ld => ld.LoanId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(ld => ld.Book)
                    .WithMany(b => b.LoanDetails)
                    .HasForeignKey(ld => ld.BookId)
                    .OnDelete(DeleteBehavior.Restrict);

                // Indexes
                entity.HasIndex(e => e.LoanId);
                entity.HasIndex(e => e.BookId);
            });

            // ===== FINE (PHAT) =====
            modelBuilder.Entity<Fine>(entity =>
            {
                entity.HasKey(e => e.FineId);
                entity.Property(e => e.LyDo).IsRequired();
                entity.Property(e => e.SoTienPhat).HasColumnType("decimal(18,2)");

                // Relationship
                entity.HasOne(f => f.Loan)
                    .WithMany(l => l.Fines)
                    .HasForeignKey(f => f.LoanId)
                    .OnDelete(DeleteBehavior.Cascade);

                // Indexes
                entity.HasIndex(e => e.LoanId);
                entity.HasIndex(e => e.TrangThaiThanhToan);
            });
        }
    }
}