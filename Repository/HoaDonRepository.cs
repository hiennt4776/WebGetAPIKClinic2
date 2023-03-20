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
    public class HoaDonRepository
    {
        private readonly string _connectionString;
        private readonly string secretKey = "secretkey";
        public HoaDonRepository()
        {
            _connectionString = EncryptionDecryptionManager.Decrypt(ConfigurationManager.AppSettings["ConnectionString"], secretKey);
        }
        public DataTable HoaDon(string Action, int? Idx, string Text, int? HoaDon_Id, string SoHoaDon, string SoHoaDonVAT, string LoaiHoaDon, int? TiepNhan_Id, int? BenhNhan_Id, DateTime? NgayPhatSinh, DateTime? ThoiGianPhatSinh, int? NguoiLapHoaDon, decimal? GiaTriHoaDon, int? HinhThucThanhToan, int? HuyHoaDon, int? HoanTra, DateTime? NgayTra, DateTime? ThoiGianTra, int? NguoiTao, DateTime? NgayTao, int? NguoiCapNhat, DateTime? NgayCapNhat)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_007_HoaDon", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    if (Action != null) command.Parameters.AddWithValue("@Action", Action);
                    if (Idx != null) command.Parameters.AddWithValue("@Idx", Idx);
                    if (Text != null) command.Parameters.AddWithValue("@Text", Text);
                    if (HoaDon_Id != null) command.Parameters.AddWithValue("@HoaDon_Id", HoaDon_Id);
                    if (SoHoaDon != null) command.Parameters.AddWithValue("@SoHoaDon", SoHoaDon);
                    if (SoHoaDonVAT != null) command.Parameters.AddWithValue("@SoHoaDonVAT", SoHoaDonVAT);
                    if (LoaiHoaDon != null) command.Parameters.AddWithValue("@LoaiHoaDon", LoaiHoaDon);
                    if (TiepNhan_Id != null) command.Parameters.AddWithValue("@TiepNhan_Id", TiepNhan_Id);
                    if (BenhNhan_Id != null) command.Parameters.AddWithValue("@BenhNhan_Id", BenhNhan_Id);
                    if (NgayPhatSinh.HasValue) command.Parameters.AddWithValue("@NgayPhatSinh", NgayPhatSinh);
                    if (ThoiGianPhatSinh.HasValue) command.Parameters.AddWithValue("@ThoiGianPhatSinh", ThoiGianPhatSinh);
                    if (NguoiLapHoaDon != null) command.Parameters.AddWithValue("@NguoiLapHoaDon", NguoiLapHoaDon);
                    if (GiaTriHoaDon != null) command.Parameters.AddWithValue("@GiaTriHoaDon", GiaTriHoaDon);
                    if (HinhThucThanhToan != null) command.Parameters.AddWithValue("@HinhThucThanhToan", HinhThucThanhToan);
                    if (HuyHoaDon != null) command.Parameters.AddWithValue("@HuyHoaDon", HuyHoaDon);
                    if (HoanTra != null) command.Parameters.AddWithValue("@HoanTra", HoanTra);
                    if (NgayTra.HasValue) command.Parameters.AddWithValue("@NgayTra", NgayTra);
                    if (ThoiGianTra.HasValue) command.Parameters.AddWithValue("@ThoiGianTra", ThoiGianTra);
                    if (NguoiTao != null) command.Parameters.AddWithValue("@NguoiTao", NguoiTao);
                    if (NgayTao.HasValue) command.Parameters.AddWithValue("@NgayTao", NgayTao);
                    if (NguoiCapNhat != null) command.Parameters.AddWithValue("@NguoiCapNhat", NguoiCapNhat);
                    if (NgayCapNhat.HasValue) command.Parameters.AddWithValue("@NgayCapNhat", NgayCapNhat);
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
