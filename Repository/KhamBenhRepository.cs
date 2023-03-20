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
    public class KhamBenhRepository
    {
        private readonly string _connectionString;
        private readonly string secretKey = "secretkey";
        public KhamBenhRepository()
        {
            _connectionString = EncryptionDecryptionManager.Decrypt(ConfigurationManager.AppSettings["ConnectionString"], secretKey);
        }
        public DataTable KhamBenh(string Action, string Text, int? IDx, int? KhamBenh_Id, int? TiepNhan_Id, int? BenhNhan_Id, DateTime? NgayKham, DateTime? ThoiGianKham, int? PhongKham_Id, int? BacSiKham, decimal? Mach, decimal? NhietDo, decimal? CanNang, decimal? ChieuCao, decimal? HuyetApCao, decimal? HuyetApThap, decimal? NhipTho, decimal? BMI, string TrieuChung, int? ICD_Id, string ChanDoan, string KetLuan, string LoiDan, int? CLSYeuCau_Id, DateTime? NgayTao, int? NguoiTao, DateTime? NgayCapNhat, int? NguoiCapNhat, int? Huy, int? User_Id, int? PhongBan_Id, int? PhienDangNhap_Id, int? Duoc_Id, int? ToaThuoc_Id, string SoThuTuToa, decimal? Sang, decimal? Trua, decimal? Chieu, decimal? Toi, decimal? SoNgay, decimal? SoLuong, decimal? DonGia, decimal? ThanhTien, int? DaCho, decimal? SoLuongDaCho, int? DaThanhToan, string ThaoTac)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_KhamBenh", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    if (Action != null) command.Parameters.AddWithValue("@Action", Action);
                    if (Text != null) command.Parameters.AddWithValue("@Text", Text);
                    if (IDx != null) command.Parameters.AddWithValue("@IDx", IDx);
                    if (KhamBenh_Id != null) command.Parameters.AddWithValue("@KhamBenh_Id", KhamBenh_Id);
                    if (TiepNhan_Id != null) command.Parameters.AddWithValue("@TiepNhan_Id", TiepNhan_Id);
                    if (BenhNhan_Id != null) command.Parameters.AddWithValue("@BenhNhan_Id", BenhNhan_Id);
                    if (NgayKham.HasValue) command.Parameters.AddWithValue("@NgayKham", NgayKham);
                    if (ThoiGianKham.HasValue) command.Parameters.AddWithValue("@ThoiGianKham", ThoiGianKham);
                    if (PhongKham_Id != null) command.Parameters.AddWithValue("@PhongKham_Id", PhongKham_Id);
                    if (BacSiKham != null) command.Parameters.AddWithValue("@BacSiKham", BacSiKham);
                    if (Mach != null) command.Parameters.AddWithValue("@Mach", Mach);
                    if (NhietDo != null) command.Parameters.AddWithValue("@NhietDo", NhietDo);
                    if (CanNang != null) command.Parameters.AddWithValue("@CanNang", CanNang);
                    if (ChieuCao != null) command.Parameters.AddWithValue("@ChieuCao", ChieuCao);
                    if (HuyetApCao != null) command.Parameters.AddWithValue("@HuyetApCao", HuyetApCao);
                    if (HuyetApThap != null) command.Parameters.AddWithValue("@HuyetApThap", HuyetApThap);
                    if (NhipTho != null) command.Parameters.AddWithValue("@NhipTho", NhipTho);
                    if (BMI != null) command.Parameters.AddWithValue("@BMI", BMI);
                    if (TrieuChung != null) command.Parameters.AddWithValue("@TrieuChung", TrieuChung);
                    if (ICD_Id != null) command.Parameters.AddWithValue("@ICD_Id", ICD_Id);
                    if (ChanDoan != null) command.Parameters.AddWithValue("@ChanDoan", ChanDoan);
                    if (KetLuan != null) command.Parameters.AddWithValue("@KetLuan", KetLuan);
                    if (LoiDan != null) command.Parameters.AddWithValue("@LoiDan", LoiDan);
                    if (CLSYeuCau_Id != null) command.Parameters.AddWithValue("@CLSYeuCau_Id", CLSYeuCau_Id);
                    if (NgayTao.HasValue) command.Parameters.AddWithValue("@NgayTao", NgayTao);
                    if (NguoiTao != null) command.Parameters.AddWithValue("@NguoiTao", NguoiTao);
                    if (NgayCapNhat.HasValue) command.Parameters.AddWithValue("@NgayCapNhat", NgayCapNhat);
                    if (NguoiCapNhat != null) command.Parameters.AddWithValue("@NguoiCapNhat", NguoiCapNhat);
                    if (Huy != null) command.Parameters.AddWithValue("@Huy", Huy);
                    if (User_Id != null) command.Parameters.AddWithValue("@User_Id", User_Id);
                    if (PhongBan_Id != null) command.Parameters.AddWithValue("@PhongBan_Id", PhongBan_Id);
                    if (PhienDangNhap_Id != null) command.Parameters.AddWithValue("@PhienDangNhap_Id", PhienDangNhap_Id);
                    if (Duoc_Id != null) command.Parameters.AddWithValue("@Duoc_Id", Duoc_Id);
                    if (ToaThuoc_Id != null) command.Parameters.AddWithValue("@ToaThuoc_Id", ToaThuoc_Id);
                    if (SoThuTuToa != null) command.Parameters.AddWithValue("@SoThuTuToa", SoThuTuToa);
                    if (Sang != null) command.Parameters.AddWithValue("@Sang", Sang);
                    if (Trua != null) command.Parameters.AddWithValue("@Trua", Trua);
                    if (Chieu != null) command.Parameters.AddWithValue("@Chieu", Chieu);
                    if (Toi != null) command.Parameters.AddWithValue("@Toi", Toi);
                    if (SoNgay != null) command.Parameters.AddWithValue("@SoNgay", SoNgay);
                    if (SoLuong != null) command.Parameters.AddWithValue("@SoLuong", SoLuong);
                    if (DonGia != null) command.Parameters.AddWithValue("@DonGia", DonGia);
                    if (ThanhTien != null) command.Parameters.AddWithValue("@ThanhTien", ThanhTien);
                    if (DaCho != null) command.Parameters.AddWithValue("@DaCho", DaCho);
                    if (SoLuongDaCho != null) command.Parameters.AddWithValue("@SoLuongDaCho", SoLuongDaCho);
                    if (DaThanhToan != null) command.Parameters.AddWithValue("@DaThanhToan", DaThanhToan);
                    if (ThaoTac != null) command.Parameters.AddWithValue("@ThaoTac", ThaoTac);
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
