using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Web_API.Models
{
    public partial class QLNHASACHContext : DbContext
    {
        public QLNHASACHContext()
        {
        }

        public QLNHASACHContext(DbContextOptions<QLNHASACHContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BaoCao> BaoCao { get; set; }
        public virtual DbSet<Ctbcnocong> Ctbcnocong { get; set; }
        public virtual DbSet<Ctbcton> Ctbcton { get; set; }
        public virtual DbSet<Cthd> Cthd { get; set; }
        public virtual DbSet<Ctpns> Ctpns { get; set; }
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<PhieuNhapSach> PhieuNhapSach { get; set; }
        public virtual DbSet<PhieuThuTien> PhieuThuTien { get; set; }
        public virtual DbSet<Sach> Sach { get; set; }
        public virtual DbSet<ThamSo> ThamSo { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //        optionsBuilder.UseSqlServer("Server=LAPTOP-0JBUKACI\\SQLEXPRESS;Database=QLNHASACH;Trusted_Connection=True;");
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaoCao>(entity =>
            {
                entity.HasKey(e => e.MaBc)
                    .HasName("PK__BaoCao__272475A6682D1D1A");

                entity.Property(e => e.MaBc)
                    .HasColumnName("MaBC")
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ctbcnocong>(entity =>
            {
                entity.HasKey(e => new { e.MaBc, e.MaKh })
                    .HasName("PK_CTBCTON");

                entity.ToTable("CTBCNOCONG");

                entity.Property(e => e.MaBc)
                    .HasColumnName("MaBC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MaKh)
                    .HasColumnName("MaKH")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.NoCuoi).HasColumnType("money");

                entity.Property(e => e.NoDau).HasColumnType("money");

                entity.Property(e => e.PhatSinh).HasColumnType("money");

                entity.HasOne(d => d.MaBcNavigation)
                    .WithMany(p => p.Ctbcnocong)
                    .HasForeignKey(d => d.MaBc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CTBCNOCONG__MaBC__5EBF139D");

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.Ctbcnocong)
                    .HasForeignKey(d => d.MaKh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CTBCNOCONG__MaKH__5FB337D6");
            });

            modelBuilder.Entity<Ctbcton>(entity =>
            {
                entity.HasKey(e => new { e.MaBc, e.MaSach })
                    .HasName("PK_CTBCNOCONG");

                entity.ToTable("CTBCTON");

                entity.Property(e => e.MaBc)
                    .HasColumnName("MaBC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MaSach)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaBcNavigation)
                    .WithMany(p => p.Ctbcton)
                    .HasForeignKey(d => d.MaBc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CTBCTON__MaBC__60A75C0F");

                entity.HasOne(d => d.MaSachNavigation)
                    .WithMany(p => p.Ctbcton)
                    .HasForeignKey(d => d.MaSach)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CTBCTON__MaSach__619B8048");
            });

            modelBuilder.Entity<Cthd>(entity =>
            {
                entity.HasKey(e => new { e.MaHd, e.MaSach });

                entity.ToTable("CTHD");

                entity.Property(e => e.MaHd)
                    .HasColumnName("MaHD")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MaSach)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DonGiaBan).HasColumnType("money");

                entity.HasOne(d => d.MaHdNavigation)
                    .WithMany(p => p.Cthd)
                    .HasForeignKey(d => d.MaHd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CTHD__MaHD__4BAC3F29");

                entity.HasOne(d => d.MaSachNavigation)
                    .WithMany(p => p.Cthd)
                    .HasForeignKey(d => d.MaSach)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CTHD__MaSach__4CA06362");
            });

            modelBuilder.Entity<Ctpns>(entity =>
            {
                entity.HasKey(e => new { e.MaPn, e.MaSach })
                    .HasName("PK_CTPN");

                entity.ToTable("CTPNS");

                entity.Property(e => e.MaPn)
                    .HasColumnName("MaPN")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MaSach)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DonGiaNhap).HasColumnType("money");

                entity.HasOne(d => d.MaPnNavigation)
                    .WithMany(p => p.Ctpns)
                    .HasForeignKey(d => d.MaPn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CTPNS__MaPN__49C3F6B7");

                entity.HasOne(d => d.MaSachNavigation)
                    .WithMany(p => p.Ctpns)
                    .HasForeignKey(d => d.MaSach)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CTPNS__MaSach__4AB81AF0");
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.MaHd)
                    .HasName("PK__HoaDon__2725A6E0C4581EF1");

                entity.Property(e => e.MaHd)
                    .HasColumnName("MaHD")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MaKh)
                    .HasColumnName("MaKH")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.NgayLap).HasColumnType("datetime");

                entity.Property(e => e.ThanhTien).HasColumnType("money");

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.HoaDon)
                    .HasForeignKey(d => d.MaKh)
                    .HasConstraintName("FK__HoaDon__MaKH__4E88ABD4");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKh)
                    .HasName("PK__KhachHan__2725CF1EF1157E6F");

                entity.Property(e => e.MaKh)
                    .HasColumnName("MaKH")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DiaChi).HasMaxLength(60);

                entity.Property(e => e.DienThoai)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TenKh)
                    .HasColumnName("TenKH")
                    .HasMaxLength(40);

                entity.Property(e => e.TienNo).HasColumnType("money");
            });

            modelBuilder.Entity<PhieuNhapSach>(entity =>
            {
                entity.HasKey(e => e.MaPn)
                    .HasName("PK__PhieuNha__2725E7F0B74E2007");

                entity.Property(e => e.MaPn)
                    .HasColumnName("MaPN")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.NgayNhap).HasColumnType("datetime");
            });

            modelBuilder.Entity<PhieuThuTien>(entity =>
            {
                entity.HasKey(e => e.MaPt)
                    .HasName("PK__PhieuThu__2725E7F6FC783793");

                entity.Property(e => e.MaPt)
                    .HasColumnName("MaPT")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DiaChi).HasMaxLength(60);

                entity.Property(e => e.DienThoai)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaKh)
                    .HasColumnName("MaKH")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.NgayThuTien).HasColumnType("datetime");

                entity.Property(e => e.TenKh)
                    .HasColumnName("TenKH")
                    .HasMaxLength(40);

                entity.Property(e => e.TienThu).HasColumnType("money");
            });

            modelBuilder.Entity<Sach>(entity =>
            {
                entity.HasKey(e => e.MaSach)
                    .HasName("PK__Sach__B235742DA3C63832");

                entity.Property(e => e.MaSach)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DonGia).HasColumnType("money");

                entity.Property(e => e.TacGia).HasMaxLength(40);

                entity.Property(e => e.TenSach).HasMaxLength(40);

                entity.Property(e => e.TheLoai).HasMaxLength(20);
            });

            modelBuilder.Entity<ThamSo>(entity =>
            {
                entity.HasKey(e => e.MaThamSo)
                    .HasName("PK__ThamSo__948C30E6FCE4B2A5");

                entity.Property(e => e.MaThamSo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.TenThamSo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public List<Sach> GetAllSach()
		{
            return this.Sach.FromSqlRaw("exec GetAllSach")
                .ToList();
        }

        public Sach GetSach(string id)
		{
            return this.Sach.FromSqlRaw("exec GetSach @p0",
                parameters: new[] { id }
                )
                .ToList()
                .FirstOrDefault();
        }

		public void InsertSach(string id, string ten, string theloai, string tacgia, decimal? dongia, int? soluong)
		{
			this.Database.ExecuteSqlCommand("exec InsertSach @p0, @p1, @p2, @p3, @p4, @p5",
				parameters: new[] { id, ten, theloai, tacgia, dongia.ToString(), soluong.ToString() }
				);
        }

		public void UpdateSach(string id, string ten, string theloai, string tacgia, decimal? dongia)
        {
            this.Database.ExecuteSqlCommand("exec UpdateSach @p0, @p1, @p2, @p3, @p4",
                parameters: new[] { id, ten, theloai, tacgia, dongia.ToString()}
                );
        }

		public void DeleteSach(string id)
        {
            this.Database.ExecuteSqlCommand("exec DeleteSach @p0",
                parameters: new[] { id }
                );
        }
    }
}
