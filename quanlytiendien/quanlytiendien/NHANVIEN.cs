using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlytiendien
{
    class NHANVIEN
    {
        String manv;
        int tt;
        String name;
        int tuoi;
        String diachi, gioitinh, tdn, mk, mail, chucvu, ngaytao, ngaycapnhat;

        public string Manv { get => manv; set => manv = value; }
        public int Tt { get => tt; set => tt = value; }
        public string Name { get => name; set => name = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Tdn { get => tdn; set => tdn = value; }
        public string Mk { get => mk; set => mk = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }
        public string Ngaytao { get => ngaytao; set => ngaytao = value; }
        public string Ngaycapnhat { get => ngaycapnhat; set => ngaycapnhat = value; }

        public NHANVIEN(string manv, int tt, string name, int tuoi, string diachi, string gioitinh, string tdn, string mk, string mail, string chucvu, string ngaytao, string ngaycapnhat)
        {
            this.manv = manv;
            this.tt = tt;
            this.name = name;
            this.tuoi = tuoi;
            this.diachi = diachi;
            this.gioitinh = gioitinh;
            this.tdn = tdn;
            this.mk = mk;
            this.mail = mail;
            this.chucvu = chucvu;
            this.ngaytao = ngaytao;
            this.ngaycapnhat = ngaycapnhat;
        }
        public NHANVIEN()
        {

        }

    }
}
