using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BookStore.Model
{
    public partial class BookkStoreContext : DbContext
    {
        public BookkStoreContext()
            : base("name=BookkStoreContext")
        {
        }

        public virtual DbSet<CT_GIOHANG> CT_GIOHANG { get; set; }
        public virtual DbSet<CT_HOADON> CT_HOADON { get; set; }
        public virtual DbSet<DANHGIASACH> DANHGIASACH { get; set; }
        public virtual DbSet<DIACHI> DIACHI { get; set; }
        public virtual DbSet<GIAOHANG> GIAOHANG { get; set; }
        public virtual DbSet<GIOHANG> GIOHANG { get; set; }
        public virtual DbSet<HOADON> HOADON { get; set; }
        public virtual DbSet<LOAISACH> LOAISACH { get; set; }
        public virtual DbSet<MAGIAMGIA> MAGIAMGIA { get; set; }
        public virtual DbSet<SACH> SACH { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOAN { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CT_GIOHANG>()
                .Property(e => e.ThanhTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CT_HOADON>()
                .Property(e => e.ThanhTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CT_HOADON>()
                .Property(e => e.Gia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DANHGIASACH>()
                .Property(e => e.TenDangNhap)
                .IsUnicode(false);

            modelBuilder.Entity<DIACHI>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<DIACHI>()
                .Property(e => e.TenDangNhap)
                .IsUnicode(false);

            modelBuilder.Entity<GIAOHANG>()
                .Property(e => e.Gia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<GIOHANG>()
                .Property(e => e.TenDangNhap)
                .IsUnicode(false);

            modelBuilder.Entity<GIOHANG>()
                .Property(e => e.TongTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<GIOHANG>()
                .HasMany(e => e.CT_GIOHANG)
                .WithRequired(e => e.GIOHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.TenDangNhap)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.TongTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.PhiVanChuyen)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HOADON>()
                .HasMany(e => e.CT_HOADON)
                .WithRequired(e => e.HOADON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MAGIAMGIA>()
                .Property(e => e.MaGiamGia1)
                .IsUnicode(false);

            modelBuilder.Entity<SACH>()
                .Property(e => e.Gia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SACH>()
                .HasMany(e => e.CT_GIOHANG)
                .WithRequired(e => e.SACH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SACH>()
                .HasMany(e => e.CT_HOADON)
                .WithRequired(e => e.SACH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SACH>()
                .HasMany(e => e.DANHGIASACH)
                .WithRequired(e => e.SACH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SACH>()
                .HasMany(e => e.TAIKHOAN)
                .WithMany(e => e.SACH)
                .Map(m => m.ToTable("SACHDAXEM").MapLeftKey("MaSach").MapRightKey("TenDangNhap"));

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.TenDangNhap)
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .HasMany(e => e.DANHGIASACH)
                .WithRequired(e => e.TAIKHOAN)
                .WillCascadeOnDelete(false);
        }
    }
}
