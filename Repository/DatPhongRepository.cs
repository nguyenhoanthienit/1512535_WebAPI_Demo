using _1512535_BaiTapAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repository
{
    public class DatPhongRepository : GenericRepository<DatPhong>
    {
        public List<LichSuThuePhong> Search(string cmnd)
        {
            using (var context = new Model())
            {
                var books = from p in context.DatPhong
                            join k in context.KhachHang
                            on p.MaKH equals k.MaKH
                            where k.CMND == cmnd
                            select new LichSuThuePhong
                            {
                                ngayNhanPhong = p.NgayNhan,
                                ngayTraPhong = p.NgayTra,
                                soNgayThue = 5,
                                soNguoiThue = p.SoNguoiLon + p.SoTreEm,
                                giaTien = p.TongTien * 1,
                                soPhong = p.SoPhong
                            };
                var i = books.Count();
                return books.ToList();
            }
        }

        public void DatPhong(DatPhong dp)
        {
            DatPhong _d = new DatPhong();
            //KhachHang _k = new KhachHang();
            _d.NgayNhan = dp.NgayNhan;
            _d.NgayTra = dp.NgayTra;
            _d.NgayDat = dp.NgayDat;

            _d.MaKH = dp.MaKH;
            _d.SoPhong = dp.SoPhong;
            _d.MaPhong = dp.MaPhong;
            _d.SoNguoiLon = dp.SoNguoiLon;
            _d.SoTreEm = dp.SoTreEm;
            Model m = new Model();
            m.DatPhong.Add(_d);
            m.SaveChanges();
        }
    }

    public class LichSuThuePhong
    {
        public DateTime ngayNhanPhong;
        public DateTime ngayTraPhong;
        public int soNgayThue;
        public int soNguoiThue;
        public int giaTien;
        public int soPhong;
    }
}