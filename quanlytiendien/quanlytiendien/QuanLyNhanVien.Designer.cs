namespace quanlytiendien
{
    partial class QuanLyNhanVien
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
            this.rdnu = new System.Windows.Forms.RadioButton();
            this.rdnam = new System.Windows.Forms.RadioButton();
            this.btthoat = new System.Windows.Forms.Button();
            this.bttim = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.dgvnhanvien = new System.Windows.Forms.DataGridView();
            this.dtpcapnhat = new System.Windows.Forms.DateTimePicker();
            this.dtpngaytao = new System.Windows.Forms.DateTimePicker();
            this.cbxtrangthai = new System.Windows.Forms.ComboBox();
            this.cbxchucvu = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txttennv = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtgmail = new System.Windows.Forms.TextBox();
            this.txttuoi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // rdnu
            // 
            this.rdnu.AutoSize = true;
            this.rdnu.Location = new System.Drawing.Point(329, 185);
            this.rdnu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdnu.Name = "rdnu";
            this.rdnu.Size = new System.Drawing.Size(47, 21);
            this.rdnu.TabIndex = 5;
            this.rdnu.Text = "Nữ";
            this.rdnu.UseVisualStyleBackColor = true;
            // 
            // rdnam
            // 
            this.rdnam.AutoSize = true;
            this.rdnam.Checked = true;
            this.rdnam.Location = new System.Drawing.Point(252, 185);
            this.rdnam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdnam.Name = "rdnam";
            this.rdnam.Size = new System.Drawing.Size(58, 21);
            this.rdnam.TabIndex = 4;
            this.rdnam.TabStop = true;
            this.rdnam.Text = "Nam";
            this.rdnam.UseVisualStyleBackColor = true;
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(659, 306);
            this.btthoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(84, 47);
            this.btthoat.TabIndex = 18;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // bttim
            // 
            this.bttim.Location = new System.Drawing.Point(541, 306);
            this.bttim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttim.Name = "bttim";
            this.bttim.Size = new System.Drawing.Size(84, 47);
            this.bttim.TabIndex = 17;
            this.bttim.Text = "Tìm";
            this.bttim.UseVisualStyleBackColor = true;
            this.bttim.Click += new System.EventHandler(this.bttim_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(425, 306);
            this.btxoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(84, 47);
            this.btxoa.TabIndex = 16;
            this.btxoa.Text = "Xoá";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(304, 306);
            this.btsua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(84, 47);
            this.btsua.TabIndex = 15;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(171, 306);
            this.btthem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(84, 47);
            this.btthem.TabIndex = 14;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // dgvnhanvien
            // 
            this.dgvnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnhanvien.Location = new System.Drawing.Point(72, 382);
            this.dgvnhanvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvnhanvien.Name = "dgvnhanvien";
            this.dgvnhanvien.RowHeadersWidth = 51;
            this.dgvnhanvien.RowTemplate.Height = 24;
            this.dgvnhanvien.Size = new System.Drawing.Size(825, 290);
            this.dgvnhanvien.StandardTab = true;
            this.dgvnhanvien.TabIndex = 36;
            this.dgvnhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvnhanvien_CellClick);
            // 
            // dtpcapnhat
            // 
            this.dtpcapnhat.CustomFormat = "dd-MM-yyyy";
            this.dtpcapnhat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpcapnhat.Location = new System.Drawing.Point(608, 241);
            this.dtpcapnhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpcapnhat.Name = "dtpcapnhat";
            this.dtpcapnhat.Size = new System.Drawing.Size(156, 22);
            this.dtpcapnhat.TabIndex = 13;
            // 
            // dtpngaytao
            // 
            this.dtpngaytao.CustomFormat = "dd-MM-yyyy";
            this.dtpngaytao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpngaytao.Location = new System.Drawing.Point(608, 210);
            this.dtpngaytao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpngaytao.Name = "dtpngaytao";
            this.dtpngaytao.Size = new System.Drawing.Size(156, 22);
            this.dtpngaytao.TabIndex = 12;
            // 
            // cbxtrangthai
            // 
            this.cbxtrangthai.FormattingEnabled = true;
            this.cbxtrangthai.Items.AddRange(new object[] {
            "1",
            "3",
            "9"});
            this.cbxtrangthai.Location = new System.Drawing.Point(608, 182);
            this.cbxtrangthai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxtrangthai.Name = "cbxtrangthai";
            this.cbxtrangthai.Size = new System.Drawing.Size(156, 24);
            this.cbxtrangthai.TabIndex = 11;
            // 
            // cbxchucvu
            // 
            this.cbxchucvu.FormattingEnabled = true;
            this.cbxchucvu.Items.AddRange(new object[] {
            "Nhân viên",
            "Giám đốc",
            "Trưởng phòng",
            "Tổ Trưởng",
            "Phó giám đốc"});
            this.cbxchucvu.Location = new System.Drawing.Point(608, 153);
            this.cbxchucvu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxchucvu.Name = "cbxchucvu";
            this.cbxchucvu.Size = new System.Drawing.Size(156, 24);
            this.cbxchucvu.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(460, 242);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 20);
            this.label12.TabIndex = 30;
            this.label12.Text = "Ngày Cập nhật";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(460, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 20);
            this.label11.TabIndex = 31;
            this.label11.Text = "Ngày được tạo";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(252, 210);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(156, 22);
            this.txtdiachi.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(104, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Địa chỉ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(460, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "Trạng thái";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(104, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Giới tính";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(460, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Chức vụ";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(608, 128);
            this.txtpass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(156, 22);
            this.txtpass.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Tuổi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(460, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Password";
            // 
            // txttennv
            // 
            this.txttennv.Location = new System.Drawing.Point(252, 127);
            this.txttennv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttennv.Name = "txttennv";
            this.txttennv.Size = new System.Drawing.Size(156, 22);
            this.txttennv.TabIndex = 2;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(608, 100);
            this.txtusername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(156, 22);
            this.txtusername.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tên nhân viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(460, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "User name";
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(252, 98);
            this.txtmanv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(156, 22);
            this.txtmanv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Mã nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 36);
            this.label1.TabIndex = 19;
            this.label1.Text = "Quản lý nhân viên";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(104, 246);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "Gmail";
            // 
            // txtgmail
            // 
            this.txtgmail.Location = new System.Drawing.Point(252, 242);
            this.txtgmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtgmail.Name = "txtgmail";
            this.txtgmail.Size = new System.Drawing.Size(156, 22);
            this.txtgmail.TabIndex = 7;
            // 
            // txttuoi
            // 
            this.txttuoi.Location = new System.Drawing.Point(252, 154);
            this.txttuoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttuoi.Name = "txttuoi";
            this.txttuoi.Size = new System.Drawing.Size(156, 22);
            this.txttuoi.TabIndex = 3;
            // 
            // QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 734);
            this.Controls.Add(this.txttuoi);
            this.Controls.Add(this.rdnu);
            this.Controls.Add(this.rdnam);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.bttim);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.dgvnhanvien);
            this.Controls.Add(this.dtpcapnhat);
            this.Controls.Add(this.dtpngaytao);
            this.Controls.Add(this.cbxtrangthai);
            this.Controls.Add(this.cbxchucvu);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtgmail);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txttennv);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtmanv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuanLyNhanVien";
            this.Text = "QuanLyNhanVien";
            this.Load += new System.EventHandler(this.QuanLyNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdnu;
        private System.Windows.Forms.RadioButton rdnam;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button bttim;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.DataGridView dgvnhanvien;
        private System.Windows.Forms.DateTimePicker dtpcapnhat;
        private System.Windows.Forms.DateTimePicker dtpngaytao;
        private System.Windows.Forms.ComboBox cbxtrangthai;
        private System.Windows.Forms.ComboBox cbxchucvu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttennv;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtgmail;
        private System.Windows.Forms.TextBox txttuoi;
    }
}