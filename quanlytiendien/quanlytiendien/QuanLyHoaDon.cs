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
    public partial class QuanLyHoaDon : Form
    {
        public QuanLyHoaDon()
        {
            InitializeComponent();

        }

        SqlConnection conn;
        String url = @"Data Source=DESKTOP-7VDPE8B\SQLEXPRESS;Initial Catalog=QUANLYTIENDIEN;Integrated Security=True";

        private void QuanLyHoaDon_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(url);
            try
            {
                
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                String sql = "SELECT code as N'Mã hoá đơn',[name] as N'Tên hoá đơn',[customer_code] as N'Mã khách hàng' " +
                    ",[staff_code] as N'Mã nhân viên',[lock_code] as N'Mã đồng hồ' ,[electronic_price_code] N'Mã bảng giá điện'" +
                    ",CASE WHEN status = 1 THEN N'Đang hoạt động' WHEN status = 3 THEN N'Đang bảo trì' ELSE N'Ngừng hoạt động'" +
                    "END AS N'Trạng thái',[created_at] as N'Ngày tạo', [updated_at] as N'Ngày cập nhật' FROM[bill]";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                SqlDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(dr);
                dgvQuanLyHoaDon.DataSource = dt;

                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvQuanLyHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtMaHD.Text = dgvQuanLyHoaDon.Rows[d].Cells[0].Value.ToString();
            txtTenHD.Text = dgvQuanLyHoaDon.Rows[d].Cells[1].Value.ToString();
            txtMaKH.Text = dgvQuanLyHoaDon.Rows[d].Cells[2].Value.ToString();
            txtMaNV.Text = dgvQuanLyHoaDon.Rows[d].Cells[3].Value.ToString();
            txtMaDH.Text = dgvQuanLyHoaDon.Rows[d].Cells[4].Value.ToString();
            txtMaGiaDien.Text = dgvQuanLyHoaDon.Rows[d].Cells[5].Value.ToString();
            hd = new HOADON(txtMaHD.Text, txtMaHD.Text, txtMaKH.Text, txtMaNV.Text, txtMaDH.Text, txtMaGiaDien.Text, 1, cof.final_date(), cof.final_date());

        }

        private Boolean checkMaHD(String maHD)
        {
            conn = new SqlConnection(url);

            try{
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                String sql = "select 1 from [dbo].[bill] where code = '"+maHD.Trim()+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows){
                    return true;
                }   
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
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

        private Boolean checkMaNV(String maHD)
        {
            conn = new SqlConnection(url);

            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                String sql = "select 1 from staff where code = '" + maHD.Trim() + "'";
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

        private Boolean checkMaBangGiaDien(String maHD)
        {
            conn = new SqlConnection(url);

            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                String sql = "select 1 from electronic_price where code = '" + maHD.Trim() + "'";
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

        public static HOADON hd;
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text.Trim() == "")
            {
                MessageBox.Show("Mã hoá đơn không được để trống", "Error", MessageBoxButtons.OK);
                return;
            }
            if (txtMaKH.Text.Trim() == "")
            {
                MessageBox.Show("Mã khách hàng không được để trống", "Error", MessageBoxButtons.OK);
                return;
            }
            if (txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được để trống", "Error", MessageBoxButtons.OK);
                return;
            }
            if (txtTenHD.Text.Trim() == "")
            {
                MessageBox.Show("Tên hoá đơn không được để trống", "Error", MessageBoxButtons.OK);
                return;
            }
            if (txtMaDH.Text.Trim() == "")
            {
                MessageBox.Show("Mã đồng hồ không được để trống", "Error", MessageBoxButtons.OK);
                return;
            }
            if (txtMaGiaDien.Text.Trim() == "")
            {
                MessageBox.Show("Mã giá điện không được để trống", "Error", MessageBoxButtons.OK);
                return;
            }
            //check lỗi trùng
            if (checkMaHD(txtMaHD.Text.Trim()))
            {
                MessageBox.Show("Mã hoá đơn đã tồn tại", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!checkMaKH(txtMaKH.Text.Trim()))
            {
                MessageBox.Show("Mã khách hàng không tồn tại", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!checkMaNV(txtMaNV.Text.Trim()))
            {
                MessageBox.Show("Mã đồng hồ không tồn tại", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!checkMaBangGiaDien(txtMaGiaDien.Text.Trim()))
            {
                MessageBox.Show("Mã giá điện không tồn tại", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!checkMaDH(txtMaDH.Text.Trim()))
            {
                MessageBox.Show("Mã đồng hồ không tồn tại", "Error", MessageBoxButtons.OK);
                return;
            }

            string maHD = txtMaHD.Text.Trim();
            string tenHD = txtTenHD.Text.Trim();
            string maKH = txtMaKH.Text.Trim();
            string maNV = txtMaNV.Text.Trim();
            string maDH = txtMaDH.Text.Trim();
            string maGD = txtMaGiaDien.Text.Trim();
            hd = new HOADON(maDH, tenHD, maKH, maNV, maDH, maGD, 1, cof.final_date(), cof.final_date());
            string sql = "insert into [dbo].[bill] values (@code, @name, @customer_code, @staff_code, @lock_code" +
                         " , @electronic_price_code, @status, @created_at, @updated_at)";
            conn = new SqlConnection(url);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@code", hd.Mahd);
            cmd.Parameters.AddWithValue("@status", hd.Tt);
            cmd.Parameters.AddWithValue("@name",hd.Tenhd);
            cmd.Parameters.AddWithValue("@customer_code", hd.Makh);
            cmd.Parameters.AddWithValue("@staff_code", hd.Manv);
            cmd.Parameters.AddWithValue("@lock_code", hd.Madh);
            cmd.Parameters.AddWithValue("@electronic_price_code", hd.Mabg);
            cmd.Parameters.AddWithValue("@created_at", hd.Ngaytao);
            cmd.Parameters.AddWithValue("@updated_at", hd.Ngaycapnhat);

            int check = cmd.ExecuteNonQuery();

            if (check != 0)
            {
                MessageBox.Show("Thêm thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            QuanLyHoaDon_Load(sender, e);

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text.Trim() == "")
            {
                MessageBox.Show("Mã hoá đơn không được để trống", "Error", MessageBoxButtons.OK);
                return;
            }
            if (txtMaKH.Text.Trim() == "")
            {
                MessageBox.Show("Mã khách hàng không được để trống", "Error", MessageBoxButtons.OK);
                return;
            }
            if (txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được để trống", "Error", MessageBoxButtons.OK);
                return;
            }
            if (txtTenHD.Text.Trim() == "")
            {
                MessageBox.Show("Tên hoá đơn không được để trống", "Error", MessageBoxButtons.OK);
                return;
            }
            if (txtMaDH.Text.Trim() == "")
            {
                MessageBox.Show("Mã đồng hồ không được để trống", "Error", MessageBoxButtons.OK);
                return;
            }
            if (txtMaGiaDien.Text.Trim() == "")
            {
                MessageBox.Show("Mã giá điện không được để trống", "Error", MessageBoxButtons.OK);
                return;
            }
            //check lỗi trùng
            if (!checkMaHD(txtMaHD.Text.Trim()))
            {
                MessageBox.Show("Mã hoá đơn không tồn tại", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!checkMaKH(txtMaKH.Text.Trim()))
            {
                MessageBox.Show("Mã khách hàng không tồn tại", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!checkMaNV(txtMaNV.Text.Trim()))
            {
                MessageBox.Show("Mã đồng hồ không tồn tại", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!checkMaBangGiaDien(txtMaGiaDien.Text.Trim()))
            {
                MessageBox.Show("Mã giá điện không tồn tại", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!checkMaDH(txtMaDH.Text.Trim()))
            {
                MessageBox.Show("Mã đồng hồ không tồn tại", "Error", MessageBoxButtons.OK);
                return;
            }

            string maHD = txtMaHD.Text.Trim();
            string tenHD = txtTenHD.Text.Trim();
            string maKH = txtMaKH.Text.Trim();
            string maNV = txtMaNV.Text.Trim();
            string maDH = txtMaDH.Text.Trim();
            string maGD = txtMaGiaDien.Text.Trim();
            hd = new HOADON(maHD, tenHD, maKH, maNV, maDH, maGD, 1, cof.final_date(), cof.final_date());
            string sql = "update bill set  name = @name, customer_code =@customer_code, staff_code =@staff_code, lock_code=@lock_code" +
                ", electronic_price_code = @electronic_price_code, status=@status, updated_at=@updated_at where code = @code";
            conn = new SqlConnection(url);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@code", hd.Mahd);
            cmd.Parameters.AddWithValue("@status", hd.Tt);
            cmd.Parameters.AddWithValue("@name", hd.Tenhd);
            cmd.Parameters.AddWithValue("@customer_code", hd.Makh);
            cmd.Parameters.AddWithValue("@staff_code", hd.Manv);
            cmd.Parameters.AddWithValue("@lock_code", hd.Madh);
            cmd.Parameters.AddWithValue("@electronic_price_code", hd.Mabg);
            cmd.Parameters.AddWithValue("@updated_at", hd.Ngaycapnhat);

            int check = cmd.ExecuteNonQuery();

            if (check != 0)
            {
                MessageBox.Show("Sửa thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Sửa thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            QuanLyHoaDon_Load(sender, e);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text.Trim() == "")
            {
                MessageBox.Show("Mã hoá đơn không được để trống", "Error", MessageBoxButtons.OK);
                return;
            }
           
            //check lỗi trùng
            if (!checkMaHD(txtMaHD.Text.Trim()))
            {
                MessageBox.Show("Mã hoá đơn không tồn tại", "Error", MessageBoxButtons.OK);
                return;
            }
           

            string maHD = txtMaHD.Text.Trim();
            string tenHD = txtTenHD.Text.Trim();
            string maKH = txtMaKH.Text.Trim();
            string maNV = txtMaNV.Text.Trim();
            string maDH = txtMaDH.Text.Trim();
            string maGD = txtMaGiaDien.Text.Trim();
            HOADON hdXoa = new HOADON(maHD, tenHD, maKH, maNV, maDH, maGD, 1, cof.final_date(), cof.final_date());
            string sql = "delete bill where code = @code";
            conn = new SqlConnection(url);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@code", hdXoa.Mahd);
            int check = 0;
            DialogResult result = MessageBox.Show("Bạn có muốn thoát", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                check = cmd.ExecuteNonQuery();
            }
            

            if (check != 0)
            {
                MessageBox.Show("Xoá thành công!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Xoá thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            QuanLyHoaDon_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            new InHoaDon().Show();
            this.Close();
        }
    }
}
