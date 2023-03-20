using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebGetAPIKClinic2.Authorize;
using WebGetAPIKClinic2.Repository;
namespace WebGetAPIKClinic2.Controllers
{
    [BearerAuthorization]
    public class DanhMucController : ApiController
    {
        private readonly DanhMucRepository danhMucRepository;
        public DanhMucController()
        {
            danhMucRepository = new DanhMucRepository();
        }
        [Route("api/DanhMuc")]
        public IHttpActionResult GetDanhMuc(string Action = null, int? Idx = null, string Text = null, string MaNhomDichVu = null, string TenNhomDichVu = null, int? TamNgung = null, int? NguoiTao = null, DateTime? NgayTao = null, int? NguoiCapNhat = null, DateTime? NgayCapNhat = null, int? Huy = null, string MaDichVu = null, string TenDichVu = null, decimal? GiaDichVu = null, string DVT = null, int? CoGiaTriChuan = null, int? Cap = null, int? IsDichVuCha = null, int? CapTren_Id = null, int? NhomDichVu_Id = null, int? DichVu_Id = null, string GiaTriDungChung = null, string NamMax = null, string NamMin = null, string NuMax = null, string NuMin = null, string TreEmMax = null, string TreEmMin = null, string MaNhomBenh = null, string TenNhomBenh = null, int? NhomBenh_id = null, string TenKTV = null, string TenBacSi = null, int? LoaiPhongBan_Id = null, string MaLoaiPhongBan = null, string TenLoaiPhongBan = null, int? PhongBan_Id = null, string MaPhongBan = null, string TenPhongBan = null, int? QuocGia_Id = null, string MaQuocGia = null, string TenQuocGia = null, string TenTiengAnh = null, string TenLaTin = null, string TenTat = null, int? DonViTinh_Id = null, string MaDonViTinh = null, string TenDonViTinh = null, string LoaiThuoc = null, decimal? GiaTriQuyDoi = null, int? LoaiDuoc_Id = null, string MaLoaiDuoc = null, string TenLoaiDuoc = null, int? Duoc_Id = null, string MaDuoc = null, string TenDuoc = null, string DonViTinh = null, string HangSanXuat = null, int? HangSanXuat_Id = null, string QuocGia = null, string TenDuocDayDu = null, string TenKhongDau = null, string TenHoatChat = null, string CachSuDung = null, string HamLuong = null, string CongDung = null, string PhanLoaiDuoc = null, string DuongDung = null, DateTime? DateStart = null, DateTime? DateEnd = null, decimal? SoLuongNhapVao = null, decimal? SoLuongTon = null, decimal? DonGiaVon = null, decimal? DonGia = null, int? User_Id = null, int? BacSi_Id = null, int? ToaThuocMau_Id = null, string MaToaThuocMau = null, string TenToaThuocMau = null, int? MapToaThuocMauVoiDuoc_Id = null, decimal? SoLuong = null, decimal? SoNgay = null, decimal? Sang = null, decimal? Trua = null, decimal? Chieu = null, decimal? Toi = null, int? LoaiMau_Id = null, string MaLoaiMau = null, string TenLoaiMau = null, int? TuDienKetLuan_Id = null, string MaTuDien = null, string TenTuDien = null, string STT = null, string TieuDe = null, int? GioiTinh = null, string ChanDoan = null, int? TinhNgayDuSinh = null, string KetLuan = null, string MoTa = null, string MoTa_Text = null, string GhiChu = null, string LoiDan = null, int? BenhVien_Id = null, string MaBenhVien = null, string TenBenhVien = null, string DiaChi1 = null, string DiaChi2 = null, string DiaChi3 = null, string SoDienThoai1 = null, string SoDienThoai2 = null, string SoDienThoai3 = null)
        {
            DataTable danhMucDataTable = danhMucRepository.DanhMuc(Action, Idx, Text, MaNhomDichVu, TenNhomDichVu, TamNgung, NguoiTao, NgayTao, NguoiCapNhat, NgayCapNhat, Huy, MaDichVu, TenDichVu, GiaDichVu, DVT, CoGiaTriChuan, Cap, IsDichVuCha, CapTren_Id, NhomDichVu_Id, DichVu_Id, GiaTriDungChung, NamMax, NamMin, NuMax, NuMin, TreEmMax, TreEmMin, MaNhomBenh, TenNhomBenh, NhomBenh_id, TenKTV, TenBacSi, LoaiPhongBan_Id, MaLoaiPhongBan, TenLoaiPhongBan, PhongBan_Id, MaPhongBan, TenPhongBan, QuocGia_Id, MaQuocGia, TenQuocGia, TenTiengAnh, TenLaTin, TenTat, DonViTinh_Id, MaDonViTinh, TenDonViTinh, LoaiThuoc, GiaTriQuyDoi, LoaiDuoc_Id, MaLoaiDuoc, TenLoaiDuoc, Duoc_Id, MaDuoc, TenDuoc, DonViTinh, HangSanXuat, HangSanXuat_Id, QuocGia, TenDuocDayDu, TenKhongDau, TenHoatChat, CachSuDung, HamLuong, CongDung, PhanLoaiDuoc, DuongDung, DateStart, DateEnd, SoLuongNhapVao, SoLuongTon, DonGiaVon, DonGia, User_Id, BacSi_Id, ToaThuocMau_Id, MaToaThuocMau, TenToaThuocMau, MapToaThuocMauVoiDuoc_Id, SoLuong, SoNgay, Sang, Trua, Chieu, Toi, LoaiMau_Id, MaLoaiMau, TenLoaiMau, TuDienKetLuan_Id, MaTuDien, TenTuDien, STT, TieuDe, GioiTinh, ChanDoan, TinhNgayDuSinh, KetLuan, MoTa, MoTa_Text, GhiChu, LoiDan, BenhVien_Id, MaBenhVien, TenBenhVien, DiaChi1, DiaChi2, DiaChi3, SoDienThoai1, SoDienThoai2, SoDienThoai3);
            return Ok(danhMucDataTable);
        }
    }
}
