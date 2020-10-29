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
using System.IO;

namespace quanlytiendien
{
    public partial class InHoaDon : Form
    {
        public InHoaDon()
        {
            InitializeComponent();
        }
        HOADON inHoaDon = QuanLyHoaDon.hd;
        private void label14_Click(object sender, EventArgs e)
        {

        }
        SqlConnection conn;
        String url = @"Data Source=DESKTOP-7VDPE8B\SQLEXPRESS;Initial Catalog=QUANLYTIENDIEN;Integrated Security=True";
        Config conf = new Config();

        public DONGHO getDongHo(String maDH)
        
        {
            DONGHO dongHo = new DONGHO();
            conn = new SqlConnection(url);
            try
            {

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                String sql = "Select * from Lock where code ='"+maDH +"'";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    String maDh = dr["code"].ToString();
                    String maCD = dr["power_poles_code"].ToString();
                    String nhaSX = dr["manufactor"].ToString();
                    String moTa = dr["description"].ToString();
                    int trangThai = int.Parse(dr["status"].ToString());
                    String ngayTao = dr["created_at"].ToString();
                    String ngayCapNhat = dr["updated_at"].ToString();
                    int chiSoTrc = int.Parse(dr["electronic_meter_before"].ToString());
                    int chiSoSau = int.Parse(dr["electronic_meter_after"].ToString());
                    dongHo = new DONGHO(maDh, maCD, nhaSX, moTa, trangThai, ngayTao, ngayCapNhat, chiSoTrc, chiSoSau);
                }
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dongHo;
        }
        public KHACHHANG getKhachHang(String maHD)
        {
            KHACHHANG kh = new KHACHHANG();
            conn = new SqlConnection(url);
            try
            {

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                String sql = "select * from customer where bill_code = '" + maHD + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                //cmd.ExecuteNonQuery();

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    String makh = dr["code"].ToString();
                    String tenkh = dr["name"].ToString();
                    int tuoi = int.Parse(dr["age"].ToString());
                    String gioitinh = dr["gender"].ToString();
                    String diachi = dr["location"].ToString();
                    String loaiKH = dr["type"].ToString();
                    String madh = dr["lock_code"].ToString();
                    String mahd = dr["bill_code"].ToString();
                    int trangthai = int.Parse(dr["status"].ToString());
                    String ngaytao = dr["created_at"].ToString();
                    String ngayupdate = dr["updated_at"].ToString();
                    kh = new KHACHHANG(makh, tenkh, tuoi, gioitinh, diachi, loaiKH, madh, mahd, trangthai, ngaytao, ngayupdate);
                    dr.Close();
                }
                if (conn.State == ConnectionState.Open)
                    conn.Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return kh;
   
        }
        public TRAMDIEN GetTRAMDIEN(string mahd)
        {
            TRAMDIEN tram = new TRAMDIEN();
            conn = new SqlConnection(url);
            try
            {

                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                String sql = "select tram.* from bill b " +
                    "join [dbo].[lock] l on b.lock_code = l.code " +
                    "join [dbo].[power_poles] cd on l.power_poles_code = cd.code " +
                    "join [dbo].[power_station] tram on cd.power_station_code = tram.code " +
                    "where b.code = '" + mahd.Trim() + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    String matram = dr["code"].ToString();
                    int trangthai = int.Parse(dr["status"].ToString());
                    String diachi = dr["location"].ToString();
                    int socotdien = int.Parse(dr["power_poles_amount"].ToString());
                    String mota = dr["description"].ToString();
                    String ngaytao = dr["created_at"].ToString();
                    String ngayupdate = dr["updated_at"].ToString();

                    tram = new TRAMDIEN(matram, trangthai, diachi, socotdien, mota, ngaytao, ngayupdate);
                    dr.Close();
                }
                if (conn.State == ConnectionState.Open)
                    conn.Close();
 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tram;
        }
        double tongTien = 0;
        private void InHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                labMaHD.Text = inHoaDon.Mahd;
                LabNgayUpdate.Text = conf.final_date();

                KHACHHANG kh = getKhachHang(inHoaDon.Mahd);

                labMaKH.Text = kh.Makh.Trim();
                labTenKH.Text = kh.Tenkh.Trim();
                labDiaChi.Text = kh.Diachi.Trim();
                labLoaiKH.Text = kh.Loaikh.Trim();

                TRAMDIEN tram = GetTRAMDIEN(inHoaDon.Mahd);
                DONGHO dongHo = getDongHo(inHoaDon.Madh);

                labMaDH.Text = inHoaDon.Madh.Trim();
                LabMaTram.Text = tram.Matram.Trim();
                LabMaNV.Text = DangNhap.username;
                labChiSoTrc.Text = dongHo.Sodientruoc.ToString();
                labChiSoSau.Text = dongHo.Sodiensau.ToString();

                int r = 0;
                dgvInHoaDon.Rows.Clear();
                int sum = dongHo.Sodiensau - dongHo.Sodientruoc;

