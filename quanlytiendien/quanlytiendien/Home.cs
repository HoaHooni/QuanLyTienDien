using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlytiendien
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            labMaNV.Text = DangNhap.username.Trim();
        }
        //creted by Dung
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            new DangNhap().Show();
            this.Hide();
        }

        private void btntieptuc_Click(object sender, EventArgs e)
        {

            try
            {
                if (cmbquanlygiaodich.SelectedIndex != 0 && cmbthongke.SelectedIndex  == 1)
                {
                    new ThongKe().Show();
                    this.Hide();
                }
                if (cmbquanlygiaodich.SelectedIndex != 0 && cmbthongke.SelectedIndex == 2)
                {
                    new ThongKe().Show();
                    this.Hide();
                }
                if (cmbquanlygiaodich.SelectedIndex == 1 && cmbthongke.SelectedIndex != 0)
                {
                    new QuanLyDongHo().Show();
                    this.Hide();
                }
                if (cmbquanlygiaodich.SelectedIndex == 2 && cmbthongke.SelectedIndex != 0)
                {
                    new QuanLyNhanVien().Show();
                    this.Hide();
                }
                if (cmbquanlygiaodich.SelectedIndex == 3 && cmbthongke.SelectedIndex != 0)
                {
                    new QuanLyKhachHang().Show();
                    this.Hide();
                }
                if (cmbquanlygiaodich.SelectedIndex == 4 && cmbthongke.SelectedIndex != 0)
                {
                    new QuanLyBangGiaDien().Show();
                    this.Hide();
                }
                if (cmbquanlygiaodich.SelectedIndex == 5 && cmbthongke.SelectedIndex != 0)
                {
                    new QuanLyTramDien().Show();
                    this.Hide();
                }
                if (cmbquanlygiaodich.SelectedIndex == 6 && cmbthongke.SelectedIndex != 0)
                {
                    new QuanLyCotDien().Show();
                    this.Hide();
                }
                if (cmbquanlygiaodich.SelectedIndex == 7 && cmbthongke.SelectedIndex != 0)
                {
                    new QuanLyHoaDon().Show();
                    this.Hide();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("có lỗi chi tiết " + ex.Message.ToString());
            }
            

        }
    }
}
