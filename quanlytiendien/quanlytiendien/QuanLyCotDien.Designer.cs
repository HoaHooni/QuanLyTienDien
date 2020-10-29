namespace quanlytiendien
{
    partial class QuanLyCotDien
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
            this.dtgquanlycotdien = new System.Windows.Forms.DataGridView();
            this.btllayds = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.cmbtrangthai = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtmota = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtvitri = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmatram = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmacot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdongho = new System.Windows.Forms.TextBox();
            this.btnthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgquanlycotdien)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgquanlycotdien
            // 
            this.dtgquanlycotdien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgquanlycotdien.Location = new System.Drawing.Point(28, 395);
            this.dtgquanlycotdien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgquanlycotdien.Name = "dtgquanlycotdien";
            this.dtgquanlycotdien.RowHeadersWidth = 51;
            this.dtgquanlycotdien.RowTemplate.Height = 24;
            this.dtgquanlycotdien.Size = new System.Drawing.Size(972, 283);
            this.dtgquanlycotdien.StandardTab = true;
            this.dtgquanlycotdien.TabIndex = 35;
            this.dtgquanlycotdien.TabStop = false;
            this.dtgquanlycotdien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgquanlycotdien_CellClick);
            // 
            // btllayds
            // 
            this.btllayds.BackColor = System.Drawing.Color.RoyalBlue;
            this.btllayds.Location = new System.Drawing.Point(659, 293);
            this.btllayds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btllayds.Name = "btllayds";
            this.btllayds.Size = new System.Drawing.Size(108, 50);
            this.btllayds.TabIndex = 12;
            this.btllayds.Text = "Lấy danh sách";
            this.btllayds.UseVisualStyleBackColor = false;
            this.btllayds.Click += new System.EventHandler(this.btllayds_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnxoa.Location = new System.Drawing.Point(513, 293);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(108, 50);
            this.btnxoa.TabIndex = 11;
            this.btnxoa.Text = "Xoá";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnsua.Location = new System.Drawing.Point(348, 293);
            this.btnsua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(108, 50);
            this.btnsua.TabIndex = 10;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnthem.Location = new System.Drawing.Point(184, 293);
            this.btnthem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(108, 50);
            this.btnthem.TabIndex = 9;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // cmbtrangthai
            // 
            this.cmbtrangthai.FormattingEnabled = true;
            this.cmbtrangthai.Items.AddRange(new object[] {
            "Hoạt động",
            "Bảo trì",
            "Ngừng hoạt động"});
            this.cmbtrangthai.Location = new System.Drawing.Point(673, 171);
            this.cmbtrangthai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbtrangthai.Name = "cmbtrangthai";
            this.cmbtrangthai.Size = new System.Drawing.Size(168, 24);
            this.cmbtrangthai.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(525, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Trạng thái";
            // 
            // txtmota
            // 
            this.txtmota.Location = new System.Drawing.Point(289, 170);
            this.txtmota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(168, 22);
            this.txtmota.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(181, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Mô tả";
            // 
            // txtvitri
            // 
            this.txtvitri.Location = new System.Drawing.Point(289, 135);
            this.txtvitri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtvitri.Name = "txtvitri";
            this.txtvitri.Size = new System.Drawing.Size(168, 22);
            this.txtvitri.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Vị trí cột điện";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Số lượng đồng hồ";
            // 
            // txtmatram
            // 
            this.txtmatram.Location = new System.Drawing.Point(675, 94);
            this.txtmatram.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmatram.Name = "txtmatram";
            this.txtmatram.Size = new System.Drawing.Size(168, 22);
            this.txtmatram.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mã trạm điện";
            // 
            // txtmacot
            // 
            this.txtmacot.Enabled = false;
            this.txtmacot.Location = new System.Drawing.Point(289, 94);
            this.txtmacot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmacot.Name = "txtmacot";
            this.txtmacot.Size = new System.Drawing.Size(168, 22);
            this.txtmacot.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mã cột điện";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Quản lý cột điện";
            // 
            // txtdongho
            // 
            this.txtdongho.Location = new System.Drawing.Point(673, 132);
            this.txtdongho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdongho.Name = "txtdongho";
            this.txtdongho.Size = new System.Drawing.Size(168, 22);
            this.txtdongho.TabIndex = 5;
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnthoat.Location = new System.Drawing.Point(808, 293);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(108, 50);
            this.btnthoat.TabIndex = 12;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // QuanLyCotDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 722);
            this.Controls.Add(this.dtgquanlycotdien);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btllayds);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.cmbtrangthai);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtmota);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtvitri);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdongho);
            this.Controls.Add(this.txtmatram);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmacot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuanLyCotDien";
            this.Text = "QuanLyCotDien";
            this.Load += new System.EventHandler(this.QuanLyCotDien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgquanlycotdien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgquanlycotdien;
        private System.Windows.Forms.Button btllayds;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.ComboBox cmbtrangthai;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtmota;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtvitri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmatram;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmacot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdongho;
        private System.Windows.Forms.Button btnthoat;
    }
}