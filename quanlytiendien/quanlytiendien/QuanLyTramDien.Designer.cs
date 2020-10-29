namespace quanlytiendien
{
    partial class QuanLyTramDien
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
            this.txtmahd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtvitri = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtslcot = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmota = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbtt = new System.Windows.Forms.ComboBox();
            this.dtgquanlytram = new System.Windows.Forms.DataGridView();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnlayds = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgquanlytram)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã trạm";
            // 
            // txtmahd
            // 
            this.txtmahd.Enabled = false;
            this.txtmahd.Location = new System.Drawing.Point(172, 41);
            this.txtmahd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmahd.Name = "txtmahd";
            this.txtmahd.Size = new System.Drawing.Size(224, 22);
            this.txtmahd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vị trí";
            // 
            // txtvitri
            // 
            this.txtvitri.Location = new System.Drawing.Point(568, 41);
            this.txtvitri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtvitri.Name = "txtvitri";
            this.txtvitri.Size = new System.Drawing.Size(224, 22);
            this.txtvitri.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số lượng cột";
            // 
            // txtslcot
            // 
            this.txtslcot.Location = new System.Drawing.Point(172, 96);
            this.txtslcot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtslcot.Name = "txtslcot";
            this.txtslcot.Size = new System.Drawing.Size(224, 22);
            this.txtslcot.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "mô tả";
            // 
            // txtmota
            // 
            this.txtmota.Location = new System.Drawing.Point(568, 96);
            this.txtmota.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(224, 22);
            this.txtmota.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Trạng thái";
            // 
            // cmbtt
            // 
            this.cmbtt.FormattingEnabled = true;
            this.cmbtt.Items.AddRange(new object[] {
            "Đang hoạt động",
            "Bảo trì",
            "Ngừng hoạt động"});
            this.cmbtt.Location = new System.Drawing.Point(172, 166);
            this.cmbtt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbtt.Name = "cmbtt";
            this.cmbtt.Size = new System.Drawing.Size(224, 24);
            this.cmbtt.TabIndex = 3;
            this.cmbtt.Text = "Đang hoạt động";
            // 
            // dtgquanlytram
            // 
            this.dtgquanlytram.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgquanlytram.Location = new System.Drawing.Point(63, 270);
            this.dtgquanlytram.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgquanlytram.Name = "dtgquanlytram";
            this.dtgquanlytram.RowHeadersWidth = 51;
            this.dtgquanlytram.Size = new System.Drawing.Size(731, 185);
            this.dtgquanlytram.StandardTab = true;
            this.dtgquanlytram.TabIndex = 3;
            this.dtgquanlytram.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgquanlytram_CellClick);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(172, 222);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(125, 28);
            this.btnthem.TabIndex = 7;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(319, 222);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(125, 28);
            this.btnsua.TabIndex = 8;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(481, 222);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(125, 28);
            this.btnxoa.TabIndex = 9;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(644, 222);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(125, 28);
            this.btnthoat.TabIndex = 10;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnlayds
            // 
            this.btnlayds.Location = new System.Drawing.Point(16, 222);
            this.btnlayds.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlayds.Name = "btnlayds";
            this.btnlayds.Size = new System.Drawing.Size(125, 28);
            this.btnlayds.TabIndex = 6;
            this.btnlayds.Text = "Lấy danh sách";
            this.btnlayds.UseVisualStyleBackColor = true;
            this.btnlayds.Click += new System.EventHandler(this.btnlayds_Click);
            // 
            // QuanLyTramDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 492);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnlayds);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dtgquanlytram);
            this.Controls.Add(this.cmbtt);
            this.Controls.Add(this.txtmota);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtvitri);
            this.Controls.Add(this.txtslcot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmahd);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "QuanLyTramDien";
            this.Text = "s";
            this.Load += new System.EventHandler(this.QuanLyTramDien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgquanlytram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmahd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtvitri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtslcot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbtt;
        private System.Windows.Forms.DataGridView dtgquanlytram;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnlayds;
    }
}