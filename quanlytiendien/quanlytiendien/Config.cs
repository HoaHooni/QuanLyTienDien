using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlytiendien
{
    class Config
    {
        Random rd = new Random();
         
        public int status_normal()
        {
            return 1;
        }
        public int status_inactive()
        {
            return 3;
        }
        public int statu_die()
        {
            return 9;
        }
        public string final_code_lock()
        {
            String code = "dh-";
            for (int i = 0; i < 10; i++)
            {
                code=code+rd.Next(10);
            }
            return code.ToString();

        }
        public string final_code_station()
        {
            String code = "td-";
            for (int i = 0; i < 10; i++)
            {
                code = code + rd.Next(10);
            }
            return code.ToString();

        }


        public string final_code_pole()
        {
            String code = "cd-";
            for (int i = 0; i < 10; i++)
            {
                code = code + rd.Next(10);
            }
            return code.ToString();

        }
        public string final_code_price()
        {
            String code = "gd-";
            for (int i = 0; i < 10; i++)
            {
                code = code + rd.Next(10);
            }
            return code.ToString();

        }
        public string final_code_staff()
        {
            String code = "nv-";
            for (int i = 0; i < 10; i++)
            {
                code = code + rd.Next(10);
            }
            return code.ToString();

        }
        public string final_code_customer()
        {
            String code = "kh-";
            for (int i = 0; i < 10; i++)
            {
                code = code + rd.Next(10);
            }
            return code.ToString();

        }
        public string final_code_bill()
        {
            String code = "hd-";
            for (int i = 0; i < 10; i++)
            {
                code = code + rd.Next(10);
            }
            return code.ToString();

        }
        DateTime dt =  DateTime.Now;
        public string final_date()
        {
            return dt.ToString("MM/dd/yyyy HH:mm:ss");
        }
        public int finale_position(string text)
        {
            if(text.Equals("Quản lí")) return 1;
            if(text.Equals("Nhân viên")) return 2;
            return 0;
        }
    }
}
