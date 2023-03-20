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
    public class HoaDonController : ApiController
    {
        private readonly HoaDonRepository hoaDonRepository;
        public HoaDonController()
        {
            hoaDonRepository = new HoaDonRepository();
        }
        [Route("api/HoaDon")]
        public IHttpActionResult GetHoaDon(string Action = null, int? Idx = null, string Text = null, int? HoaDon_Id = null, string SoHoaDon = null, string SoHoaDonVAT = null, string LoaiHoaDon = null, int? TiepNhan_Id = null, int? BenhNhan_Id = null, DateTime? NgayPhatSinh = null, DateTime? ThoiGianPhatSinh = null, int? NguoiLapHoaDon = null, decimal? GiaTriHoaDon = null, int? HinhThucThanhToan = null, int? HuyHoaDon = null, int? HoanTra = null, DateTime? NgayTra = null, DateTime? ThoiGianTra = null, int? NguoiTao = null, DateTime? NgayTao = null, int? NguoiCapNhat = null, DateTime? NgayCapNhat = null)
        {
            DataTable hoaDonDataTable = hoaDonRepository.HoaDon(Action, Idx, Text, HoaDon_Id, SoHoaDon, SoHoaDonVAT, LoaiHoaDon, TiepNhan_Id, BenhNhan_Id, NgayPhatSinh, ThoiGianPhatSinh, NguoiLapHoaDon, GiaTriHoaDon, HinhThucThanhToan, HuyHoaDon, HoanTra, NgayTra, ThoiGianTra, NguoiTao, NgayTao, NguoiCapNhat, NgayCapNhat);
            return Ok(hoaDonDataTable);
        }
    }
}
