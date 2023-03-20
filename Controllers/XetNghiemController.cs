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
    public class XetNghiemController : ApiController
    {
        private readonly XetNghiemRepository xetNghiemRepository;
        public XetNghiemController()
        {
            xetNghiemRepository = new XetNghiemRepository();
        }
        [Route("api/XetNghiem")]
        public IHttpActionResult GetXetNghiem(string Action = null, int? Idx = null, string Text = null, int? TiepNhan_Id = null, string Loai = null, string SoTiepNhan = null, DateTime? NgayThucHien = null, DateTime? ThoiGianThucHien = null, int? KTVThucHien_Id = null, int? BacSiKetLuan_Id = null, string KetLuan = null, string KetQua = null, string GhiChu = null, int? NguoiTao = null, DateTime? NgayTao = null, int? NguoiCapNhat = null, DateTime? NgayCapNhat = null, int? Huy = null, int? NhomDichVu_Id = null, int? CLSYeuCau_Id = null, int? CLSKetQua_Id = null, int? BenhNhan_id = null)
        {
            DataTable xetNghiemDataTable = xetNghiemRepository.XetNghiem(Action, Idx, Text, TiepNhan_Id, Loai, SoTiepNhan, NgayThucHien, ThoiGianThucHien, KTVThucHien_Id, BacSiKetLuan_Id, KetLuan, KetQua, GhiChu, NguoiTao, NgayTao, NguoiCapNhat, NgayCapNhat, Huy, NhomDichVu_Id, CLSYeuCau_Id, CLSKetQua_Id, BenhNhan_id);
            return Ok(xetNghiemDataTable);
        }
    }
}
