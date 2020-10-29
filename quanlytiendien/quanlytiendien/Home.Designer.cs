namespace quanlytiendien
{
    partial class Home
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
            this.cmbquanlygiaodich = new System.Windows.Forms.ComboBox();
            this.cmbthongke = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btntieptuc = new System.Windows.Forms.Button();
            this.labMaNV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbquanlygiaodich
            // 
            this.cmbquanlygiaodich.FormattingEnabled = true;
            this.cmbquanlygiaodich.Items.AddRange(new object[] {
            "",
            "Quản lý đồng hồ",
            "Quản lý nhân viên",
            "Quản lý khách hàng",
            "Quản lý bảng giá điện",
            "Quản lý trạm",
            "Quản lý cột",
            "Quản lý hoá đơn"});
            this.cmbquanlygiaodich.Location = new System.Drawing.Point(120, 78);
            this.cmbquanlygiaodich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbquanlygiaodich.Name = "cmbquanlygiaodich";
            this.cmbquanlygiaodich.Size = new System.Drawing.Size(163, 24);
            this.cmbquanlygiaodich.TabIndex = 0;
            // 
            // cmbthongke
            // 
            this.cmbthongke.FormattingEnabled = true;
            this.cmbthongke.Items.AddRange(new object[] {
            "",
            "Thống kê theo trạm",
            "Thống kê theo thời gian"});
            this.cmbthongke.Location = new System.Drawing.Point(416, 78);
            this.cmbthongke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbthongke.Name = "cmbthongke";
            this.cmbthongke.Size = new System.Drawing.Size(176, 24);
            this.cmbthongke.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản lý giao dịch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thống kê";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 182);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btntieptuc
            // 
            this.btntieptuc.AutoEllipsis = true;
            this.btntieptuc.Location = new System.Drawing.Point(205, 182);
            this.btntieptuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btntieptuc.Name = "btntieptuc";
            this.btntieptuc.Size = new System.Drawing.Size(128, 39);
            this.btntieptuc.TabIndex = 4;
            this.btntieptuc.Text = "Tiếp tục";
            this.btntieptuc.UseVisualStyleBackColor = true;
            this.btntieptuc.Click += new System.EventHandler(this.btntieptuc_Click);
            // 
            // labMaNV
            // 
            this.labMaNV.AutoSize = true;
            this.labMaNV.Location = new System.Drawing.Point(545, 13);
            this.labMaNV.Name = "labMaNV";
            this.labMaNV.Size = new System.Drawing.Size(46, 17);
            this.labMaNV.TabIndex = 5;
            this.labMaNV.Text = "label3";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 295);
            this.Controls.Add(this.labMaNV);
            this.Controls.Add(this.btntieptuc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbthongke);
            this.Controls.Add(this.cmbquanlygiaodich);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbquanlygiaodich;
        private System.Windows.Forms.ComboBox cmbthongke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btntieptuc;
        private System.Windows.Forms.Label labMaNV;
    }
}