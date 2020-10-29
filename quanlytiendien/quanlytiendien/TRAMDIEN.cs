using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlytiendien
{
    public class TRAMDIEN
    {
      
        String matram;
        int tt;
        String vitri;
        int slcd;
        String mota, ngaytao, ngaycapnhat;

        public string Matram { get => matram; set => matram = value; }
        public int Tt { get => tt; set => tt = value; }
        public string Vitri { get => vitri; set => vitri = value; }
        public int Slcd { get => slcd; set => slcd = value; }
        public string Mota { get => mota; set => mota = value; }
        public string Ngaytao { get => ngaytao; set => ngaytao = value; }
        public string Ngaycapnhat { get => ngaycapnhat; set => ngaycapnhat = value; }

        public TRAMDIEN(string matram, int tt, string vitri, int slcd, string mota, string ngaytao, string ngaycapnhat)
        {
            this.matram = matram;
            this.tt = tt;
            this.vitri = vitri;
            this.slcd = slcd;
            this.mota = mota;
            this.ngaytao = ngaytao;
            this.ngaycapnhat = ngaycapnhat;
        } 
        public TRAMDIEN()
        {
         
        }

    }
}
