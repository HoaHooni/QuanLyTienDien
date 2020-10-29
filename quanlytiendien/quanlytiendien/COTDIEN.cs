using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlytiendien
{
    class COTDIEN
    {

		String macd;
		int tt;
		String matram, vitri, mota, ngaytao, ngaycapnhat;
		int sldh;

		public COTDIEN(string macd, int tt, string matram, string vitri, string mota, string ngaytao, string ngaycapnhat, int sldh)
		{
			this.macd = macd;
			this.tt = tt;
			this.matram = matram;
			this.vitri = vitri;
			this.mota = mota;
			this.ngaytao = ngaytao;
			this.ngaycapnhat = ngaycapnhat;
			this.sldh = sldh;
		}
		public COTDIEN()
		{
		}

		public string Macd { get => macd; set => macd = value; }
		public int Tt { get => tt; set => tt = value; }
		public string Matram { get => matram; set => matram = value; }
		public string Vitri { get => vitri; set => vitri = value; }
		public string Mota { get => mota; set => mota = value; }
		public string Ngaytao { get => ngaytao; set => ngaytao = value; }
		public string Ngaycapnhat { get => ngaycapnhat; set => ngaycapnhat = value; }
		public int Sldh { get => sldh; set => sldh = value; }
	}
}
