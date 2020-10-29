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
    public partial class QuanLyCotDien : Form
    {
        public QuanLyCotDien()
        {
            InitializeComponent();
        }

        /*
        * Data by Hoa
        */
        String sqlconnection = @"Data Source=DESKTOP-7VDPE8B\SQLEXPRESS;Initial Catalog=QUANLYTIENDIEN;Integrated Security=True";
        //String sqlconnection = @"Data Source=DESKTOP-2L3VN7I;Initial Catalog=QUANLYTIENDIEN;Integrated Security=True";
        SqlConnection conn;
        Config conf = new Config();
        public void getConnectDB(String text)
        {
            conn = new SqlConnection(sqlconnection);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand cmd = new SqlCommand(text, conn);
            cmd.ExecuteNonQuery();

            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dtgquanlycotdien.DataSource = dt;

            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
        private void QuanLyCotDien_Load(object sender, EventArgs e)
        {

            try
            {
                String text = "select code as N'Mã Cột điện',CASE WHEN status = 1 THEN N'Đang hoạt động' WHEN status = 3 THEN N'Đang bảo trì' ELSE N'Ngừng hoạt động' END AS N'Trạng thái', power_station_code as N'Mã tram điện', location as N'Vị trí',description as N'Mô tả',created_at as N'Ngày tạo', updated_at as N'Ngày hoạt động',lock_amount as N'Số lượng đồng hồ' from power_poles where status > 0";
                getConnectDB(text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi chi tiết " + ex.Message);
            }

        }

        private void btllayds_Click(object sender, EventArgs e)
        {
            try
            {
                String text = "select code as N'Mã Cột điện',CASE WHEN status = 1 THEN N'Đang hoạt động' WHEN status = 3 THEN N'Đang bảo trì' ELSE N'Ngừng hoạt động' END AS N'Trạng thái', power_station_code as N'Mã tram điện', location as N'Vị trí',description as N'Mô tả',created_at as N'Ngày tạo', updated_at as N'Ngày hoạt động',lock_amount as N'Số lượng đồng hồ' from power_poles ";
                getConnectDB(text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi chi tiết " + ex.Message);
            }


        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                String macd =txtmacot.Text.Trim();
                String vitri = txtvitri.Text.Trim();
                if (vitri.Equals("")) throw new Exception("vị trí không được bỏ trống");
                String matram = txtmatram.Text.Trim();
                if (txtmatram.Text.Trim().Equals("")) throw new Exception("Mã trạm không được bỏ trống");
                int soluong = 0;
                try
                {
                    soluong = int.Parse(txtdongho.Text.Trim());
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Có lỗi chi tiết số lượng không đúng định dạng");
                }

                String mota = txtmota.Text.Trim();
                if (mota.Equals("")) throw new Exception("Mô tả được bỏ trống");
                int trangthai = 0;
                if (cmbtrangthai.SelectedItem.Equals("Đang hoạt động")) trangthai = conf.status_normal();
                if (cmbtrangthai.SelectedItem.Equals("Bảo trì")) trangthai = conf.status_inactive();
                if (cmbtrangthai.SelectedItem.Equals("Ngừng hoạt động")) trangthai = conf.statu_die();
                String ngay = conf.final_date();
                String text = "UPDATE [dbo].[power_poles] SET  [status]=@tt,[power_station_code]=@matram, [location]=@vitri,[description]=@mota, [updated_at]=@ngaycn,[lock_amount]=@sl  where [code]=@mcd";
                conn = new SqlConnection(sqlconnection);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand(text, conn);
                cmd.Parameters.AddWithValue("@mcd",macd);
                cmd.Parameters.AddWithValue("@tt",trangthai);
                cmd.Parameters.AddWithValue("@matram", matram);
                cmd.Parameters.AddWithValue("@vitri", vitri);
                cmd.Parameters.AddWithValue("@mota",mota);
                cmd.Parameters.AddWithValue("@ngaycn",ngay);
                cmd.Parameters.AddWithValue("@sl",soluong);
                int check = cmd.ExecuteNonQuery();

                if (check != 0)
                {
                    MessageBox.Show("Cập nhật thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                QuanLyCotDien_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi chi tiết " + ex.Message);
            }

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                String macd = conf.final_code_pole();
                String vitri = txtvitri.Text.Trim();
                if (vitri.Equals("")) throw new Exception("vị trí không được bỏ trống");
                String matram = txtmatram.Text.Trim();
                if (txtmatram.Text.Trim().Equals("")) throw new Exception("Mã trạm không được bỏ trống");
                int soluong = 0;
                try
                {
                    soluong = int.Parse(txtdongho.Text.Trim());
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Có lỗi chi tiết số lượng không đúng định dạng");
                }

                String mota = txtmota.Text.Trim();
                if (mota.Equals("")) throw new Exception("Mô tả được bỏ trống");
                int trangthai = 0;
                if (cmbtrangthai.SelectedItem.Equals("Đang hoạt động"))
                {
                    trangthai = conf.status_normal();
                }
                if (cmbtrangthai.SelectedItem.Equals("Bảo trì")) trangthai = conf.status_inactive();
                if (cmbtrangthai.SelectedItem.Equals("Ngừng hoạt động")) trangthai = conf.statu_die();

                String ngay = conf.final_date();
                COTDIEN a = new COTDIEN(macd, trangthai,matram,vitri, mota,ngay,  ngay,  soluong);
                String text = "INSERT [dbo].[power_poles] ([code], [status], [power_station_code], [location], [description], [created_at], [updated_at], [lock_amount]) VALUES (@mcd,@tt,@matram,@vitri,@mota,@ngayt,@ngaycn,@sl)";
                conn = new SqlConnection(sqlconnection);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand(text, conn);
                cmd.Parameters.AddWithValue("@mcd", a.Macd);
                cmd.Parameters.AddWithValue("@tt", a.Tt);
                cmd.Parameters.AddWithValue("@matram", a.Matram);
                cmd.Parameters.AddWithValue("@vitri", a.Vitri);
                cmd.Parameters.AddWithValue("@mota", a.Mota);
                cmd.Parameters.AddWithValue("@ngayt", a.Ngaytao);
                cmd.Parameters.AddWithValue("@ngaycn", a.Ngaycapnhat);
                cmd.Parameters.AddWithValue("@sl", a.Sldh);
                int check = cmd.ExecuteNonQuery();

                if (check != 0)
                {
                    MessageBox.Show("Thêm thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                QuanLyCotDien_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi chi tiết " + ex.Message);
            }

        }
        int row;
        private void dtgquanlycotdien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;

            txtdongho.Text = dtgquanlycotdien.Rows[row].Cells[7].Value.ToString();
            txtmatram.Text = dtgquanlycotdien.Rows[row].Cells[2].Value.ToString();
            txtvitri.Text = dtgquanlycotdien.Rows[row].Cells[3].Value.ToString();
            txtmota.Text = dtgquanlycotdien.Rows[row].Cells[4].Value.ToString();
            cmbtrangthai.Text = dtgquanlycotdien.Rows[row].Cells[1].Value.ToString();
            txtmacot.Text = dtgquanlycotdien.Rows[row].Cells[0].Value.ToString();
           
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            { 
            String macd = txtmacot.Text.Trim();
            int  trangthai = conf.statu_die();
           
            String ngay = conf.final_date();
            String text = "UPDATE [dbo].[power_poles] SET  [status]=@tt, [updated_at]=@ngaycn  where [code]=@mcd";
            conn = new SqlConnection(sqlconnection);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand cmd = new SqlCommand(text, conn);
            cmd.Parameters.AddWithValue("@mcd", macd);
            cmd.Parameters.AddWithValue("@tt", trangthai);
            cmd.Parameters.AddWithValue("@ngaycn", ngay);

            int check = cmd.ExecuteNonQuery();
            if (check != 0)
            {
                MessageBox.Show("Xóa thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (conn.State == ConnectionState.Open)
                conn.Close();
            QuanLyCotDien_Load(sender, e);
        }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi chi tiết " + ex.Message);
            }
}

        private void btnthoat_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }
    }

}
