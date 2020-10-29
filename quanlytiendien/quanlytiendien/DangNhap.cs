using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;

namespace quanlytiendien
{
    public partial class DangNhap : Form
    {
        
        public DangNhap()
        {
            InitializeComponent();
        }
        /*
         *creTED BY HOA
         *
         */
        String connect = @"Data Source=DESKTOP-7VDPE8B\SQLEXPRESS;Initial Catalog=QUANLYTIENDIEN;Integrated Security=True";
        //public String  = @"Data Source=DESKTOP-2L3VN7I;Initial Catalog=QUANLYTIENDIEN;Integrated Security=True";
        public SqlConnection conn ;
        public static String username;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            username= txtdangnhap.Text.Trim();
             String pass= txtmatkhau.Text.Trim();
            if(username==null||username==""||pass==""||pass==null)
            {
                throw new Exception("Tên đăng nhập mật khẩu phải tồn tại!");
            }    
            
            conn = new SqlConnection(connect);
            if(conn.State==ConnectionState.Closed)
            {
                conn.Open();
            }
            String Sqltext = "select* from staff where status < 9 and username = '"+username+"'";
            SqlCommand cmd = new SqlCommand(Sqltext, conn);
            SqlDataReader reader = cmd.ExecuteReader();
          if(reader.Read())
                {
                    String dncheck = reader["username"].ToString();
                    String passcheck = reader["password"].ToString();
                    if (username.Trim().Equals(dncheck) && pass.Trim().Equals(passcheck))
                    {
                        Home a = new Home();
                        a.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại ");
                        return;
                    }
                }   
          else
                {
                    MessageBox.Show("Đăng nhập thất bại ");
                }    
            }
            catch(Exception ex)
            {
                MessageBox.Show("có lỗi chi tiết " + ex.Message.ToString());
            }
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
