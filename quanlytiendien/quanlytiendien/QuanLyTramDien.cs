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
    public partial class QuanLyTramDien : Form
    {
        public QuanLyTramDien()
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
            dtgquanlytram.DataSource = dt;

            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
        private void QuanLyTramDien_Load(object sender, EventArgs e)
        {
            try
            {
                String text = "select code as N'Mã Trạm',CASE WHEN status = 1 THEN N'Đang hoạt động' WHEN status = 3 THEN N'Đang bảo trì' ELSE N'Ngừng hoạt động' END AS N'Trạng thái', location as N'Vị trí', power_poles_amount as N'Số cột điện',description as N'Mô tả',created_at as N'Ngày tạo', updated_at N'Ngày hoạt động' from power_station where status < 9";
                getConnectDB(text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi chi tiết " + ex.Message);
            }



        }

        private void btnlayds_Click(object sender, EventArgs e)
        {
            try
            {
                String text = "select code as N'Mã Trạm',CASE WHEN status = 1 THEN N'Đang hoạt động' WHEN status = 3 THEN N'Đang bảo trì' ELSE N'Ngừng hoạt động' END AS N'Trạng thái', location as N'Vị trí', power_poles_amount as N'Số cột điện',description as N'Mô tả',created_at as N'Ngày tạo', updated_at N'Ngày hoạt động' from power_station ";
                getConnectDB(text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi chi tiết " + ex.Message);
            }

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            try
            {
                new Home().Show();
                this.Hide();
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
                String mahd = conf.final_code_station();
                String vitri = txtvitri.Text.Trim();
                if (vitri.Equals("")) throw new Exception("vị trí không được bỏ trống");
                if (txtslcot.Text.Trim().Equals("")) throw new Exception("Số lượng không được bỏ trống");
                int soluong = 0;
                try
                {
                    soluong = int.Parse(txtslcot.Text.Trim());
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Có lỗi chi tiết số lượng không đúng định dạng");
                }

                String mota = txtmota.Text.Trim();
                if (mota.Equals("")) throw new Exception("Mô tả được bỏ trống");
                int trangthai = 0;
                if (cmbtt.SelectedItem.Equals("Đang hoạt động"))
                {
                    trangthai = conf.status_normal();
                }
                if (cmbtt.SelectedItem.Equals("Bảo trì")) trangthai = conf.status_inactive();
                if (cmbtt.SelectedItem.Equals("Ngừng hoạt động")) trangthai = conf.statu_die();

                String ngay = conf.final_date();
                TRAMDIEN a = new TRAMDIEN(mahd, trangthai, vitri, soluong, mota, ngay, ngay);
                String text = "INSERT [dbo].[power_station] ([code], [status], [location], [power_poles_amount], [description], [created_at], [updated_at]) VALUES (@ma,@tt,@vitri,@sl,@mt,@ngayt,@ngaycn)";
                conn = new SqlConnection(sqlconnection);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand(text, conn);
                cmd.Parameters.AddWithValue("@ma", a.Matram);
                cmd.Parameters.AddWithValue("@tt", a.Tt);
                cmd.Parameters.AddWithValue("@vitri", a.Vitri);
                cmd.Parameters.AddWithValue("@sl", a.Slcd);
                cmd.Parameters.AddWithValue("@mt", a.Mota);
                cmd.Parameters.AddWithValue("@ngayt", a.Ngaytao);
                cmd.Parameters.AddWithValue("@ngaycn", a.Ngaycapnhat);
                int check = cmd.ExecuteNonQuery();

                if (check != 0)
                {
                    MessageBox.Show("Thêm thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                QuanLyTramDien_Load(sender, e);
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
                String mahd = txtmahd.Text.Trim();
                if (mahd.Equals("")) throw new Exception("mã hóa đơn không tồn tại");
                String vitri = txtvitri.Text.Trim();
                if (vitri.Equals("")) throw new Exception("vị trí không được bỏ trống");
                if (txtslcot.Text.Trim().Equals("")) throw new Exception("Số lượng không được bỏ trống");
                int soluong = 0;
                try
                {
                    soluong = int.Parse(txtslcot.Text.Trim());
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Có lỗi chi tiết số lượng không đúng định dạng");
                }

                String mota = txtmota.Text.Trim();
                if (mota.Equals("")) throw new Exception("Mô tả được bỏ trống");
                int trangthai = 0;
                if (cmbtt.SelectedItem.Equals("Đang hoạt động"))
                {
                    trangthai = conf.status_normal();
                }
                if (cmbtt.SelectedItem.Equals("Bảo trì")) trangthai = conf.status_inactive();
                if (cmbtt.SelectedItem.Equals("Ngừng hoạt động")) trangthai = conf.statu_die();

                String ngay = conf.final_date();

                //test lay ngay tao
                /*
                String text = "select *from power_station where code='" + mahd + "'";
               
                
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand(text, conn);
                String ngaytao = "";
                int check = cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    ngaytao = reader["created_at"].ToString();
                }

                MessageBox.Show(ngaytao);
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                */


               TRAMDIEN a = new TRAMDIEN(mahd, trangthai, vitri, soluong, mota,ngay, ngay);
                String text = "UPDATE [dbo].[power_station] SET  [status]=@tt, [location]=@vitri, [power_poles_amount]=@sl, [description]=@mt, [updated_at]=@ngaycn where [code]=@ma";
                conn = new SqlConnection(sqlconnection);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand(text, conn);
                cmd.Parameters.AddWithValue("@ma", a.Matram);
                cmd.Parameters.AddWithValue("@tt", a.Tt);
                cmd.Parameters.AddWithValue("@vitri", a.Vitri);
                cmd.Parameters.AddWithValue("@sl", a.Slcd);
                cmd.Parameters.AddWithValue("@mt", a.Mota);
                cmd.Parameters.AddWithValue("@ngaycn", a.Ngaycapnhat);
                int check = cmd.ExecuteNonQuery();

                if (check != 0)
                {
                    MessageBox.Show("Cập nhật thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Cập nhất thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                QuanLyTramDien_Load(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi chi tiết " + ex.Message);
            }

        }
        int row;
        private void dtgquanlytram_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row= e.RowIndex;

            txtmahd.Text = dtgquanlytram.Rows[row].Cells[0].Value.ToString();
            txtvitri.Text = dtgquanlytram.Rows[row].Cells[2].Value.ToString();
            txtmota.Text = dtgquanlytram.Rows[row].Cells[4].Value.ToString();
            txtslcot.Text = dtgquanlytram.Rows[row].Cells[3].Value.ToString();
            cmbtt.Text = dtgquanlytram.Rows[row].Cells[1].Value.ToString();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                String matd = txtmahd.Text.Trim();
                if (matd.Equals("")) throw new Exception("mã hóa đơn không tồn tại");
             

                String text = "UPDATE [dbo].[power_station] SET  [status]=@tt where [code]=@ma";
                conn = new SqlConnection(sqlconnection);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                int trangthai = conf.statu_die();
                SqlCommand cmd = new SqlCommand(text, conn);
                cmd.Parameters.AddWithValue("@ma", matd);
                cmd.Parameters.AddWithValue("@tt",trangthai);
                int check = cmd.ExecuteNonQuery();

                if (check != 0)
                {
                    MessageBox.Show("Xóa thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                QuanLyTramDien_Load(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi chi tiết " + ex.Message);
            }
        }
    }
}
