using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlytiendien
{
    public class KHACHHANG
    {
		/*
         * [code] [nvarchar](50) NOT NULL,
	[name] [nvarchar](50) NULL,
	[age] int NULL,
	[gender] [nvarchar](50) NULL,
	[location] [nvarchar](50) NULL,
	[type] [nvarchar](50) NULL,
	[lock_code] [nvarchar](50) NULL,
	[bill_code] [nvarchar](50) NULL,
	[status] [int] NULL,
	[created_at] [nvarchar](50) NULL,
	[updated_at] [nvarchar](50) NULL,
	*/
		String makh, tenkh;
		int age;
		String gioitinh, diachi, loaikh, madh, mahd;
		int tt;
		String ngaytao, ngaycapnhat;

		public string Makh { get => makh; set => makh = value; }
		public string Tenkh { get => tenkh; set => tenkh = value; }
		public int Age { get => age; set => age = value; }
		public string Gioitinh { get => gioitinh; set => gioitinh = value; }
		public string Diachi { get => diachi; set => diachi = value; }
		public string Loaikh { get => loaikh; set => loaikh = value; }
		public string Madh { get => madh; set => madh = value; }
		public string Mahd { get => mahd; set => mahd = value; }
		public int Tt { get => tt; set => tt = value; }
		public string Ngaytao { get => ngaytao; set => ngaytao = value; }
		public string Ngaycapnhat { get => ngaycapnhat; set => ngaycapnhat = value; }

		public KHACHHANG(string makh, string tenkh, int age, string gioitinh, string diachi, string loaikh, string madh, string mahd, int tt, string ngaytao, string ngaycapnhat)
		{
			this.makh = makh;
			this.tenkh = tenkh;
			this.age = age;
			this.gioitinh = gioitinh;
			this.diachi = diachi;
			this.loaikh = loaikh;
			this.madh = madh;
			this.mahd = mahd;
			this.tt = tt;
			this.ngaytao = ngaytao;
			this.ngaycapnhat = ngaycapnhat;
		}
		public KHACHHANG()
		{

		}

	}
}