                double thanhtien = 0;
                int sotrc = dongHo.Sodientruoc;
                int sosau = dongHo.Sodiensau;
                double[] dongia = { 2800, 3000, 3200, 3500, 4000 };
                int i = 0;
                dgvInHoaDon.Rows.Add();
                while (sum >= 0)
                {
                    if (sum <= 50)
                    {
                        dgvInHoaDon.Rows[r].Cells[0].Value = sotrc.ToString();
                        dgvInHoaDon.Rows[r].Cells[1].Value = sosau.ToString();
                        dgvInHoaDon.Rows[r].Cells[2].Value = sum.ToString();
                        dgvInHoaDon.Rows[r].Cells[3].Value = dongia[i];
                        thanhtien += sum * dongia[i];
                        tongTien += thanhtien;
                        dgvInHoaDon.Rows[r].Cells[4].Value = thanhtien.ToString();
                        break;
                    }
                    else
                    {
                        dgvInHoaDon.Rows[r].Cells[0].Value = sotrc.ToString();
                        sotrc = sotrc + 50;
                        sum -= 50;
                        dgvInHoaDon.Rows[r].Cells[1].Value = (sotrc).ToString();
                        dgvInHoaDon.Rows[r].Cells[2].Value = sum.ToString();
                        dgvInHoaDon.Rows[r].Cells[3].Value = dongia[i + 1];
                        thanhtien += 50 * dongia[i];
                        tongTien += thanhtien;
                        dgvInHoaDon.Rows[r].Cells[4].Value = thanhtien.ToString();
                        r++;
                    }
                }
                labTongTien.Text = tongTien.ToString();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String file = @"D:\ltwin\"+inHoaDon.Mahd+".text";
            KHACHHANG kh = getKhachHang(inHoaDon.Mahd);
            StreamWriter sw = new StreamWriter(file);
            sw.WriteLine("Hoá đơn tiền điện");
            sw.WriteLine("Mã hoá đơn:      ".PadRight(30) + inHoaDon.Mahd.PadRight(30));
            sw.WriteLine("Ngày lập hoá đơn:".PadRight(30) + conf.final_date().PadRight(30));
            sw.WriteLine("_____________________________________________________________________");

            sw.WriteLine();
            sw.WriteLine("Mã khách hàng:  ".PadRight(30) + kh.Makh.Trim().PadRight(30));
            sw.WriteLine("tên khách hàng: ".PadRight(30) + kh.Tenkh.Trim().PadRight(30));
            sw.WriteLine("Địa chỉ:        ".PadRight(30) + kh.Diachi.Trim().PadRight(30));
            sw.WriteLine("Loại:           ".PadRight(30) + kh.Loaikh.Trim().PadRight(30));
            sw.WriteLine("----------------------------------------------");
            TRAMDIEN tram = GetTRAMDIEN(inHoaDon.Mahd);
            DONGHO dongHo = getDongHo(inHoaDon.Madh);
            String name = DangNhap.username;
            labMaDH.Text = inHoaDon.Madh.Trim();
            LabMaTram.Text = tram.Matram.Trim();
            LabMaNV.Text = DangNhap.username;
            labChiSoTrc.Text = dongHo.Sodientruoc.ToString();
            labChiSoSau.Text = dongHo.Sodiensau.ToString();
            sw.WriteLine("Mã đồng hồ:  ".PadRight(30) + inHoaDon.Madh.Trim().PadRight(30));
            sw.WriteLine("Mã trạm:     ".PadRight(30) + tram.Matram.Trim().PadRight(30));
            sw.WriteLine("Nhân viên:   ".PadRight(30) + name.PadRight(30));
            sw.WriteLine("Chỉ số cũ:   ".PadRight(30) + dongHo.Sodientruoc.ToString().PadRight(30));
            sw.WriteLine("Chỉ số mới:  ".PadRight(30) + dongHo.Sodiensau.ToString().PadRight(30));
            sw.WriteLine("----------------------------------------------");
            sw.WriteLine();
            sw.WriteLine("số cũ".PadRight(20) + "Số mới".PadRight(20) + "Tổng số điện".PadRight(20) + "Đơn giá".PadRight(20)
                + "Thành tiền".PadRight(20));
                int r = dgvInHoaDon.Rows.Count;
            int sum = 0;
            for (int i= 0; i < r; i++){
                sw.WriteLine(dgvInHoaDon.Rows[i].Cells[0].Value.ToString().PadRight(20)
                    + dgvInHoaDon.Rows[i].Cells[1].Value.ToString().PadRight(20)
                    + dgvInHoaDon.Rows[i].Cells[2].Value.ToString().PadRight(20) 
                    + dgvInHoaDon.Rows[i].Cells[3].Value.ToString().PadRight(20)
                    + dgvInHoaDon.Rows[i].Cells[4].Value.ToString().PadRight(20));
                sum += int.Parse(dgvInHoaDon.Rows[i].Cells[4].Value.ToString());
            }
            sw.WriteLine("Tổng tiền:".PadRight(50) + sum.ToString().PadRight(15));
            sw.WriteLine("_____________________________________________________________________");

            sw.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new QuanLyHoaDon().Show();
            this.Hide();
        }
    }
}
