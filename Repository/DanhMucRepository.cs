using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebGetAPIKClinic2.Models;
namespace WebGetAPIKClinic2.Repository
{
    public class DanhMucRepository
    {
        private readonly string _connectionString;
        private readonly string secretKey = "secretkey";
        public DanhMucRepository()
        {
            _connectionString = EncryptionDecryptionManager.Decrypt(ConfigurationManager.AppSettings["ConnectionString"], secretKey);
        }
        public DataTable DanhMuc(string Action, int? Idx, string Text, string MaNhomDichVu, string TenNhomDichVu, int? TamNgung, int? NguoiTao, DateTime? NgayTao, int? NguoiCapNhat, DateTime? NgayCapNhat, int? Huy, string MaDichVu, string TenDichVu, decimal? GiaDichVu, string DVT, int? CoGiaTriChuan, int? Cap, int? IsDichVuCha, int? CapTren_Id, int? NhomDichVu_Id, int? DichVu_Id, string GiaTriDungChung, string NamMax, string NamMin, string NuMax, string NuMin, string TreEmMax, string TreEmMin, string MaNhomBenh, string TenNhomBenh, int? NhomBenh_id, string TenKTV, string TenBacSi, int? LoaiPhongBan_Id, string MaLoaiPhongBan, string TenLoaiPhongBan, int? PhongBan_Id, string MaPhongBan, string TenPhongBan, int? QuocGia_Id, string MaQuocGia, string TenQuocGia, string TenTiengAnh, string TenLaTin, string TenTat, int? DonViTinh_Id, string MaDonViTinh, string TenDonViTinh, string LoaiThuoc, decimal? GiaTriQuyDoi, int? LoaiDuoc_Id, string MaLoaiDuoc, string TenLoaiDuoc, int? Duoc_Id, string MaDuoc, string TenDuoc, string DonViTinh, string HangSanXuat, int? HangSanXuat_Id, string QuocGia, string TenDuocDayDu, string TenKhongDau, string TenHoatChat, string CachSuDung, string HamLuong, string CongDung, string PhanLoaiDuoc, string DuongDung, DateTime? DateStart, DateTime? DateEnd, decimal? SoLuongNhapVao, decimal? SoLuongTon, decimal? DonGiaVon, decimal? DonGia, int? User_Id, int? BacSi_Id, int? ToaThuocMau_Id, string MaToaThuocMau, string TenToaThuocMau, int? MapToaThuocMauVoiDuoc_Id, decimal? SoLuong, decimal? SoNgay, decimal? Sang, decimal? Trua, decimal? Chieu, decimal? Toi, int? LoaiMau_Id, string MaLoaiMau, string TenLoaiMau, int? TuDienKetLuan_Id, string MaTuDien, string TenTuDien, string STT, string TieuDe, int? GioiTinh, string ChanDoan, int? TinhNgayDuSinh, string KetLuan, string MoTa, string MoTa_Text, string GhiChu, string LoiDan, int? BenhVien_Id, string MaBenhVien, string TenBenhVien, string DiaChi1, string DiaChi2, string DiaChi3, string SoDienThoai1, string SoDienThoai2, string SoDienThoai3)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_006_DanhMuc", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    if (Action != null) command.Parameters.AddWithValue("@Action", Action);
                    if (Idx != null) command.Parameters.AddWithValue("@Idx", Idx);
                    if (Text != null) command.Parameters.AddWithValue("@Text", Text);
                    if (MaNhomDichVu != null) command.Parameters.AddWithValue("@MaNhomDichVu", MaNhomDichVu);
                    if (TenNhomDichVu != null) command.Parameters.AddWithValue("@TenNhomDichVu", TenNhomDichVu);
                    if (TamNgung != null) command.Parameters.AddWithValue("@TamNgung", TamNgung);
                    if (NguoiTao != null) command.Parameters.AddWithValue("@NguoiTao", NguoiTao);
                    if (NgayTao.HasValue) command.Parameters.AddWithValue("@NgayTao", NgayTao);
                    if (NguoiCapNhat != null) command.Parameters.AddWithValue("@NguoiCapNhat", NguoiCapNhat);
                    if (NgayCapNhat.HasValue) command.Parameters.AddWithValue("@NgayCapNhat", NgayCapNhat);
                    if (Huy != null) command.Parameters.AddWithValue("@Huy", Huy);
                    if (MaDichVu != null) command.Parameters.AddWithValue("@MaDichVu", MaDichVu);
                    if (TenDichVu != null) command.Parameters.AddWithValue("@TenDichVu", TenDichVu);
                    if (GiaDichVu != null) command.Parameters.AddWithValue("@GiaDichVu", GiaDichVu);
                    if (DVT != null) command.Parameters.AddWithValue("@DVT", DVT);
                    if (CoGiaTriChuan != null) command.Parameters.AddWithValue("@CoGiaTriChuan", CoGiaTriChuan);
                    if (Cap != null) command.Parameters.AddWithValue("@Cap", Cap);
                    if (IsDichVuCha != null) command.Parameters.AddWithValue("@IsDichVuCha", IsDichVuCha);
                    if (CapTren_Id != null) command.Parameters.AddWithValue("@CapTren_Id", CapTren_Id);
                    if (NhomDichVu_Id != null) command.Parameters.AddWithValue("@NhomDichVu_Id", NhomDichVu_Id);
                    if (DichVu_Id != null) command.Parameters.AddWithValue("@DichVu_Id", DichVu_Id);
                    if (GiaTriDungChung != null) command.Parameters.AddWithValue("@GiaTriDungChung", GiaTriDungChung);
                    if (NamMax != null) command.Parameters.AddWithValue("@NamMax", NamMax);
                    if (NamMin != null) command.Parameters.AddWithValue("@NamMin", NamMin);
                    if (NuMax != null) command.Parameters.AddWithValue("@NuMax", NuMax);
                    if (NuMin != null) command.Parameters.AddWithValue("@NuMin", NuMin);
                    if (TreEmMax != null) command.Parameters.AddWithValue("@TreEmMax", TreEmMax);
                    if (TreEmMin != null) command.Parameters.AddWithValue("@TreEmMin", TreEmMin);
                    if (MaNhomBenh != null) command.Parameters.AddWithValue("@MaNhomBenh", MaNhomBenh);
                    if (TenNhomBenh != null) command.Parameters.AddWithValue("@TenNhomBenh", TenNhomBenh);
                    if (NhomBenh_id != null) command.Parameters.AddWithValue("@NhomBenh_id", NhomBenh_id);
                    if (TenKTV != null) command.Parameters.AddWithValue("@TenKTV", TenKTV);
                    if (TenBacSi != null) command.Parameters.AddWithValue("@TenBacSi", TenBacSi);
                    if (LoaiPhongBan_Id != null) command.Parameters.AddWithValue("@LoaiPhongBan_Id", LoaiPhongBan_Id);
                    if (MaLoaiPhongBan != null) command.Parameters.AddWithValue("@MaLoaiPhongBan", MaLoaiPhongBan);
                    if (TenLoaiPhongBan != null) command.Parameters.AddWithValue("@TenLoaiPhongBan", TenLoaiPhongBan);
                    if (PhongBan_Id != null) command.Parameters.AddWithValue("@PhongBan_Id", PhongBan_Id);
                    if (MaPhongBan != null) command.Parameters.AddWithValue("@MaPhongBan", MaPhongBan);
                    if (TenPhongBan != null) command.Parameters.AddWithValue("@TenPhongBan", TenPhongBan);
                    if (QuocGia_Id != null) command.Parameters.AddWithValue("@QuocGia_Id", QuocGia_Id);
                    if (MaQuocGia != null) command.Parameters.AddWithValue("@MaQuocGia", MaQuocGia);
                    if (TenQuocGia != null) command.Parameters.AddWithValue("@TenQuocGia", TenQuocGia);
                    if (TenTiengAnh != null) command.Parameters.AddWithValue("@TenTiengAnh", TenTiengAnh);
                    if (TenLaTin != null) command.Parameters.AddWithValue("@TenLaTin", TenLaTin);
                    if (TenTat != null) command.Parameters.AddWithValue("@TenTat", TenTat);
                    if (DonViTinh_Id != null) command.Parameters.AddWithValue("@DonViTinh_Id", DonViTinh_Id);
                    if (MaDonViTinh != null) command.Parameters.AddWithValue("@MaDonViTinh", MaDonViTinh);
                    if (TenDonViTinh != null) command.Parameters.AddWithValue("@TenDonViTinh", TenDonViTinh);
                    if (LoaiThuoc != null) command.Parameters.AddWithValue("@LoaiThuoc", LoaiThuoc);
                    if (GiaTriQuyDoi != null) command.Parameters.AddWithValue("@GiaTriQuyDoi", GiaTriQuyDoi);
                    if (LoaiDuoc_Id != null) command.Parameters.AddWithValue("@LoaiDuoc_Id", LoaiDuoc_Id);
                    if (MaLoaiDuoc != null) command.Parameters.AddWithValue("@MaLoaiDuoc", MaLoaiDuoc);
                    if (TenLoaiDuoc != null) command.Parameters.AddWithValue("@TenLoaiDuoc", TenLoaiDuoc);
                    if (Duoc_Id != null) command.Parameters.AddWithValue("@Duoc_Id", Duoc_Id);
                    if (MaDuoc != null) command.Parameters.AddWithValue("@MaDuoc", MaDuoc);
                    if (TenDuoc != null) command.Parameters.AddWithValue("@TenDuoc", TenDuoc);
                    if (DonViTinh != null) command.Parameters.AddWithValue("@DonViTinh", DonViTinh);
                    if (HangSanXuat != null) command.Parameters.AddWithValue("@HangSanXuat", HangSanXuat);
                    if (HangSanXuat_Id != null) command.Parameters.AddWithValue("@HangSanXuat_Id", HangSanXuat_Id);
                    if (QuocGia != null) command.Parameters.AddWithValue("@QuocGia", QuocGia);
                    if (TenDuocDayDu != null) command.Parameters.AddWithValue("@TenDuocDayDu", TenDuocDayDu);
                    if (TenKhongDau != null) command.Parameters.AddWithValue("@TenKhongDau", TenKhongDau);
                    if (TenHoatChat != null) command.Parameters.AddWithValue("@TenHoatChat", TenHoatChat);
                    if (CachSuDung != null) command.Parameters.AddWithValue("@CachSuDung", CachSuDung);
                    if (HamLuong != null) command.Parameters.AddWithValue("@HamLuong", HamLuong);
                    if (CongDung != null) command.Parameters.AddWithValue("@CongDung", CongDung);
                    if (PhanLoaiDuoc != null) command.Parameters.AddWithValue("@PhanLoaiDuoc", PhanLoaiDuoc);
                    if (DuongDung != null) command.Parameters.AddWithValue("@DuongDung", DuongDung);
                    if (DateStart.HasValue) command.Parameters.AddWithValue("@DateStart", DateStart);
                    if (DateEnd.HasValue) command.Parameters.AddWithValue("@DateEnd", DateEnd);
                    if (SoLuongNhapVao != null) command.Parameters.AddWithValue("@SoLuongNhapVao", SoLuongNhapVao);
                    if (SoLuongTon != null) command.Parameters.AddWithValue("@SoLuongTon", SoLuongTon);
                    if (DonGiaVon != null) command.Parameters.AddWithValue("@DonGiaVon", DonGiaVon);
                    if (DonGia != null) command.Parameters.AddWithValue("@DonGia", DonGia);
                    if (User_Id != null) command.Parameters.AddWithValue("@User_Id", User_Id);
                    if (BacSi_Id != null) command.Parameters.AddWithValue("@BacSi_Id", BacSi_Id);
                    if (ToaThuocMau_Id != null) command.Parameters.AddWithValue("@ToaThuocMau_Id", ToaThuocMau_Id);
                    if (MaToaThuocMau != null) command.Parameters.AddWithValue("@MaToaThuocMau", MaToaThuocMau);
                    if (TenToaThuocMau != null) command.Parameters.AddWithValue("@TenToaThuocMau", TenToaThuocMau);
                    if (MapToaThuocMauVoiDuoc_Id != null) command.Parameters.AddWithValue("@MapToaThuocMauVoiDuoc_Id", MapToaThuocMauVoiDuoc_Id);
                    if (SoLuong != null) command.Parameters.AddWithValue("@SoLuong", SoLuong);
                    if (SoNgay != null) command.Parameters.AddWithValue("@SoNgay", SoNgay);
                    if (Sang != null) command.Parameters.AddWithValue("@Sang", Sang);
                    if (Trua != null) command.Parameters.AddWithValue("@Trua", Trua);
                    if (Chieu != null) command.Parameters.AddWithValue("@Chieu", Chieu);
                    if (Toi != null) command.Parameters.AddWithValue("@Toi", Toi);
                    if (LoaiMau_Id != null) command.Parameters.AddWithValue("@LoaiMau_Id", LoaiMau_Id);
                    if (MaLoaiMau != null) command.Parameters.AddWithValue("@MaLoaiMau", MaLoaiMau);
                    if (TenLoaiMau != null) command.Parameters.AddWithValue("@TenLoaiMau", TenLoaiMau);
                    if (TuDienKetLuan_Id != null) command.Parameters.AddWithValue("@TuDienKetLuan_Id", TuDienKetLuan_Id);
                    if (MaTuDien != null) command.Parameters.AddWithValue("@MaTuDien", MaTuDien);
                    if (TenTuDien != null) command.Parameters.AddWithValue("@TenTuDien", TenTuDien);
                    if (STT != null) command.Parameters.AddWithValue("@STT", STT);
                    if (TieuDe != null) command.Parameters.AddWithValue("@TieuDe", TieuDe);
                    if (GioiTinh != null) command.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                    if (ChanDoan != null) command.Parameters.AddWithValue("@ChanDoan", ChanDoan);
                    if (TinhNgayDuSinh != null) command.Parameters.AddWithValue("@TinhNgayDuSinh", TinhNgayDuSinh);
                    if (KetLuan != null) command.Parameters.AddWithValue("@KetLuan", KetLuan);
                    if (MoTa != null) command.Parameters.AddWithValue("@MoTa", MoTa);
                    if (MoTa_Text != null) command.Parameters.AddWithValue("@MoTa_Text", MoTa_Text);
                    if (GhiChu != null) command.Parameters.AddWithValue("@GhiChu", GhiChu);
                    if (LoiDan != null) command.Parameters.AddWithValue("@LoiDan", LoiDan);
                    if (BenhVien_Id != null) command.Parameters.AddWithValue("@BenhVien_Id", BenhVien_Id);
                    if (MaBenhVien != null) command.Parameters.AddWithValue("@MaBenhVien", MaBenhVien);
                    if (TenBenhVien != null) command.Parameters.AddWithValue("@TenBenhVien", TenBenhVien);
                    if (DiaChi1 != null) command.Parameters.AddWithValue("@DiaChi1", DiaChi1);
                    if (DiaChi2 != null) command.Parameters.AddWithValue("@DiaChi2", DiaChi2);
                    if (DiaChi3 != null) command.Parameters.AddWithValue("@DiaChi3", DiaChi3);
                    if (SoDienThoai1 != null) command.Parameters.AddWithValue("@SoDienThoai1", SoDienThoai1);
                    if (SoDienThoai2 != null) command.Parameters.AddWithValue("@SoDienThoai2", SoDienThoai2);
                    if (SoDienThoai3 != null) command.Parameters.AddWithValue("@SoDienThoai3", SoDienThoai3);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter();
                    connection.Open();
                    command.ExecuteNonQuery();
                    dataAdapter.SelectCommand = command;
                    dataAdapter.Fill(dt);
                    connection.Close();
                }
            }
            return dt;
        }
    }
}
