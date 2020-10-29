using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlytiendien
{
    public partial class QuanLyBangGiaDien : Form
    {
        public QuanLyBangGiaDien()
        {
            InitializeComponent();
        }
        /*
         * Data by Hoa
         */
        String url = @"Data Source=DESKTOP-7VDPE8B\SQLEXPRESS;Initial Catalog=QUANLYTIENDIEN;Integrated Security=True";
        
        //String url = @"Data Source=DESKTOP-2L3VN7I;Initial Catalog=QUANLYTIENDIEN;Integrated Security=True";
        SqlConnection conn;
        BANGGIADIEN bangGiaDien;
        Config conf = new Config();
        private void QuanLyBangGiaDien_Load(object sender, EventArgs e)
        {
            
            conn = new SqlConnection(url);
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                String sql = " select code as N'Mã giá điện',CASE WHEN status = 1 THEN N'Đang hoạt động'" +
                    " WHEN status = 3 THEN N'Đang bảo trì' ELSE N'Ngừng hoạt động' END AS N'Trạng thái'" +
                    ", step_type as N'Loại bậc thang', index_before as N'Chỉ số trước'" +
                    ", index_after as N'Chỉ số sau', custumer_type N'Loại khách hàng'" +
                    ", created_at as N'Ngày tạo', updated_at N'Ngày hoạt động' from electronic_price";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgvBangGiaDien.DataSource = dt;

                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvBangGiaDien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;

            txtMaBangGia.Text = dgvBangGiaDien.Rows[r].Cells[0].Value.ToString();
            cobLoaiBacT.Text = dgvBangGiaDien.Rows[r].Cells[2].Value.ToString();
            cobLoaiKH.Text = dgvBangGiaDien.Rows[r].Cells[5].Value.ToString();
            txtChiSoTruoc.Text = dgvBangGiaDien.Rows[r].Cells[3].Value.ToString();
            txtChiSoSau.Text = dgvBangGiaDien.Rows[r].Cells[4].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaBangGia.Text.Trim() == "")
                {
                    MessageBox.Show("Mã bảng giá không được để trống", "Error", MessageBoxButtons.OK);
                    return;
                }
                if (txtChiSoSau.Text.Trim() == "")
                {
                    MessageBox.Show("Loại khách hàng không được để trống", "Error", MessageBoxButtons.OK);
                    return;
                }
                if (cobLoaiKH.Text.Trim() == "")
                {
                    MessageBox.Show("Loại bậc thang không được để trống", "Error", MessageBoxButtons.OK);
                    return;
                }
                String maBG = txtMaBangGia.Text.Trim();
                String loaiKH = cobLoaiKH.Text.Trim();
                Int32 chiSoTruoc = Int32.Parse(txtChiSoTruoc.Text);
                Int32 chiSoSau = Int32.Parse(txtChiSoSau.Text);
                if (chiSoSau < chiSoTruoc)
                {
                    MessageBox.Show("Chỉ số sau phải lớn hơn chỉ số trước", "Error", MessageBoxButtons.OK);
                    return;
                }
                String loaiBT = txtChiSoSau.Text;
                bangGiaDien = new BANGGIADIEN(maBG, 1, loaiBT, chiSoTruoc, chiSoSau, loaiKH, conf.final_date(), conf.final_date());
                String sql = "insert into [dbo].[electronic_price] values (@code, @status, @step_type, @index_after, @index_before" +
                    ", @custumer_typet, @updated_at)";
                conn = new SqlConnection(url);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@code", bangGiaDien.Mabg);
                cmd.Parameters.AddWithValue("@status", bangGiaDien.Tt);
                cmd.Parameters.AddWithValue("@step_type", bangGiaDien.Loaibt);
                cmd.Parameters.AddWithValue("@index_after", bangGiaDien.Chisosau);
                cmd.Parameters.AddWithValue("@index_before", bangGiaDien.Chisotr);
                cmd.Parameters.AddWithValue("@custumer_type", bangGiaDien.Loaikh);
                cmd.Parameters.AddWithValue("@updated_at", bangGiaDien.Ngaycapnhat);

                int check = cmd.ExecuteNonQuery();

                if (check != 0)
                {
                    MessageBox.Show("Thêm thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            catch (SqlException ex)
            {
                if (ex.Message.Contains("PRIMARY KEY"))
                    MessageBox.Show("Mã hàng không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            QuanLyBangGiaDien_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaBangGia.Text.Trim() == "")
                {
                    MessageBox.Show("Mã bảng giá không được để trống", "Error", MessageBoxButtons.OK);
                    return;
                }

                String maBG = txtMaBangGia.Text.Trim();
                String loaiKH = cobLoaiKH.Text.Trim();
                Int32 chiSoTruoc = Int32.Parse(txtChiSoTruoc.Text);
                Int32 chiSoSau = Int32.Parse(txtChiSoSau.Text);
                String loaiBT = cobLoaiBacT.Text;
                bangGiaDien = new BANGGIADIEN(maBG, 1, loaiBT, chiSoTruoc, chiSoSau, loaiKH, conf.final_date(), conf.final_date());
                String sql = "delete [dbo].[electronic_price] where code = @code";
                conn = new SqlConnection(url);

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@code", bangGiaDien.Mabg);


                int check = cmd.ExecuteNonQuery();

                if (check != 0)
                {
                    MessageBox.Show("Xoá thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Xoá thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Số lượng phải là số nguyên không âm.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("PRIMARY KEY"))
                    MessageBox.Show("Mã hàng không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            QuanLyBangGiaDien_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaBangGia.Text.Trim() == "")
                {
                    MessageBox.Show("Mã bảng giá không được để trống", "Error", MessageBoxButtons.OK);
                    return;
                }
                if (txtChiSoSau.Text.Trim() == "")
                {
                    MessageBox.Show("Loại khách hàng không được để trống", "Error", MessageBoxButtons.OK);
                    return;
                }
                if (cobLoaiKH.Text.Trim() == "")
                {
                    MessageBox.Show("Loại bậc thang không được để trống", "Error", MessageBoxButtons.OK);
                    return;
                }
                String maBG = txtMaBangGia.Text.Trim();
                String loaiKH = cobLoaiKH.Text.Trim();
                Int32 chiSoTruoc = Int32.Parse(txtChiSoTruoc.Text);
                Int32 chiSoSau = Int32.Parse(txtChiSoSau.Text);
                if (chiSoSau < chiSoTruoc)
                {
                    MessageBox.Show("Chỉ số sau phải lớn hơn chỉ số trước", "Error", MessageBoxButtons.OK);
                    return;
                }
                String loaiBT = cobLoaiBacT.Text;
                bangGiaDien = new BANGGIADIEN(maBG, 1, loaiBT, chiSoTruoc, chiSoSau, loaiKH, conf.final_date(), conf.final_date());
                String sql = "update [dbo].[electronic_price] set  status = @status, step_type= @step_type , index_after=@index_after" +
                    ", index_before= @index_before, custumer_type=@custumer_type, created_at=@created_at where code =@code ";
                conn = new SqlConnection(url);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@code", bangGiaDien.Mabg);
                cmd.Parameters.AddWithValue("@status", bangGiaDien.Tt);
                cmd.Parameters.AddWithValue("@step_type", bangGiaDien.Loaibt);
                cmd.Parameters.AddWithValue("@index_after", bangGiaDien.Chisosau);
                cmd.Parameters.AddWithValue("@index_before", bangGiaDien.Chisotr);
                cmd.Parameters.AddWithValue("@custumer_type", bangGiaDien.Loaikh);
                cmd.Parameters.AddWithValue("@created_at", bangGiaDien.Ngaytao);
                cmd.Parameters.AddWithValue("@updated_at", bangGiaDien.Ngaycapnhat);

                int check = cmd.ExecuteNonQuery();

                if (check != 0)
                {
                    MessageBox.Show("Sửa thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Số lượng phải là số nguyên không âm.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("PRIMARY KEY"))
                    MessageBox.Show("Mã hàng không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            QuanLyBangGiaDien_Load(sender, e);
        }

        private void QuanLyBangGiaDien_Load_1(object sender, EventArgs e)
        {

        }
    }
}
