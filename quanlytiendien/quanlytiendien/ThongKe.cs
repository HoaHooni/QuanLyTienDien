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

namespace quanlytiendien
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }
        /*
        * Data by Hoa
        */
        String url = @"Data Source=DESKTOP-7VDPE8B\SQLEXPRESS;Initial Catalog=QUANLYTIENDIEN;Integrated Security=True";
        //String url = @"Data Source=DESKTOP-2L3VN7I;Initial Catalog=QUANLYTIENDIEN;Integrated Security=True";
        SqlConnection conn;
        Config conf = new Config();
        public void getDB(String text)
        {
            conn = new SqlConnection(url);
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand(text, conn);
                cmd.ExecuteNonQuery();

                SqlDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(dr);
                dtgthongke.DataSource = dt;

                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btntram_Click(object sender, EventArgs e)
        {
                String text = " select * from [power_poles] inner join [power_station] on power_poles.power_station_code = [power_station].code inner join [lock] on power_poles.code = [lock].[power_poles_code] where power_poles.[status] < 9";
                getDB(text);
        }

        private void btntg_Click(object sender, EventArgs e)
        {
            String text = " select * from [customer]  where [status] < 9 order by updated_at";
            getDB(text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }
    }
}
