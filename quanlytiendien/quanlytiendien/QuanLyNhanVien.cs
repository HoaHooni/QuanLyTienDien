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
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }
        /*
        * Data by Hoa
        */
        String connectString = @"Data Source=DESKTOP-7VDPE8B\SQLEXPRESS;Initial Catalog=QUANLYTIENDIEN;Integrated Security=True";
        //private String connectString = @"Data Source=DESKTOP-GTHU7QH;Initial Catalog=QUANLYTIENDIEN;Integrated Security=True";
        private SqlConnection con = new SqlConnection();
        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(connectString);
            con.Open();
            String sql = "Select code as N'Mã nhân viên', status as N'Trạng Thái', name as N'Tên NV', age as N'Tuổi', location as N'Địa chỉ', gender as N'Giới tính', username, password, gmail, position as N'Chức vụ', created_at as N'Ngày bắt đầu', updated_at as N'Ngày nâng cấp' from staff";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dgvnhanvien.DataSource = dt;
            con.Close();

        }

        private void btthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmanv.Text.Trim() == "")
                {
                    MessageBox.Show("Mã nhân viên ko được để trống", "Error", MessageBoxButtons.OK);
                    return;
                }
                if (txttennv.Text.Trim() == "")
                {
                    MessageBox.Show("tên nhân viên ko được để trống ", "Error", MessageBoxButtons.OK);
                    return;
                }
                if (txttuoi.Text.Trim() == "")
                {
                    MessageBox.Show("Tuổi nhân viên ko được để trống ", "Error", MessageBoxButtons.OK);
                    return;
                }
                if (txtusername.Text.Trim() == "")
                {
                    MessageBox.Show("Tên đăng nhập không được để trống ", "Error", MessageBoxButtons.OK);
                    return;
                }
                if (txtpass.Text.Trim() == "")
                {
                    MessageBox.Show("Mật khẩu không được để trống ", "Error", MessageBoxButtons.OK);
                    return;
                }
                if (txtdiachi.Text.Trim() == "")
                {
                    MessageBox.Show("Địa chỉ không được để trống ", "Error", MessageBoxButtons.OK);
                    return;
                }
                if (txtgmail.Text.Trim() == "")
                {
                    MessageBox.Show("gamil không được để trống ", "Error", MessageBoxButtons.OK);
                    return;
                }
                if (cbxchucvu.Text.Trim() == "")
                {
                    MessageBox.Show("chức vụ nhân viên không được để trống ", "Error", MessageBoxButtons.OK);
                    return;
                }
                if (cbxtrangthai.Text.Trim() == "")
                {
                    MessageBox.Show("Trạng Thái không được để trống ", "Error", MessageBoxButtons.OK);
                    return;
                }

                if (con.State == ConnectionState.Closed)
                    con.Open();
                String cmdText = "insert into staff values(@code,@status,@name,@age,@location,@gender,@username,@password,@gmail,@position,@created_at,@updated_at )";
                SqlCommand cmd = new SqlCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@code", txtmanv.Text);
                cmd.Parameters.AddWithValue("@name", txttennv.Text);
                cmd.Parameters.AddWithValue("@age", txttuoi.Text);
                if (rdnam.Checked)
                    cmd.Parameters.AddWithValue("@gender", "nam");
                else
                    cmd.Parameters.AddWithValue("@gender", "nữ");
                cmd.Parameters.AddWithValue("@location", txtdiachi.Text);
                cmd.Parameters.AddWithValue("@gmail", txtgmail.Text);
                cmd.Parameters.AddWithValue("@username", txtusername.Text);
                cmd.Parameters.AddWithValue("@password", txtpass.Text);
                cmd.Parameters.AddWithValue("@position", cbxchucvu.Text);
                cmd.Parameters.AddWithValue("@status", cbxtrangthai.Text);
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
            QuanLyNhanVien_Load(sender, e);

        }

        private void btsua_Click(object sender, EventArgs e)
        {
            if (txtmanv.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên ko được để trống", "Error", MessageBoxButtons.OK);
                return;
            }
            if (txttennv.Text.Trim() == "")
            {
                MessageBox.Show("tên nhân viên ko được để trống ", "Error", MessageBoxButtons.OK);
                return;
            }
            if (txttuoi.Text.Trim() == "")
            {
                MessageBox.Show("Tuổi nhân viên ko được để trống ", "Error", MessageBoxButtons.OK);
                return;
            }
            if (txtusername.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập không được để trống ", "Error", MessageBoxButtons.OK);
                return;
            }
            if (txtpass.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được để trống ", "Error", MessageBoxButtons.OK);
                return;
            }
            if (txtdiachi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được để trống ", "Error", MessageBoxButtons.OK);
                return;
            }
            if (txtgmail.Text.Trim() == "")
            {
                MessageBox.Show("gamil không được để trống ", "Error", MessageBoxButtons.OK);
                return;
            }
            if (cbxchucvu.Text.Trim() == "")
            {
                MessageBox.Show("chức vụ nhân viên không được để trống ", "Error", MessageBoxButtons.OK);
                return;
            }
            if (cbxtrangthai.Text.Trim() == "")
            {
                MessageBox.Show("Trạng Thái không được để trống ", "Error", MessageBoxButtons.OK);
                return;
            }


            if (con.State == ConnectionState.Closed)
                con.Open();
            String sql = "update staff set  status=@status,name=@name,age=@age,location=@location,gender=@gender,username=@username,password=@password,gmail=@gmail,position=@position,created_at=@created_at,updated_at=@updated_at where code=@code";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@code", txtmanv.Text);
            cmd.Parameters.AddWithValue("@name", txttennv.Text);
            cmd.Parameters.AddWithValue("@age", txttuoi.Text);
            if (rdnam.Checked)
                cmd.Parameters.AddWithValue("@gender", "nam");
            else
                cmd.Parameters.AddWithValue("@gender", "nữ");
            cmd.Parameters.AddWithValue("@location", txtdiachi.Text);
            cmd.Parameters.AddWithValue("@gmail", txtgmail.Text);
            cmd.Parameters.AddWithValue("@username", txtusername.Text);
            cmd.Parameters.AddWithValue("@password", txtpass.Text);
            cmd.Parameters.AddWithValue("@position", cbxchucvu.Text);
            cmd.Parameters.AddWithValue("@status", cbxtrangthai.Text);
            cmd.Parameters.AddWithValue("@created_at", dtpngaytao.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@updated_at", dtpngaytao.Value.ToString("yyyy-MM-dd"));

            int check = cmd.ExecuteNonQuery();

            if (check != 0)
            {
                MessageBox.Show("Sửa thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("sửa thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (con.State == ConnectionState.Open)
                con.Close();
            QuanLyNhanVien_Load(sender, e);

        }

        private void dgvnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d;
            d = e.RowIndex;
            txtmanv.Text = dgvnhanvien.Rows[d].Cells[0].Value.ToString();
            cbxtrangthai.Text = dgvnhanvien.Rows[d].Cells[1].Value.ToString();
            txttennv.Text = dgvnhanvien.Rows[d].Cells[2].Value.ToString();
            txttuoi.Text = dgvnhanvien.Rows[d].Cells[3].Value.ToString();
            txtdiachi.Text = dgvnhanvien.Rows[d].Cells[4].Value.ToString();
            if (dgvnhanvien.Rows[d].Cells[5].Value.ToString() == "nam")
                rdnam.Checked = true;
            else
                rdnu.Checked = true;
            txtusername.Text = dgvnhanvien.Rows[d].Cells[6].Value.ToString();
            txtpass.Text = dgvnhanvien.Rows[d].Cells[7].Value.ToString();
            txtgmail.Text = dgvnhanvien.Rows[d].Cells[8].Value.ToString();
            cbxchucvu.Text = dgvnhanvien.Rows[d].Cells[9].Value.ToString();
            dtpngaytao.Value = DateTime.Parse(dgvnhanvien.Rows[d].Cells[10].Value.ToString());
            dtpcapnhat.Value = DateTime.Parse(dgvnhanvien.Rows[d].Cells[11].Value.ToString());
        }

        private void bttim_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            String sql = "Select *from staff where code=@code";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("code", txtmanv.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvnhanvien.DataSource = dt;
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có thật sự muốn thoát ko?", "cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                new Home().Show();
                this.Close();
            }


        }

        private void btxoa_Click(object sender, EventArgs e)
        {

            if (con.State == ConnectionState.Closed)
                con.Open();
            if (MessageBox.Show("Bạn muốn xóa Nhân viên này ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String xoa = "Delete from staff where code=@code";
                SqlCommand cmd = new SqlCommand(xoa, con);
                cmd.Parameters.AddWithValue("code", txtmanv.Text);
                cmd.ExecuteNonQuery();
            }
            if (con.State == ConnectionState.Open)
                con.Close();
            QuanLyNhanVien_Load(sender, e);
        }

    }
}
