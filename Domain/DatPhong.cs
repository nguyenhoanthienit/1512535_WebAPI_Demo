using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _1512535_BaiTapAPI
{
    public class DatPhong
    {
        [Key]
        public int MaDatPhong
        {
            get;
            set;
        }

        public int MaKH
        {
            get;
            set;
        }

        public int MaPhong
        {
            get;
            set;
        }

        public DateTime NgayDat
        {
            get;
            set;
        }

        public DateTime NgayNhan
        {
            get;
            set;
        }

        public DateTime NgayTra
        {
            get;
            set;
        }

        public int SoNguoiLon
        {
            get;
            set;
        }

        public int SoTreEm
        {
            get;
            set;
        }

        public int SoPhong
        {
            get;
            set;
        }

        public int TongTien
        {
            get;
            set;
        }
    }
}
