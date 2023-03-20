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
    public class BaoCaoRepository
    {
        private readonly string _connectionString;
        private readonly string secretKey = "secretkey";
        public BaoCaoRepository()
        {
            _connectionString = EncryptionDecryptionManager.Decrypt(ConfigurationManager.AppSettings["ConnectionString"], secretKey);
        }
        public DataTable ToaThuoc(int? KhamBenh_Id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_BaoCao_001_ToaThuoc", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    if (KhamBenh_Id != null) command.Parameters.AddWithValue("@KhamBenh_Id", KhamBenh_Id);
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
        public DataTable Phieukham(int? KhamBenh_Id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_BaoCao_002_Phieukham", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    if (KhamBenh_Id != null) command.Parameters.AddWithValue("@KhamBenh_Id", KhamBenh_Id);
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

        public DataTable PhieuChiDinhDichVuTruKham(int? KhamBenh_Id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_BaoCao_003_PhieuChiDinhDichVuTruKham", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    if (KhamBenh_Id != null) command.Parameters.AddWithValue("@KhamBenh_Id", KhamBenh_Id);
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
        public DataTable PhieuKetQuaXetNghiem(int? CLSKetQua_Id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_BaoCao_004_PhieuKetQuaXetNghiem", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    if (CLSKetQua_Id != null) command.Parameters.AddWithValue("@CLSKetQua_Id", CLSKetQua_Id);
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
        public DataTable PhieuKetQuaCDHA(string CLSKetQua_Id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_BaoCao_005_PhieuKetQuaCDHA", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    if (CLSKetQua_Id != null) command.Parameters.AddWithValue("@CLSKetQua_Id", CLSKetQua_Id);
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

        public DataTable BaoCaoThongKeThuTien(DateTime? TuNgay, DateTime? DenNgay)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_BaoCao_006_BaoCaoThongKeThuTien", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    if (TuNgay.HasValue) command.Parameters.AddWithValue("@TuNgay", TuNgay);
                    if (DenNgay.HasValue) command.Parameters.AddWithValue("@DenNgay", DenNgay);
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

        public DataTable BaoCaoThongKeSoLuongChiDinh(DateTime? TuNgay, DateTime? DenNgay, int? NhomDichVu_Id, int? BacSi_Id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_BaoCao_007_BaoCaoThongKeSoLuongChiDinh", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    if (TuNgay.HasValue) command.Parameters.AddWithValue("@TuNgay", TuNgay);
                    if (DenNgay.HasValue) command.Parameters.AddWithValue("@DenNgay", DenNgay);
                    if (NhomDichVu_Id != null) command.Parameters.AddWithValue("@NhomDichVu_Id", NhomDichVu_Id);
                    if (BacSi_Id != null) command.Parameters.AddWithValue("@BacSi_Id", BacSi_Id);
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
        public DataTable BaoCaoBNChiDinhDichVu(DateTime? TuNgay, DateTime? DenNgay, int? NhomDichVu_Id, int? BacSi_Id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_BaoCao_008_BaoCaoBNChiDinhDichVu", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    if (TuNgay.HasValue) command.Parameters.AddWithValue("@TuNgay", TuNgay);
                    if (DenNgay.HasValue) command.Parameters.AddWithValue("@DenNgay", DenNgay);
                    if (NhomDichVu_Id != null) command.Parameters.AddWithValue("@NhomDichVu_Id", NhomDichVu_Id);
                    if (BacSi_Id != null) command.Parameters.AddWithValue("@BacSi_Id", BacSi_Id);
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