using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlytiendien
{
    public class HOADON
    {
        String mahd, tenhd, makh, manv, madh, mabg;
        int tt;
        String  ngaytao, ngaycapnhat;

        public string Mahd { get => mahd; set => mahd = value; }
        public string Tenhd { get => tenhd; set => tenhd = value; }
        public string Makh { get => makh; set => makh = value; }
        public string Manv { get => manv; set => manv = value; }
        public string Madh { get => madh; set => madh = value; }
        public string Mabg { get => mabg; set => mabg = value; }
        public int Tt { get => tt; set => tt = value; }
        public string Ngaytao { get => ngaytao; set => ngaytao = value; }
        public string Ngaycapnhat { get => ngaycapnhat; set => ngaycapnhat = value; }

        public HOADON(string mahd, string tenhd, string makh, string manv, string madh, string mabg, int tt, string ngaytao, string ngaycapnhat)
        {
            this.mahd = mahd;
            this.tenhd = tenhd;
            this.makh = makh;
            this.manv = manv;
            this.madh = madh;
            this.mabg = mabg;
            this.tt = tt;
            this.ngaytao = ngaytao;
            this.ngaycapnhat = ngaycapnhat;
        }
        public HOADON()
        {
        }

    }
}
