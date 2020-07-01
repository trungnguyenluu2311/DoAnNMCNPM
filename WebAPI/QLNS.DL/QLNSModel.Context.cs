﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLNS.DL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class QLNHASACHEntities : DbContext
    {
        public QLNHASACHEntities()
            : base("name=QLNHASACHEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BaoCao> BaoCaos { get; set; }
        public virtual DbSet<CTBCNOCONG> CTBCNOCONGs { get; set; }
        public virtual DbSet<CTBCTON> CTBCTONs { get; set; }
        public virtual DbSet<CTHD> CTHDs { get; set; }
        public virtual DbSet<CTPN> CTPNS { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<PhieuNhapSach> PhieuNhapSaches { get; set; }
        public virtual DbSet<PhieuThuTien> PhieuThuTiens { get; set; }
        public virtual DbSet<Sach> Saches { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }
    
        public virtual ObjectResult<GetAllSach_Result> GetAllSach()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllSach_Result>("GetAllSach");
        }
    
        public virtual int InsertSach(string masach, string tensach, string theloai, string tacgia, Nullable<decimal> dongia, Nullable<int> soluong)
        {
            var masachParameter = masach != null ?
                new ObjectParameter("masach", masach) :
                new ObjectParameter("masach", typeof(string));
    
            var tensachParameter = tensach != null ?
                new ObjectParameter("tensach", tensach) :
                new ObjectParameter("tensach", typeof(string));
    
            var theloaiParameter = theloai != null ?
                new ObjectParameter("theloai", theloai) :
                new ObjectParameter("theloai", typeof(string));
    
            var tacgiaParameter = tacgia != null ?
                new ObjectParameter("tacgia", tacgia) :
                new ObjectParameter("tacgia", typeof(string));
    
            var dongiaParameter = dongia.HasValue ?
                new ObjectParameter("dongia", dongia) :
                new ObjectParameter("dongia", typeof(decimal));
    
            var soluongParameter = soluong.HasValue ?
                new ObjectParameter("soluong", soluong) :
                new ObjectParameter("soluong", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertSach", masachParameter, tensachParameter, theloaiParameter, tacgiaParameter, dongiaParameter, soluongParameter);
        }
    
        public virtual int DeleteSach(string masach)
        {
            var masachParameter = masach != null ?
                new ObjectParameter("masach", masach) :
                new ObjectParameter("masach", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteSach", masachParameter);
        }
    
        public virtual int UpdateSach(string masach, string tensach, string theloai, string tacgia, Nullable<decimal> dongia)
        {
            var masachParameter = masach != null ?
                new ObjectParameter("masach", masach) :
                new ObjectParameter("masach", typeof(string));
    
            var tensachParameter = tensach != null ?
                new ObjectParameter("tensach", tensach) :
                new ObjectParameter("tensach", typeof(string));
    
            var theloaiParameter = theloai != null ?
                new ObjectParameter("theloai", theloai) :
                new ObjectParameter("theloai", typeof(string));
    
            var tacgiaParameter = tacgia != null ?
                new ObjectParameter("tacgia", tacgia) :
                new ObjectParameter("tacgia", typeof(string));
    
            var dongiaParameter = dongia.HasValue ?
                new ObjectParameter("dongia", dongia) :
                new ObjectParameter("dongia", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateSach", masachParameter, tensachParameter, theloaiParameter, tacgiaParameter, dongiaParameter);
        }
    
        public virtual ObjectResult<GetSach_Result> GetSach(string masach)
        {
            var masachParameter = masach != null ?
                new ObjectParameter("masach", masach) :
                new ObjectParameter("masach", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetSach_Result>("GetSach", masachParameter);
        }
    
        public virtual ObjectResult<GetSachBy_Result> GetSachBy(string masach, string tensach, string theloai, string tacgia)
        {
            var masachParameter = masach != null ?
                new ObjectParameter("masach", masach) :
                new ObjectParameter("masach", typeof(string));
    
            var tensachParameter = tensach != null ?
                new ObjectParameter("tensach", tensach) :
                new ObjectParameter("tensach", typeof(string));
    
            var theloaiParameter = theloai != null ?
                new ObjectParameter("theloai", theloai) :
                new ObjectParameter("theloai", typeof(string));
    
            var tacgiaParameter = tacgia != null ?
                new ObjectParameter("tacgia", tacgia) :
                new ObjectParameter("tacgia", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetSachBy_Result>("GetSachBy", masachParameter, tensachParameter, theloaiParameter, tacgiaParameter);
        }
    
        public virtual int DeleteKhachHang(string makh)
        {
            var makhParameter = makh != null ?
                new ObjectParameter("makh", makh) :
                new ObjectParameter("makh", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteKhachHang", makhParameter);
        }
    
        public virtual ObjectResult<GetAllKhachHang_Result> GetAllKhachHang()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllKhachHang_Result>("GetAllKhachHang");
        }
    
        public virtual ObjectResult<GetKhachHang_Result> GetKhachHang(string makh)
        {
            var makhParameter = makh != null ?
                new ObjectParameter("makh", makh) :
                new ObjectParameter("makh", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetKhachHang_Result>("GetKhachHang", makhParameter);
        }
    
        public virtual int InsertKhachHang(string makh, string tenkh, string diachi, string sdt, string email)
        {
            var makhParameter = makh != null ?
                new ObjectParameter("makh", makh) :
                new ObjectParameter("makh", typeof(string));
    
            var tenkhParameter = tenkh != null ?
                new ObjectParameter("tenkh", tenkh) :
                new ObjectParameter("tenkh", typeof(string));
    
            var diachiParameter = diachi != null ?
                new ObjectParameter("diachi", diachi) :
                new ObjectParameter("diachi", typeof(string));
    
            var sdtParameter = sdt != null ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertKhachHang", makhParameter, tenkhParameter, diachiParameter, sdtParameter, emailParameter);
        }
    
        public virtual int UpdateKhachHang(string makh, string tenkh, string diachi, string sdt, string email)
        {
            var makhParameter = makh != null ?
                new ObjectParameter("makh", makh) :
                new ObjectParameter("makh", typeof(string));
    
            var tenkhParameter = tenkh != null ?
                new ObjectParameter("tenkh", tenkh) :
                new ObjectParameter("tenkh", typeof(string));
    
            var diachiParameter = diachi != null ?
                new ObjectParameter("diachi", diachi) :
                new ObjectParameter("diachi", typeof(string));
    
            var sdtParameter = sdt != null ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateKhachHang", makhParameter, tenkhParameter, diachiParameter, sdtParameter, emailParameter);
        }
    
        public virtual ObjectResult<GetKhachHangBy_Result> GetKhachHangBy(string makh, string tenkh, string diachi, string sdt, string email)
        {
            var makhParameter = makh != null ?
                new ObjectParameter("makh", makh) :
                new ObjectParameter("makh", typeof(string));
    
            var tenkhParameter = tenkh != null ?
                new ObjectParameter("tenkh", tenkh) :
                new ObjectParameter("tenkh", typeof(string));
    
            var diachiParameter = diachi != null ?
                new ObjectParameter("diachi", diachi) :
                new ObjectParameter("diachi", typeof(string));
    
            var sdtParameter = sdt != null ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetKhachHangBy_Result>("GetKhachHangBy", makhParameter, tenkhParameter, diachiParameter, sdtParameter, emailParameter);
        }
    
        public virtual int DeletePhieuThuTien(string mapt)
        {
            var maptParameter = mapt != null ?
                new ObjectParameter("mapt", mapt) :
                new ObjectParameter("mapt", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeletePhieuThuTien", maptParameter);
        }
    
        public virtual ObjectResult<GetAllPhieuThuTien_Result> GetAllPhieuThuTien()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllPhieuThuTien_Result>("GetAllPhieuThuTien");
        }
    
        public virtual ObjectResult<GetPhieuThuTien_Result> GetPhieuThuTien(string mapt)
        {
            var maptParameter = mapt != null ?
                new ObjectParameter("mapt", mapt) :
                new ObjectParameter("mapt", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetPhieuThuTien_Result>("GetPhieuThuTien", maptParameter);
        }
    
        public virtual int InsertPhieuThuTien(string mapt, string makh, Nullable<System.DateTime> ngaythu, Nullable<decimal> tienthu)
        {
            var maptParameter = mapt != null ?
                new ObjectParameter("mapt", mapt) :
                new ObjectParameter("mapt", typeof(string));
    
            var makhParameter = makh != null ?
                new ObjectParameter("makh", makh) :
                new ObjectParameter("makh", typeof(string));
    
            var ngaythuParameter = ngaythu.HasValue ?
                new ObjectParameter("ngaythu", ngaythu) :
                new ObjectParameter("ngaythu", typeof(System.DateTime));
    
            var tienthuParameter = tienthu.HasValue ?
                new ObjectParameter("tienthu", tienthu) :
                new ObjectParameter("tienthu", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertPhieuThuTien", maptParameter, makhParameter, ngaythuParameter, tienthuParameter);
        }
    
        public virtual int UpdatePhieuThuTien(string mapt, string makh, Nullable<System.DateTime> ngaythu, Nullable<decimal> tienthu)
        {
            var maptParameter = mapt != null ?
                new ObjectParameter("mapt", mapt) :
                new ObjectParameter("mapt", typeof(string));
    
            var makhParameter = makh != null ?
                new ObjectParameter("makh", makh) :
                new ObjectParameter("makh", typeof(string));
    
            var ngaythuParameter = ngaythu.HasValue ?
                new ObjectParameter("ngaythu", ngaythu) :
                new ObjectParameter("ngaythu", typeof(System.DateTime));
    
            var tienthuParameter = tienthu.HasValue ?
                new ObjectParameter("tienthu", tienthu) :
                new ObjectParameter("tienthu", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdatePhieuThuTien", maptParameter, makhParameter, ngaythuParameter, tienthuParameter);
        }
    
        public virtual ObjectResult<string> GetAllUsername()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetAllUsername");
        }
    
        public virtual ObjectResult<GetUserBy_Result> GetUserBy(string username, string password)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetUserBy_Result>("GetUserBy", usernameParameter, passwordParameter);
        }
    
        public virtual int InsertUser(string id, string username, string password, Nullable<int> quyenhan)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var quyenhanParameter = quyenhan.HasValue ?
                new ObjectParameter("quyenhan", quyenhan) :
                new ObjectParameter("quyenhan", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertUser", idParameter, usernameParameter, passwordParameter, quyenhanParameter);
        }
    
        public virtual ObjectResult<string> GetAllUID()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetAllUID");
        }
    }
}
