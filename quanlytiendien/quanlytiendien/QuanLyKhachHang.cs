using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlytiendien
{
    public partial class QuanLyKhachHang : Form
    {
        public QuanLyKhachHang()
        {
            InitializeComponent();
        }
        /*
        * Data by Hoa
        */
        String connectString = @"Data Source=DESKTOP-7VDPE8B\SQLEXPRESS;Initial Catalog=QUANLYTIENDIEN;Integrated Security=True";
        //private String connectString = @"Data Source=DESKTOP-GTHU7QH;Initial Catalog=QUANLYTIENDIEN;Integrated Security=True";
        private SqlConnection con = new SqlConnection();

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connectString);
            con.Open();
            String sql = "Select code as N'Mã khách hàng', name as N'Tên khách hàng', age as N'Tuổi',gender as N'Giới tính', location as N'Địa chỉ',  type as N'Loại KH',lock_code as N'mã đồng hồ',bill_code as N'Mã bưu' , status as N'Trạng Thái', created_at as N'Ngày bắt đầu', updated_at as N'Ngày nâng cấp' from customer";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dgvkhachang.DataSource = dt;
            con.Close();
        }

        private void dgvkhachang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d;
            d = e.RowIndex;
            txtmakh.Text = dgvkhachang.Rows[d].Cells[0].Value.ToString();
            txttenkh.Text = dgvkhachang.Rows[d].Cells[1].Value.ToString();
            cbxtrangthai.Text = dgvkhachang.Rows[d].Cells[8].Value.ToString();
            txttuoi.Text = dgvkhachang.Rows[d].Cells[2].Value.ToString();
            txtdiachi.Text = dgvkhachang.Rows[d].Cells[4].Value.ToString();
            if (dgvkhachang.Rows[d].Cells[3].Value.ToString() == "nam")
                rdnam.Checked = true;
            else
                rdnu.Checked = true;
            cbxloaikh.Text = dgvkhachang.Rows[d].Cells[5].Value.ToString();
            txtmadongho.Text = dgvkhachang.Rows[d].Cells[6].Value.ToString();
            txtmaHD.Text = dgvkhachang.Rows[d].Cells[7].Value.ToString();
            dtpngaytao.Value = DateTime.Parse(dgvkhachang.Rows[d].Cells[9].Value.ToString());
            dtpcapnhat.Value = DateTime.Parse(dgvkhachang.Rows[d].Cells[10].Value.ToString());
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmakh.Text.Trim() == "")
                {
                    MessageBox.Show("Mã khách hàng ko được để trống", "Error", MessageBoxButtons.OK);
                    return;
                }
                if (cbxtrangthai.Text.Trim() == "")
                {
                    MessageBox.Show("Trạng thái ko được để trống ", "Error", MessageBoxButtons.OK);
                    return;
                }
                if (txttenkh.Text.Trim() == "")
                {
                    MessageBox.Show("Tên khách hàng ko được để trống ", "Error", MessageBoxButtons.OK);
                    return;
                }
                if (txttuoi.Text.Trim() == "")
                {
                    MessageBox.Show("tuổi khách hàng không được để trống ", "Error", MessageBoxButtons.OK);
                    return;
                }
                if (txtdiachi.Text.Trim() == "")
                {
                    MessageBox.Show("Địa chỉ khách hàng không được để trống ", "Error", MessageBoxButtons.OK);
                    return;
                }
                if (txtmadongho.Text.Trim() == "")
                {
                    MessageBox.Show("Mã đồng hồ không được để trống ", "Error", MessageBoxButtons.OK);
                    return;
                }
                if (txtmaHD.Text.Trim() == "")
                {
                    MessageBox.Show("Mã hóa đơn không được để trống ", "Error", MessageBoxButtons.OK);
                    return;
                }

                if (con.State == ConnectionState.Closed)
                    con.Open();
                String cmdText = "insert into customer values(@code,@name,@age,@gender,@location,@type,@lock_code,@bill_code,@status,@created_at,@updated_at )";
                SqlCommand cmd = new SqlCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@code", txtmakh.Text);
                cmd.Parameters.AddWithValue("@status", cbxtrangthai.Text);
                cmd.Parameters.AddWithValue("@name", txttenkh.Text);
                cmd.Parameters.AddWithValue("@age", txttuoi.Text);
                if (rdnam.Checked)
                    cmd.Parameters.AddWithValue("@gender", "nam");
                else
                    cmd.Parameters.AddWithValue("@gender", "nữ");
                cmd.Parameters.AddWithValue("@location", txtdiachi.Text);
                cmd.Parameters.AddWithValue("@bill_code", txtmaHD.Text);
                cmd.Parameters.AddWithValue("@lock_code", txtmadongho.Text);
                cmd.Parameters.AddWithValue("@type", cbxloaikh.Text);
                cmd.Parameters.AddWithValue("@created_at", dtpngaytao.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@updated_at", dtpngaytao.Value.ToString("yyyy-MM-dd"));

                int check = cmd.ExecuteNonQuery();

                if (check != 0)
                {
                    MessageBox.Show("Thêm thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (SqlException ex)
            {
                if (ex.Message.Contains("PRIMARY KEY"))
                    MessageBox.Show("Mã nhân viên ko được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (con.State == ConnectionState.Open)
                con.Close();
            QuanLyKhachHang_Load(sender, e);
        }

        private void btsua_Click(object sender, EventArgs e)
        {

            if (txtmakh.Text.Trim() == "")
            {
                MessageBox.Show("Mã khách hàng ko được để trống", "Error", MessageBoxButtons.OK);
                return;
            }
            if (cbxtrangthai.Text.Trim() == "")
            {
                MessageBox.Show("Trạng thái ko được để trống ", "Error", MessageBoxButtons.OK);
                return;
            }
            if (txttenkh.Text.Trim() == "")
            {
                MessageBox.Show("Tên khách hàng ko được để trống ", "Error", MessageBoxButtons.OK);
                return;
            }
            if (txttuoi.Text.Trim() == "")
            {
                MessageBox.Show("tuổi khách hàng không được để trống ", "Error", MessageBoxButtons.OK);
                return;
            }
            if (txtdiachi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ khách hàng không được để trống ", "Error", MessageBoxButtons.OK);
                return;
            }
            if (txtmadongho.Text.Trim() == "")
            {
                MessageBox.Show("Mã đồng hồ không được để trống ", "Error", MessageBoxButtons.OK);
                return;
            }
            if (txtmaHD.Text.Trim() == "")
            {
                MessageBox.Show("Mã hóa đơn không được để trống ", "Error", MessageBoxButtons.OK);
                return;
            }

            if (con.State == ConnectionState.Closed)
                con.Open();
            String cmdText = "update customer set name=@name,age=@age,gender=@gender,location=@location,type=@type,lock_code=@lock_code,bill_code=@bill_code,status=@status,created_at=@created_at,updated_at=@updated_at Where code=@code";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@code", txtmakh.Text);
            cmd.Parameters.AddWithValue("@status", cbxtrangthai.Text);
            cmd.Parameters.AddWithValue("@name", txttenkh.Text);
            cmd.Parameters.AddWithValue("@age", txttuoi.Text);
            if (rdnam.Checked)
                cmd.Parameters.AddWithValue("@gender", "nam");
            else
                cmd.Parameters.AddWithValue("@gender", "nữ");
            cmd.Parameters.AddWithValue("@location", txtdiachi.Text);
            cmd.Parameters.AddWithValue("@bill_code", txtmaHD.Text);
            cmd.Parameters.AddWithValue("@lock_code", txtmadongho.Text);
            cmd.Parameters.AddWithValue("@type", cbxloaikh.Text);
            cmd.Parameters.AddWithValue("@created_at", dtpngaytao.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@updated_at", dtpngaytao.Value.ToString("yyyy-MM-dd"));

            int check = cmd.ExecuteNonQuery();

            if (check != 0)
            {
                MessageBox.Show("Sửa thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Sửa thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (con.State == ConnectionState.Open)
                con.Close();
            QuanLyKhachHang_Load(sender, e);
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            if (MessageBox.Show("Bạn muốn xóa khách hàng này ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String xoa = "Delete from customer where code=@code";
                SqlCommand cmd = new SqlCommand(xoa, con);
                cmd.Parameters.AddWithValue("code", txtmakh.Text);
                cmd.ExecuteNonQuery();
            }
            if (con.State == ConnectionState.Open)
                con.Close();
            QuanLyKhachHang_Load(sender, e);
        }

        private void bttim_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            String sql = "Select *from customer where code=@code";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("code", txtmakh.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvkhachang.DataSource = dt;
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có thật sự muốn thoát ko?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                new Home().Show();
                this.Close();
            }

        }
    }
}
