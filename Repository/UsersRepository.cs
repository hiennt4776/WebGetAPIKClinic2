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

    public class UsersRepository
    {
        private readonly string _connectionString;
        private readonly string secretKey = "secretkey";
        public UsersRepository()
        {
            //_connectionString = ConfigurationManager.ConnectionStrings["KClinic2dbConnection"].ConnectionString;
            //EncryptionDecryptionManager.Decrypt(txtSourceDecrypt.Text, txtKeyDecript.Text)
            // _connectionString = ConfigurationManager.AppSettings["ConnectionString"];
            _connectionString = EncryptionDecryptionManager.Decrypt(ConfigurationManager.AppSettings["ConnectionString"], secretKey);
        }


        public DataTable Users(string Action, string UserCode, string Password, int? Idx, string Text, int? User_Id, DateTime? ThoiGianDangNhap, DateTime? ThoiGianKetThuc,
                                            string Ip, string Mac, string UserName, int? BenhVien_Id, int? TamNgung, int? NguoiTao, DateTime? NgayTao, int? NguoiCapNhat,
                                            DateTime? NgayCapNhat, int? Huy, int? Menu_Id, string MenuCode, string MenuName, int? ParentMenu, int? Setting_Id, string SettingCode,
                                            string SettingName, string NoiDung, string Mota, DateTime? Date1, DateTime? Date2, int? Num1, int? Num2, string String1, string String2,
                                            string TieuDe, string NoiDung_text, DateTime? datetime, int? NguoiGui)
        {

            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_001_Users", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    if (Action != null) command.Parameters.AddWithValue("@Action", Action);
                    if (UserCode != null) command.Parameters.AddWithValue("@UserCode", UserCode);
                    if (Password != null) command.Parameters.AddWithValue("@Password", Password);
                    if (Idx != null) command.Parameters.AddWithValue("@Idx", Idx);
                    if (Text != null) command.Parameters.AddWithValue("@Text", Text);

                    if (User_Id != null) command.Parameters.AddWithValue("@User_Id", User_Id);
                    if (ThoiGianDangNhap.HasValue) command.Parameters.AddWithValue("@ThoiGianDangNhap", ThoiGianDangNhap);
                    if (ThoiGianKetThuc.HasValue) command.Parameters.AddWithValue("@ThoiGianKetThuc", ThoiGianKetThuc);
                    if (Ip != null) command.Parameters.AddWithValue("@Ip", Ip);
                    if (Mac != null) command.Parameters.AddWithValue("@Mac", Mac);


                    if (UserName != null) command.Parameters.AddWithValue("@UserName",UserName);
                    if (BenhVien_Id != null) command.Parameters.AddWithValue("@BenhVien_Id", BenhVien_Id);
                    if (TamNgung != null) command.Parameters.AddWithValue("@TamNgung", TamNgung);
                    if (NguoiTao != null) command.Parameters.AddWithValue("@NguoiTao", NguoiTao);
                    if (NgayTao.HasValue) command.Parameters.AddWithValue("@NgayTao", NgayTao);
                    if (NguoiCapNhat != null) command.Parameters.AddWithValue("@NguoiCapNhat", NguoiCapNhat);
                    if (NgayCapNhat.HasValue) command.Parameters.AddWithValue("@NgayCapNhat", NgayCapNhat);
                    if (Huy != null) command.Parameters.AddWithValue("@Huy", Huy);

                    if (Menu_Id != null) command.Parameters.AddWithValue("@Menu_Id", Menu_Id);
                    if (MenuCode != null) command.Parameters.AddWithValue("@MenuCode", MenuCode);
                    if (MenuName != null) command.Parameters.AddWithValue("@MenuName", MenuName);
                    if (ParentMenu != null) command.Parameters.AddWithValue("@ParentMenu", ParentMenu);

                    if (Setting_Id != null) command.Parameters.AddWithValue("@Setting_Id", Setting_Id);
                    if (SettingCode != null) command.Parameters.AddWithValue("@SettingCode", SettingCode);
                    if (SettingName != null) command.Parameters.AddWithValue("@SettingName", SettingName);
                    if (NoiDung != null) command.Parameters.AddWithValue("@NoiDung", NoiDung);
                    if (Mota != null) command.Parameters.AddWithValue("@Mota", Mota);
                    if (Date1.HasValue) command.Parameters.AddWithValue("@Date1", Date1);
                    if (Date2.HasValue) command.Parameters.AddWithValue("@Date2", Date2);
                    if (Num1 != null) command.Parameters.AddWithValue("@Num1", Num1);
                    if (Num2 != null) command.Parameters.AddWithValue("@Num2", Num2);
                    if (String1 != null) command.Parameters.AddWithValue("@String1", String1);
                    if (String2 != null) command.Parameters.AddWithValue("@String2", String2);

                    if (TieuDe != null) command.Parameters.AddWithValue("@TieuDe", TieuDe);
                    if (NoiDung_text != null) command.Parameters.AddWithValue("@NoiDung_text", NoiDung_text);
                    if (datetime.HasValue) command.Parameters.AddWithValue("@datetime", datetime);
                    if (NguoiGui != null) command.Parameters.AddWithValue("@NguoiGui", NguoiGui);

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