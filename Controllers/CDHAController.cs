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
    public class CDHAController : ApiController
    {
        private readonly CDHARepository cDHARepository;
        public CDHAController()
        {
            cDHARepository = new CDHARepository();
        }
        [Route("api/CDHA")]
        public IHttpActionResult GetCDHA(string Action = null, int? Idx = null, string Text = null, int? TiepNhan_Id = null, string Loai = null, string SoTiepNhan = null, string SoPhieuYeuCau = null, int? CLSKetQua_Id = null, DateTime? NgayThucHien = null, DateTime? ThoiGianThucHien = null, int? BenhNhan_id = null, int? KTVThucHien_Id = null, int? BacSiKetLuan_Id = null, string KetLuan = null, string KetQua = null, string MoTa = null, string Mota_text = null, string GhiChu = null, string LoiDan = null, string ChanDoan = null, int? LoaiKetQua_Id = null, DateTime? ThoiGianNhanMau = null, int? LoaiMau = null, int? ChatLuongMau = null, int? NguoiTao = null, DateTime? NgayTao = null, int? NguoiCapNhat = null, DateTime? NgayCapNhat = null, int? Huy = null, int? NhomDichVu_Id = null, int? CLSYeuCau_Id = null, string Name = null, string Link = null)
        {
            DataTable cDHADataTable = cDHARepository.CDHA(Action, Idx, Text, TiepNhan_Id, Loai, SoTiepNhan, SoPhieuYeuCau, CLSKetQua_Id, NgayThucHien, ThoiGianThucHien, BenhNhan_id, KTVThucHien_Id, BacSiKetLuan_Id, KetLuan, KetQua, MoTa, Mota_text, GhiChu, LoiDan, ChanDoan, LoaiKetQua_Id, ThoiGianNhanMau, LoaiMau, ChatLuongMau, NguoiTao, NgayTao, NguoiCapNhat, NgayCapNhat, Huy, NhomDichVu_Id, CLSYeuCau_Id, Name, Link);
            return Ok(cDHADataTable);
        }
    }
}

