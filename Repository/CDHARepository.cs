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
    public class CDHARepository
    {
        private readonly string _connectionString;
        private readonly string secretKey = "secretkey";
        public CDHARepository()
        {
            _connectionString = EncryptionDecryptionManager.Decrypt(ConfigurationManager.AppSettings["ConnectionString"], secretKey);
        }
        public DataTable CDHA(string Action, int? Idx, string Text, int? TiepNhan_Id, string Loai, string SoTiepNhan, string SoPhieuYeuCau, int? CLSKetQua_Id, DateTime? NgayThucHien, DateTime? ThoiGianThucHien, int? BenhNhan_id, int? KTVThucHien_Id, int? BacSiKetLuan_Id, string KetLuan, string KetQua, string MoTa, string Mota_text, string GhiChu, string LoiDan, string ChanDoan, int? LoaiKetQua_Id, DateTime? ThoiGianNhanMau, int? LoaiMau, int? ChatLuongMau, int? NguoiTao, DateTime? NgayTao, int? NguoiCapNhat, DateTime? NgayCapNhat, int? Huy, int? NhomDichVu_Id, int? CLSYeuCau_Id, string Name, string Link)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_005_CDHA", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    if (Action != null) command.Parameters.AddWithValue("@Action", Action);
                    if (Idx != null) command.Parameters.AddWithValue("@Idx", Idx);
                    if (Text != null) command.Parameters.AddWithValue("@Text", Text);
                    if (TiepNhan_Id != null) command.Parameters.AddWithValue("@TiepNhan_Id", TiepNhan_Id);
                    if (Loai != null) command.Parameters.AddWithValue("@Loai", Loai);
                    if (SoTiepNhan != null) command.Parameters.AddWithValue("@SoTiepNhan", SoTiepNhan);
                    if (SoPhieuYeuCau != null) command.Parameters.AddWithValue("@SoPhieuYeuCau", SoPhieuYeuCau);
                    if (CLSKetQua_Id != null) command.Parameters.AddWithValue("@CLSKetQua_Id", CLSKetQua_Id);
                    if (NgayThucHien.HasValue) command.Parameters.AddWithValue("@NgayThucHien", NgayThucHien);
                    if (ThoiGianThucHien.HasValue) command.Parameters.AddWithValue("@ThoiGianThucHien", ThoiGianThucHien);
                    if (BenhNhan_id != null) command.Parameters.AddWithValue("@BenhNhan_id", BenhNhan_id);
                    if (KTVThucHien_Id != null) command.Parameters.AddWithValue("@KTVThucHien_Id", KTVThucHien_Id);
                    if (BacSiKetLuan_Id != null) command.Parameters.AddWithValue("@BacSiKetLuan_Id", BacSiKetLuan_Id);
                    if (KetLuan != null) command.Parameters.AddWithValue("@KetLuan", KetLuan);
                    if (KetQua != null) command.Parameters.AddWithValue("@KetQua", KetQua);
                    if (MoTa != null) command.Parameters.AddWithValue("@MoTa", MoTa);
                    if (Mota_text != null) command.Parameters.AddWithValue("@Mota_text", Mota_text);
                    if (GhiChu != null) command.Parameters.AddWithValue("@GhiChu", GhiChu);
                    if (LoiDan != null) command.Parameters.AddWithValue("@LoiDan", LoiDan);
                    if (ChanDoan != null) command.Parameters.AddWithValue("@ChanDoan", ChanDoan);
                    if (LoaiKetQua_Id != null) command.Parameters.AddWithValue("@LoaiKetQua_Id", LoaiKetQua_Id);
                    if (ThoiGianNhanMau.HasValue) command.Parameters.AddWithValue("@ThoiGianNhanMau", ThoiGianNhanMau);
                    if (LoaiMau != null) command.Parameters.AddWithValue("@LoaiMau", LoaiMau);
                    if (ChatLuongMau != null) command.Parameters.AddWithValue("@ChatLuongMau", ChatLuongMau);
                    if (NguoiTao != null) command.Parameters.AddWithValue("@NguoiTao", NguoiTao);
                    if (NgayTao.HasValue) command.Parameters.AddWithValue("@NgayTao", NgayTao);
                    if (NguoiCapNhat != null) command.Parameters.AddWithValue("@NguoiCapNhat", NguoiCapNhat);
                    if (NgayCapNhat.HasValue) command.Parameters.AddWithValue("@NgayCapNhat", NgayCapNhat);
                    if (Huy != null) command.Parameters.AddWithValue("@Huy", Huy);
                    if (NhomDichVu_Id != null) command.Parameters.AddWithValue("@NhomDichVu_Id", NhomDichVu_Id);
                    if (CLSYeuCau_Id != null) command.Parameters.AddWithValue("@CLSYeuCau_Id", CLSYeuCau_Id);
                    if (Name != null) command.Parameters.AddWithValue("@Name", Name);
                    if (Link != null) command.Parameters.AddWithValue("@Link", Link);
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
