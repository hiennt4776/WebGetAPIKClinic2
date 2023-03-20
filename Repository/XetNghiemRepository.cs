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
    public class XetNghiemRepository
    {
        private readonly string _connectionString;
        private readonly string secretKey = "secretkey";
        public XetNghiemRepository()
        {
            _connectionString = EncryptionDecryptionManager.Decrypt(ConfigurationManager.AppSettings["ConnectionString"], secretKey);
        }
        public DataTable XetNghiem(string Action, int? Idx, string Text, int? TiepNhan_Id, string Loai, string SoTiepNhan, DateTime? NgayThucHien, DateTime? ThoiGianThucHien, int? KTVThucHien_Id, int? BacSiKetLuan_Id, string KetLuan, string KetQua, string GhiChu, int? NguoiTao, DateTime? NgayTao, int? NguoiCapNhat, DateTime? NgayCapNhat, int? Huy, int? NhomDichVu_Id, int? CLSYeuCau_Id, int? CLSKetQua_Id, int? BenhNhan_id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_004_XetNghiem", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    if (Action != null) command.Parameters.AddWithValue("@Action", Action);
                    if (Idx != null) command.Parameters.AddWithValue("@Idx ", Idx);
                    if (Text != null) command.Parameters.AddWithValue("@Text", Text);
                    if (TiepNhan_Id != null) command.Parameters.AddWithValue("@TiepNhan_Id ", TiepNhan_Id);
                    if (Loai != null) command.Parameters.AddWithValue("@Loai", Loai);
                    if (SoTiepNhan != null) command.Parameters.AddWithValue("@SoTiepNhan ", SoTiepNhan);
                    if (NgayThucHien.HasValue) command.Parameters.AddWithValue("@NgayThucHien", NgayThucHien);
                    if (ThoiGianThucHien.HasValue) command.Parameters.AddWithValue("@ThoiGianThucHien", ThoiGianThucHien);
                    if (KTVThucHien_Id != null) command.Parameters.AddWithValue("@KTVThucHien_Id", KTVThucHien_Id);
                    if (BacSiKetLuan_Id != null) command.Parameters.AddWithValue("@BacSiKetLuan_Id", BacSiKetLuan_Id);
                    if (KetLuan != null) command.Parameters.AddWithValue("@KetLuan", KetLuan);
                    if (KetQua != null) command.Parameters.AddWithValue("@KetQua", KetQua);
                    if (GhiChu != null) command.Parameters.AddWithValue("@GhiChu", GhiChu);
                    if (NguoiTao != null) command.Parameters.AddWithValue("@NguoiTao", NguoiTao);
                    if (NgayTao.HasValue) command.Parameters.AddWithValue("@NgayTao", NgayTao);
                    if (NguoiCapNhat != null) command.Parameters.AddWithValue("@NguoiCapNhat", NguoiCapNhat);
                    if (NgayCapNhat.HasValue) command.Parameters.AddWithValue("@NgayCapNhat", NgayCapNhat);
                    if (Huy != null) command.Parameters.AddWithValue("@Huy", Huy);
                    if (NhomDichVu_Id != null) command.Parameters.AddWithValue("@NhomDichVu_Id", NhomDichVu_Id);
                    if (CLSYeuCau_Id != null) command.Parameters.AddWithValue("@CLSYeuCau_Id", CLSYeuCau_Id);
                    if (CLSKetQua_Id != null) command.Parameters.AddWithValue("@CLSKetQua_Id", CLSKetQua_Id);
                    if (BenhNhan_id != null) command.Parameters.AddWithValue("@BenhNhan_id", BenhNhan_id);
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
