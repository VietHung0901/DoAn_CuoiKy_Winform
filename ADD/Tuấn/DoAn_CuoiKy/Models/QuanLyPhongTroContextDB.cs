using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DoAn_CuoiKy.Models
{
    public partial class QuanLyPhongTroContextDB : DbContext
    {
        public QuanLyPhongTroContextDB()
            : base("name=QuanLyPhongTroContextDB")
        {
        }

        public virtual DbSet<DICHVU> DICHVU { get; set; }
        public virtual DbSet<HOADON> HOADON { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANG { get; set; }
        public virtual DbSet<MALOAIPHONG> MALOAIPHONG { get; set; }
        public virtual DbSet<PHIEUDANGKY> PHIEUDANGKY { get; set; }
        public virtual DbSet<PHIEUPHAT> PHIEUPHAT { get; set; }
        public virtual DbSet<PHONG> PHONG { get; set; }
        public virtual DbSet<THIETBI> THIETBIs { get; set; }
        public virtual DbSet<CT_DICHVU> CT_DICHVU { get; set; }
        public virtual DbSet<CT_LAPDAT> CT_LAPDATes { get; set; }
        public virtual DbSet<DANGNHAP> DANGNHAP { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DICHVU>()
                .Property(e => e.Gia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DICHVU>()
                .HasMany(e => e.CT_DICHVU)
                .WithRequired(e => e.DICHVU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.TongTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HOADON>()
                .HasMany(e => e.CT_DICHVU)
                .WithRequired(e => e.HOADON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.MaKH)
                .IsFixedLength();

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.PHIEUDANGKY)
                .WithRequired(e => e.KHACHHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.PHIEUPHAT)
                .WithRequired(e => e.KHACHHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MALOAIPHONG>()
                .Property(e => e.DonGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MALOAIPHONG>()
                .HasMany(e => e.PHONG)
                .WithRequired(e => e.MALOAIPHONG1)
                .HasForeignKey(e => e.MaLoaiPhong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEUDANGKY>()
                .Property(e => e.MaKH)
                .IsFixedLength();

            modelBuilder.Entity<PHIEUPHAT>()
                .Property(e => e.MaKH)
                .IsFixedLength();

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.PHIEUDANGKY)
                .WithRequired(e => e.PHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.CT_LAPDAT)
                .WithRequired(e => e.PHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<THIETBI>()
                .HasMany(e => e.CT_LAPDAT)
                .WithRequired(e => e.THIETBI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DANGNHAP>()
                .Property(e => e.UserName)
                .IsFixedLength();

            modelBuilder.Entity<DANGNHAP>()
                .Property(e => e.PassWord)
                .IsFixedLength();
        }
    }
}
