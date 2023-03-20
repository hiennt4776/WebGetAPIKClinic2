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
    public class KhamBenhController : ApiController
    {
        private readonly KhamBenhRepository khamBenhRepository;
        public KhamBenhController()
        {
            khamBenhRepository = new KhamBenhRepository();
        }
        [Route("api/KhamBenh")]
        public IHttpActionResult GetKhamBenh(string Action = null, string Text = null, int? IDx = null, int? KhamBenh_Id = null, int? TiepNhan_Id = null, int? BenhNhan_Id = null, DateTime? NgayKham = null, DateTime? ThoiGianKham = null, int? PhongKham_Id = null, int? BacSiKham = null, decimal? Mach = null, decimal? NhietDo = null, decimal? CanNang = null, decimal? ChieuCao = null, decimal? HuyetApCao = null, decimal? HuyetApThap = null, decimal? NhipTho = null, decimal? BMI = null, string TrieuChung = null, int? ICD_Id = null, string ChanDoan = null, string KetLuan = null, string LoiDan = null, int? CLSYeuCau_Id = null, DateTime? NgayTao = null, int? NguoiTao = null, DateTime? NgayCapNhat = null, int? NguoiCapNhat = null, int? Huy = null, int? User_Id = null, int? PhongBan_Id = null, int? PhienDangNhap_Id = null, int? Duoc_Id = null, int? ToaThuoc_Id = null, string SoThuTuToa = null, decimal? Sang = null, decimal? Trua = null, decimal? Chieu = null, decimal? Toi = null, decimal? SoNgay = null, decimal? SoLuong = null, decimal? DonGia = null, decimal? ThanhTien = null, int? DaCho = null, decimal? SoLuongDaCho = null, int? DaThanhToan = null, string ThaoTac = null)
        {
            DataTable khamBenhDataTable = khamBenhRepository.KhamBenh(Action, Text, IDx, KhamBenh_Id, TiepNhan_Id, BenhNhan_Id, NgayKham, ThoiGianKham, PhongKham_Id, BacSiKham, Mach, NhietDo, CanNang, ChieuCao, HuyetApCao, HuyetApThap, NhipTho, BMI, TrieuChung, ICD_Id, ChanDoan, KetLuan, LoiDan, CLSYeuCau_Id, NgayTao, NguoiTao, NgayCapNhat, NguoiCapNhat, Huy, User_Id, PhongBan_Id, PhienDangNhap_Id, Duoc_Id, ToaThuoc_Id, SoThuTuToa, Sang, Trua, Chieu, Toi, SoNgay, SoLuong, DonGia, ThanhTien, DaCho, SoLuongDaCho, DaThanhToan, ThaoTac);
            return Ok(khamBenhDataTable);
        }
    }
}
