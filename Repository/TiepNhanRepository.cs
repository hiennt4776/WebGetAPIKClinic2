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
    public class TiepNhanRepository
    {
        private readonly string _connectionString;
        private readonly string secretKey = "secretkey";
        public TiepNhanRepository()
        {
            _connectionString = EncryptionDecryptionManager.Decrypt(ConfigurationManager.AppSettings["ConnectionString"], secretKey);
        }
        public DataTable TiepNhan(string Action, string Loai, string text, int? IDx, int? User_Id, int? BenhNhan_Id, string MaYTe, string SoVaoVien, string TenBenhNhan, int? GioiTinh, DateTime? NgaySinh, int? NamSinh, string SoDienThoai, string CMND, string DiaChiChiTiet, int? XaPhuong, int? QuanHuyen, int? TinhThanh, int? TiepNhan_Id, string SoTiepNhan, int? SoThuTu, int? UuTien, int? NoiTiepNhan_Id, int? NguoiTiepNhan_Id, DateTime? NgayTiepNhan, DateTime? ThoiGianTiepNhan, int? NamTiepNhan, int? ThangTiepNhan, string DiaChiLienHe, string GhiChu, int? BacSiChiDinh, int? NguoiTao, DateTime? NgayTao, int? NguoiCapNhat, DateTime? NgayCapNhat, int? Huy, string SoPhieuYeuCau, DateTime? NgayYeuCau, DateTime? ThoiGianYeuCau, int? DichVu_Id, int? SoLuong, decimal? DonGiaDichVu, decimal? ThanhTienDichVu, int? DuocPhepThucHien, string TrangThai, int? NguoiChiDinh, int? PhienDangNhap_Id, int? CLSYeuCau_Id, string ThaoTac, int? CLSYeuCau_Cha_Id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_002_TiepNhan", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    if (Action != null) command.Parameters.AddWithValue("@Action", Action);
                    if (Loai != null) command.Parameters.AddWithValue("@Loai", Loai);
                    if (text != null) command.Parameters.AddWithValue("@text", text);
                    if (IDx != null) command.Parameters.AddWithValue("@IDx", IDx);
                    if (User_Id != null) command.Parameters.AddWithValue("@User_Id", User_Id);
                    if (BenhNhan_Id != null) command.Parameters.AddWithValue("@BenhNhan_Id", BenhNhan_Id);
                    if (MaYTe != null) command.Parameters.AddWithValue("@MaYTe", MaYTe);
                    if (SoVaoVien != null) command.Parameters.AddWithValue("@SoVaoVien", SoVaoVien);
                    if (TenBenhNhan != null) command.Parameters.AddWithValue("@TenBenhNhan", TenBenhNhan);
                    if (GioiTinh != null) command.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                    if (NgaySinh.HasValue) command.Parameters.AddWithValue("@NgaySinh", NgaySinh);
                    if (NamSinh != null) command.Parameters.AddWithValue("@NamSinh", NamSinh);
                    if (SoDienThoai != null) command.Parameters.AddWithValue("@SoDienThoai", SoDienThoai);
                    if (CMND != null) command.Parameters.AddWithValue("@CMND", CMND);
                    if (DiaChiChiTiet != null) command.Parameters.AddWithValue("@DiaChiChiTiet", DiaChiChiTiet);
                    if (XaPhuong != null) command.Parameters.AddWithValue("@XaPhuong", XaPhuong);
                    if (QuanHuyen != null) command.Parameters.AddWithValue("@QuanHuyen", QuanHuyen);
                    if (TinhThanh != null) command.Parameters.AddWithValue("@TinhThanh", TinhThanh);
                    if (TiepNhan_Id != null) command.Parameters.AddWithValue("@TiepNhan_Id", TiepNhan_Id);
                    if (SoTiepNhan != null) command.Parameters.AddWithValue("@SoTiepNhan", SoTiepNhan);
                    if (SoThuTu != null) command.Parameters.AddWithValue("@SoThuTu", SoThuTu);
                    if (UuTien != null) command.Parameters.AddWithValue("@UuTien", UuTien);
                    if (NoiTiepNhan_Id != null) command.Parameters.AddWithValue("@NoiTiepNhan_Id", NoiTiepNhan_Id);
                    if (NguoiTiepNhan_Id != null) command.Parameters.AddWithValue("@NguoiTiepNhan_Id", NguoiTiepNhan_Id);
                    if (NgayTiepNhan.HasValue) command.Parameters.AddWithValue("@NgayTiepNhan", NgayTiepNhan);
                    if (ThoiGianTiepNhan.HasValue) command.Parameters.AddWithValue("@ThoiGianTiepNhan", ThoiGianTiepNhan);
                    if (NamTiepNhan != null) command.Parameters.AddWithValue("@NamTiepNhan", NamTiepNhan);
                    if (ThangTiepNhan != null) command.Parameters.AddWithValue("@ThangTiepNhan", ThangTiepNhan);
                    if (DiaChiLienHe != null) command.Parameters.AddWithValue("@DiaChiLienHe", DiaChiLienHe);
                    if (GhiChu != null) command.Parameters.AddWithValue("@GhiChu", GhiChu);
                    if (BacSiChiDinh != null) command.Parameters.AddWithValue("@BacSiChiDinh", BacSiChiDinh);
                    if (NguoiTao != null) command.Parameters.AddWithValue("@NguoiTao", NguoiTao);
                    if (NgayTao.HasValue) command.Parameters.AddWithValue("@NgayTao", NgayTao);
                    if (NguoiCapNhat != null) command.Parameters.AddWithValue("@NguoiCapNhat", NguoiCapNhat);
                    if (NgayCapNhat.HasValue) command.Parameters.AddWithValue("@NgayCapNhat", NgayCapNhat);
                    if (Huy != null) command.Parameters.AddWithValue("@Huy", Huy);
                    if (SoPhieuYeuCau != null) command.Parameters.AddWithValue("@SoPhieuYeuCau", SoPhieuYeuCau);
                    if (NgayYeuCau.HasValue) command.Parameters.AddWithValue("@NgayYeuCau", NgayYeuCau);
                    if (ThoiGianYeuCau.HasValue) command.Parameters.AddWithValue("@ThoiGianYeuCau", ThoiGianYeuCau);
                    if (DichVu_Id != null) command.Parameters.AddWithValue("@DichVu_Id", DichVu_Id);
                    if (SoLuong != null) command.Parameters.AddWithValue("@SoLuong", SoLuong);
                    if (DonGiaDichVu != null) command.Parameters.AddWithValue("@DonGiaDichVu", DonGiaDichVu);
                    if (ThanhTienDichVu != null) command.Parameters.AddWithValue("@ThanhTienDichVu", ThanhTienDichVu);
                    if (DuocPhepThucHien != null) command.Parameters.AddWithValue("@DuocPhepThucHien", DuocPhepThucHien);
                    if (TrangThai != null) command.Parameters.AddWithValue("@TrangThai", TrangThai);
                    if (NguoiChiDinh != null) command.Parameters.AddWithValue("@NguoiChiDinh", NguoiChiDinh);
                    if (PhienDangNhap_Id != null) command.Parameters.AddWithValue("@PhienDangNhap_Id", PhienDangNhap_Id);
                    if (CLSYeuCau_Id != null) command.Parameters.AddWithValue("@CLSYeuCau_Id", CLSYeuCau_Id);
                    if (ThaoTac != null) command.Parameters.AddWithValue("@ThaoTac", ThaoTac);
                    if (CLSYeuCau_Cha_Id != null) command.Parameters.AddWithValue("@CLSYeuCau_Cha_Id", CLSYeuCau_Cha_Id);
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
