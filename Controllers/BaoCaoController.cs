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
    public class BaoCaoController : ApiController
    {

        private readonly BaoCaoRepository baoCaoRepository;
        public BaoCaoController()
        {
            baoCaoRepository = new BaoCaoRepository();
        }


        [Route("api/ToaThuoc")]
        public IHttpActionResult GetToaThuoc(int? KhamBenh_Id = null)
        {
            DataTable toaThuocDataTable = baoCaoRepository.ToaThuoc(KhamBenh_Id);
            return Ok(toaThuocDataTable);
        }

        [Route("api/Phieukham")]
        public IHttpActionResult GetPhieukham(int? KhamBenh_Id = null)
        {
            DataTable phieukhamDataTable = baoCaoRepository.Phieukham(KhamBenh_Id);
            return Ok(phieukhamDataTable);
        }
        [Route("api/PhieuChiDinhDichVuTruKham")]
        public IHttpActionResult GetPhieuChiDinhDichVuTruKham(int? KhamBenh_Id = null)
        {
            DataTable phieuChiDinhDichVuTruKhamDataTable = baoCaoRepository.PhieuChiDinhDichVuTruKham(KhamBenh_Id);
            return Ok(phieuChiDinhDichVuTruKhamDataTable);
        }
        [Route("api/PhieuKetQuaXetNghiem")]
        public IHttpActionResult GetPhieuKetQuaXetNghiem(int? CLSKetQua_Id = null)
        {
            DataTable phieuKetQuaXetNghiemDataTable = baoCaoRepository.PhieuKetQuaXetNghiem(CLSKetQua_Id);
            return Ok(phieuKetQuaXetNghiemDataTable);
        }

        [Route("api/PhieuKetQuaCDHA")]
        public IHttpActionResult GetPhieuKetQuaCDHA(string CLSKetQua_Id = null)
        {
            DataTable phieuKetQuaCDHADataTable = baoCaoRepository.PhieuKetQuaCDHA(CLSKetQua_Id);
            return Ok(phieuKetQuaCDHADataTable);
        }

        [Route("api/BaoCaoThongKeThuTien")]
        public IHttpActionResult GetBaoCaoThongKeThuTien(DateTime? TuNgay = null, DateTime? DenNgay = null)
        {
            DataTable baoCaoThongKeThuTienDataTable = baoCaoRepository.BaoCaoThongKeThuTien(TuNgay, DenNgay);
            return Ok(baoCaoThongKeThuTienDataTable);
        }

        [Route("api/BaoCaoThongKeSoLuongChiDinh")]
        public IHttpActionResult GetBaoCaoThongKeSoLuongChiDinh(DateTime? TuNgay = null, DateTime? DenNgay = null, int? NhomDichVu_Id = null, int? BacSi_Id = null)
        {
            DataTable baoCaoThongKeSoLuongChiDinhDataTable = baoCaoRepository.BaoCaoThongKeSoLuongChiDinh(TuNgay, DenNgay, NhomDichVu_Id, BacSi_Id);
            return Ok(baoCaoThongKeSoLuongChiDinhDataTable);
        }

        [Route("api/BaoCaoBNChiDinhDichVu")]
        public IHttpActionResult GetBaoCaoBNChiDinhDichVu(DateTime? TuNgay = null, DateTime? DenNgay = null, int? NhomDichVu_Id = null, int? BacSi_Id = null)
        {
            DataTable baoCaoBNChiDinhDichVuDataTable = baoCaoRepository.BaoCaoBNChiDinhDichVu(TuNgay, DenNgay, NhomDichVu_Id, BacSi_Id);
            return Ok(baoCaoBNChiDinhDichVuDataTable);
        }

    }
}
