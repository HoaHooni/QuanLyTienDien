using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlytiendien
{
    public partial class QuanLyDongHo : Form
    {
        public QuanLyDongHo()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        String url = @"Data Source=DESKTOP-7VDPE8B\SQLEXPRESS;Initial Catalog=QUANLYTIENDIEN;Integrated Security=True";
        private Boolean checkMaKH(String maHD)
        {
            conn = new SqlConnection(url);

            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                String sql = "select 1 from customer where code = '" + maHD.Trim() + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        private Boolean checkMaDH(String maHD)
        {
            conn = new SqlConnection(url);

            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                String sql = "select 1 from lock where code = '" + maHD.Trim() + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private Boolean checkMaCD(String maHD)
        {
            conn = new SqlConnection(url);

            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                String sql = "select 1 from power_poles where code ='" + maHD.Trim() + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        Config cof = new Config();

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaDH.Text.Trim() == "")
            {
                MessageBox.Show("Mã đồng hồ không được để trống", "Error", MessageBoxButtons.OK);
                return;
            }
            if (txtNhaSX.Text.Trim() == "")
            {
                MessageBox.Show("Nhà sản xuất không được để trống", "Error", MessageBoxButtons.OK);
                return;
            }
            if (txtMaCotDien.Text.Trim() == "")
            {
                MessageBox.Show("Mã cột điện không được để trống", "Error", MessageBoxButtons.OK);
                return;
            }

            if (checkMaDH(txtMaDH.Text.Trim()))
            {
                MessageBox.Show("Mã đồng hồ đã tồn tại", "Error", MessageBoxButtons.OK);
                return;
            }
       
            if (!checkMaCD(txtMaCotDien.Text.Trim()))
            {
                MessageBox.Show("Mã cột điện không tồn tại", "Error", MessageBoxButtons.OK);
                return;
            }

            String maDH = txtMaDH.Text.Trim();
            String maCD = txtMaCotDien.Text.Trim();
            String tenNhaSX = txtNhaSX.Text.Trim();
            String mota = txtMoTa.Text.Trim();
            String trangThai = cobTrangThai.Text.Trim();
            int tt = 9;
            if (trangThai.ToLower().Equals("hoạt động")) tt = 1;
            if (trangThai.ToLower().Equals("bảo trì")) tt = 3;
            if (trangThai.ToLower().Equals("ngừng hoạt động")) tt = 9;
               

            int chiSoTruoc = Int32.Parse(txtChiSoTruoc.Text);
            int chiSoSau = Int32.Parse(txtChiSoSau.Text);
            String ngaytao = cof.final_date();
            String ngayupdate = cof.final_date();
            DONGHO dh = new DONGHO(maDH, maCD, tenNhaSX, mota,tt, ngaytao, ngayupdate, chiSoTruoc, chiSoSau);
            String sql = "insert into lock values(@code, @power_poles_code, @manufactor, @description" +
                ", @status, @created_at, @updated_at, @electronic_meter_after, @electronic_meter_before)";
            conn = new SqlConnection(url);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@code", dh.Madh);
            cmd.Parameters.AddWithValue("@power_poles_code", dh.Macd);
            cmd.Parameters.AddWithValue("@manufactor", dh.Mansx);
            cmd.Parameters.AddWithValue("@description", dh.Mota);
            cmd.Parameters.AddWithValue("@status", dh.Tt);
            cmd.Parameters.AddWithValue("@created_at", dh.Ngaytao);
            cmd.Parameters.AddWithValue("@updated_at", dh.Ngaycapnhat);
            cmd.Parameters.AddWithValue("@electronic_meter_after", dh.Sodiensau);
            cmd.Parameters.AddWithValue("@electronic_meter_before", dh.Sodientruoc);

            int check = cmd.ExecuteNonQuery();

            if (check != 0)
            {
                MessageBox.Show("Thêm thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            QuanLyDongHo_Load(sender, e);
        }

        private void QuanLyDongHo_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(url);
            try
            {

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                String sql = "exec Proc_GetLock";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                SqlDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(dr);
                dgvQuanLyDongHo.DataSource = dt;

                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvQuanLyDongHo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            txtMaDH.Text = dgvQuanLyDongHo.Rows[r].Cells[0].Value.ToString();
            txtMaCotDien.Text = dgvQuanLyDongHo.Rows[r].Cells[1].Value.ToString();
            txtNhaSX.Text = dgvQuanLyDongHo.Rows[r].Cells[2].Value.ToString();
            txtMoTa.Text = dgvQuanLyDongHo.Rows[r].Cells[3].Value.ToString();
            cobTrangThai.Text = dgvQuanLyDongHo.Rows[r].Cells[4].Value.ToString();
        
            dtpNgayUpdate.Text = dgvQuanLyDongHo.Rows[r].Cells[6].Value.ToString();
            txtChiSoTruoc.Text = dgvQuanLyDongHo.Rows[r].Cells[8].Value.ToString();
            txtChiSoSau.Text = dgvQuanLyDongHo.Rows[r].Cells[7].Value.ToString();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaDH.Text.Trim() == "")
            {
                MessageBox.Show("Mã đồng hồ không được để trống", "Error", MessageBoxButtons.OK);
                return;
            }
            if (txtNhaSX.Text.Trim() == "")
            {
                MessageBox.Show("Nhà sản xuất không được để trống", "Error", MessageBoxButtons.OK);
                return;
            }
            if (txtMaCotDien.Text.Trim() == "")
            {
                MessageBox.Show("Mã cột điện không được để trống", "Error", MessageBoxButtons.OK);
                return;
            }

            if (!checkMaDH(txtMaDH.Text.Trim()))
            {
                MessageBox.Show("Mã đồng hồ không tồn tại", "Error", MessageBoxButtons.OK);
                return;
            }

            if (!checkMaCD(txtMaCotDien.Text.Trim()))
            {
                MessageBox.Show("Mã cột điện không tồn tại", "Error", MessageBoxButtons.OK);
                return;
            }

            String maDH = txtMaDH.Text.Trim();
            String maCD = txtMaCotDien.Text.Trim();
            String tenNhaSX = txtNhaSX.Text.Trim();
            String mota = txtMoTa.Text.Trim();
            String trangThai = cobTrangThai.Text.Trim();
            int tt = 9;
            if (trangThai.ToLower().Equals("hoạt động")) tt = 1;
            if (trangThai.ToLower().Equals("bảo trì")) tt = 3;
            if (trangThai.ToLower().Equals("ngừng hoạt động")) tt = 9;


            int chiSoTruoc = Int32.Parse(txtChiSoTruoc.Text);
            int chiSoSau = Int32.Parse(txtChiSoSau.Text);
            String ngaytao = cof.final_date();
            String ngayupdate = cof.final_date();
            DONGHO dh = new DONGHO(maDH, maCD, tenNhaSX, mota, tt, ngaytao, ngayupdate, chiSoTruoc, chiSoSau);
            String sql = "update lock set power_poles_code = @power_poles_code, manufactor = @manufactor, description = @description" +
                ", status = @status, updated_at =@updated_at, electronic_meter_after=@electronic_meter_after" +
                ", electronic_meter_before =@electronic_meter_before where code = @code";
            conn = new SqlConnection(url);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@code", dh.Madh);
            cmd.Parameters.AddWithValue("@power_poles_code", dh.Macd);
            cmd.Parameters.AddWithValue("@manufactor", dh.Mansx);
            cmd.Parameters.AddWithValue("@description", dh.Mota);
            cmd.Parameters.AddWithValue("@status", dh.Tt);

            cmd.Parameters.AddWithValue("@updated_at", dh.Ngaycapnhat);
            cmd.Parameters.AddWithValue("@electronic_meter_after", dh.Sodiensau);
            cmd.Parameters.AddWithValue("@electronic_meter_before", dh.Sodientruoc);

            int check = cmd.ExecuteNonQuery();

            if (check != 0)
            {
                MessageBox.Show("Sửa thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Xoá thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            QuanLyDongHo_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaDH.Text.Trim() == "")
            {
                MessageBox.Show("Mã đồng hồ không được để trống", "Error", MessageBoxButtons.OK);
                return;
            }

            if (!checkMaDH(txtMaDH.Text.Trim()))
            {
                MessageBox.Show("Mã đồng hồ không tồn tại", "Error", MessageBoxButtons.OK);
                return;
            }
            String sql = "delete lock where code = @code";
            conn = new SqlConnection(url);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@code", txtMaDH.Text.Trim());


            int check = 0;
            DialogResult result = MessageBox.Show("Bạn có muốn thoát", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                check = cmd.ExecuteNonQuery();
            }

            if (check != 0)
            {
                MessageBox.Show("Xoá thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Sửa thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            QuanLyDongHo_Load(sender, e);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }
    }
}
