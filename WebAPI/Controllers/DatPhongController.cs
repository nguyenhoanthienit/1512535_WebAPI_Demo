using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _1512535_BaiTapAPI.Controllers
{
    public class DatPhongController : ApiController
    {
        private DatPhongRepository _datPhongRepo = new DatPhongRepository();


        public HttpResponseMessage GetInfo(string cmnd)
        {

            if (cmnd == null)
            {
                return null;
            }

            var _res = _datPhongRepo.Search(cmnd);

            if (_res.Count == 0)
            {
                return null;
            }
            return Request.CreateResponse(HttpStatusCode.OK, _res);
        }

        public HttpResponseMessage Post()
        {
            DatPhong d = new DatPhong();
            if (d == null)
            {
                return null;
            }

            d.MaKH = 5;
            d.MaPhong = 1;
            d.NgayDat = DateTime.Now;
            d.NgayNhan = DateTime.Parse("12/12/1997");
            d.NgayTra = DateTime.Parse("5/5/1998");
            d.SoNguoiLon = 1;
            d.SoTreEm = 1;
            d.SoPhong = 5;
            d.TongTien = 20000;

            _datPhongRepo.DatPhong(d);

            return Request.CreateResponse(HttpStatusCode.OK, "Success");
        }
	}
}
