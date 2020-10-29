namespace quanlytiendien
{
    partial class QuanLyBangGiaDien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaBangGia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cobLoaiBacT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtChiSoTruoc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtChiSoSau = new System.Windows.Forms.TextBox();
            this.dgvBangGiaDien = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cobLoaiKH = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangGiaDien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã bảng giá";
            // 
            // txtMaBangGia
            // 
            this.txtMaBangGia.Location = new System.Drawing.Point(188, 53);
            this.txtMaBangGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaBangGia.Name = "txtMaBangGia";
            this.txtMaBangGia.Size = new System.Drawing.Size(217, 22);
            this.txtMaBangGia.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại Khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(496, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại bậc thang";
            // 
            // cobLoaiBacT
            // 
            this.cobLoaiBacT.Location = new System.Drawing.Point(621, 117);
            this.cobLoaiBacT.Margin = new System.Windows.Forms.Padding(4);
            this.cobLoaiBacT.Name = "cobLoaiBacT";
            this.cobLoaiBacT.Size = new System.Drawing.Size(217, 22);
            this.cobLoaiBacT.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Chỉ số trước";
            // 
            // txtChiSoTruoc
            // 
            this.txtChiSoTruoc.Location = new System.Drawing.Point(188, 117);
            this.txtChiSoTruoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtChiSoTruoc.Name = "txtChiSoTruoc";
            this.txtChiSoTruoc.Size = new System.Drawing.Size(217, 22);
            this.txtChiSoTruoc.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 185);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Chỉ số sau";
            // 
            // txtChiSoSau
            // 
            this.txtChiSoSau.Location = new System.Drawing.Point(188, 185);
            this.txtChiSoSau.Margin = new System.Windows.Forms.Padding(4);
            this.txtChiSoSau.Name = "txtChiSoSau";
            this.txtChiSoSau.Size = new System.Drawing.Size(217, 22);
            this.txtChiSoSau.TabIndex = 4;
            // 
            // dgvBangGiaDien
            // 
            this.dgvBangGiaDien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangGiaDien.Location = new System.Drawing.Point(88, 250);
            this.dgvBangGiaDien.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBangGiaDien.Name = "dgvBangGiaDien";
            this.dgvBangGiaDien.RowHeadersWidth = 51;
            this.dgvBangGiaDien.Size = new System.Drawing.Size(751, 292);
            this.dgvBangGiaDien.StandardTab = true;
            this.dgvBangGiaDien.TabIndex = 2;
            this.dgvBangGiaDien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangGiaDien_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(427, 199);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(539, 199);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(647, 199);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 28);
            this.button3.TabIndex = 9;
            this.button3.Text = "Cập nhật";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(753, 199);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 28);
            this.button4.TabIndex = 10;
            this.button4.Text = "Thoát";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cobLoaiKH
            // 
            this.cobLoaiKH.FormattingEnabled = true;
            this.cobLoaiKH.Items.AddRange(new object[] {
            "Hộ gia đình",
            "Doanh nghiệp"});
            this.cobLoaiKH.Location = new System.Drawing.Point(621, 62);
            this.cobLoaiKH.Name = "cobLoaiKH";
            this.cobLoaiKH.Size = new System.Drawing.Size(218, 24);
            this.cobLoaiKH.TabIndex = 5;
            // 
            // QuanLyBangGiaDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 566);
            this.Controls.Add(this.cobLoaiKH);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvBangGiaDien);
            this.Controls.Add(this.txtChiSoSau);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cobLoaiBacT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtChiSoTruoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMaBangGia);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLyBangGiaDien";
            this.Text = "QuanLyBangGiaDien";
            this.Load += new System.EventHandler(this.QuanLyBangGiaDien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangGiaDien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaBangGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cobLoaiBacT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtChiSoTruoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtChiSoSau;
        private System.Windows.Forms.DataGridView dgvBangGiaDien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cobLoaiKH;
    }
}