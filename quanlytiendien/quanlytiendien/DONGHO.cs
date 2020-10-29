using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlytiendien
{
    public class DONGHO
    {
		string madh, macd, mansx, mota;
		int tt;
		String ngaytao, ngaycapnhat;
		int sodientruoc, sodiensau;

		public string Madh { get => madh; set => madh = value; }
		public string Macd { get => macd; set => macd = value; }
		public string Mansx { get => mansx; set => mansx = value; }
		public string Mota { get => mota; set => mota = value; }
		public int Tt { get => tt; set => tt = value; }
		public string Ngaytao { get => ngaytao; set => ngaytao = value; }
		public string Ngaycapnhat { get => ngaycapnhat; set => ngaycapnhat = value; }
		public int Sodientruoc { get => sodientruoc; set => sodientruoc = value; }
		public int Sodiensau { get => sodiensau; set => sodiensau = value; }
		
		public DONGHO()
		{

		}
		public DONGHO(String madh,String macd,String mansx, String mota,int tt, String ngaytao, String ngaycapnhat, int sodientruoc,int sodiensau)
		{
			this.madh = madh;
			this.macd = macd;
			this.mansx = mansx;
			this.mota = mota;
			this.tt = tt;
			this.ngaytao = ngaytao;
			this.ngaycapnhat = ngaycapnhat;
			this.sodientruoc = sodientruoc;
			this.Sodiensau = sodiensau;
		}
	}
}
