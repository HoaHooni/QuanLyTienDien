using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlytiendien
{
    class BANGGIADIEN
    {
        String mabg;
        int tt;
        String loaibt;
        int chisotr, chisosau;
        String loaikh, ngaytao, ngaycapnhat;

        public BANGGIADIEN(string mabg, int tt, string loaibt, int chisotr, int chisosau, string loaikh, string ngaytao, string ngaycapnhat)
        {
            this.mabg = mabg;
            this.tt = tt;
            this.loaibt = loaibt;
            this.chisotr = chisotr;
            this.chisosau = chisosau;
            this.loaikh = loaikh;
            this.ngaytao = ngaytao;
            this.ngaycapnhat = ngaycapnhat;
        }   
        public BANGGIADIEN()
        { 
        }

        public string Mabg { get => mabg; set => mabg = value; }
        public int Tt { get => tt; set => tt = value; }
        public string Loaibt { get => loaibt; set => loaibt = value; }
        public int Chisotr { get => chisotr; set => chisotr = value; }
        public int Chisosau { get => chisosau; set => chisosau = value; }
        public string Loaikh { get => loaikh; set => loaikh = value; }
        public string Ngaytao { get => ngaytao; set => ngaytao = value; }
        public string Ngaycapnhat { get => ngaycapnhat; set => ngaycapnhat = value; }
    }
}
