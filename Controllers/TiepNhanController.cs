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
    public class TiepNhanController : ApiController
    {
        private readonly TiepNhanRepository tiepNhanRepository;
        public TiepNhanController()
        {
            tiepNhanRepository = new TiepNhanRepository();
        }
        [Route("api/TiepNhan")]
        public IHttpActionResult GetTiepNhan(string Action = null, string Loai = null, string text = null, int? IDx = null, int? User_Id = null, int? BenhNhan_Id = null, string MaYTe = null, string SoVaoVien = null, string TenBenhNhan = null, int? GioiTinh = null, DateTime? NgaySinh = null, int? NamSinh = null, string SoDienThoai = null, string CMND = null, string DiaChiChiTiet = null, int? XaPhuong = null, int? QuanHuyen = null, int? TinhThanh = null, int? TiepNhan_Id = null, string SoTiepNhan = null, int? SoThuTu = null, int? UuTien = null, int? NoiTiepNhan_Id = null, int? NguoiTiepNhan_Id = null, DateTime? NgayTiepNhan = null, DateTime? ThoiGianTiepNhan = null, int? NamTiepNhan = null, int? ThangTiepNhan = null, string DiaChiLienHe = null, string GhiChu = null, int? BacSiChiDinh = null, int? NguoiTao = null, DateTime? NgayTao = null, int? NguoiCapNhat = null, DateTime? NgayCapNhat = null, int? Huy = null, string SoPhieuYeuCau = null, DateTime? NgayYeuCau = null, DateTime? ThoiGianYeuCau = null, int? DichVu_Id = null, int? SoLuong = null, decimal? DonGiaDichVu = null, decimal? ThanhTienDichVu = null, int? DuocPhepThucHien = null, string TrangThai = null, int? NguoiChiDinh = null, int? PhienDangNhap_Id = null, int? CLSYeuCau_Id = null, string ThaoTac = null, int? CLSYeuCau_Cha_Id = null)
        {
            DataTable tiepNhanDataTable = tiepNhanRepository.TiepNhan(Action, Loai, text, IDx, User_Id, BenhNhan_Id, MaYTe, SoVaoVien, TenBenhNhan, GioiTinh, NgaySinh, NamSinh, SoDienThoai, CMND, DiaChiChiTiet, XaPhuong, QuanHuyen, TinhThanh, TiepNhan_Id, SoTiepNhan, SoThuTu, UuTien, NoiTiepNhan_Id, NguoiTiepNhan_Id, NgayTiepNhan, ThoiGianTiepNhan, NamTiepNhan, ThangTiepNhan, DiaChiLienHe, GhiChu, BacSiChiDinh, NguoiTao, NgayTao, NguoiCapNhat, NgayCapNhat, Huy, SoPhieuYeuCau, NgayYeuCau, ThoiGianYeuCau, DichVu_Id, SoLuong, DonGiaDichVu, ThanhTienDichVu, DuocPhepThucHien, TrangThai, NguoiChiDinh, PhienDangNhap_Id, CLSYeuCau_Id, ThaoTac, CLSYeuCau_Cha_Id);
            return Ok(tiepNhanDataTable);
        }
    }
}
