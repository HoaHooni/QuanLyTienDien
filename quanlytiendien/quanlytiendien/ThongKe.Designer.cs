namespace quanlytiendien
{
    partial class ThongKe
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
            this.btntram = new System.Windows.Forms.Button();
            this.btntg = new System.Windows.Forms.Button();
            this.dtgthongke = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgthongke)).BeginInit();
            this.SuspendLayout();
            // 
            // btntram
            // 
            this.btntram.Location = new System.Drawing.Point(151, 70);
            this.btntram.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btntram.Name = "btntram";
            this.btntram.Size = new System.Drawing.Size(188, 28);
            this.btntram.TabIndex = 0;
            this.btntram.Text = "Thống kê trạm";
            this.btntram.UseVisualStyleBackColor = true;
            this.btntram.Click += new System.EventHandler(this.btntram_Click);
            // 
            // btntg
            // 
            this.btntg.Location = new System.Drawing.Point(387, 70);
            this.btntg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btntg.Name = "btntg";
            this.btntg.Size = new System.Drawing.Size(185, 28);
            this.btntg.TabIndex = 0;
            this.btntg.Text = "Thống kê thời gian";
            this.btntg.UseVisualStyleBackColor = true;
            this.btntg.Click += new System.EventHandler(this.btntg_Click);
            // 
            // dtgthongke
            // 
            this.dtgthongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgthongke.Location = new System.Drawing.Point(128, 174);
            this.dtgthongke.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgthongke.Name = "dtgthongke";
            this.dtgthongke.RowHeadersWidth = 51;
            this.dtgthongke.Size = new System.Drawing.Size(692, 185);
            this.dtgthongke.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(643, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 417);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgthongke);
            this.Controls.Add(this.btntg);
            this.Controls.Add(this.btntram);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            ((System.ComponentModel.ISupportInitialize)(this.dtgthongke)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btntram;
        private System.Windows.Forms.Button btntg;
        private System.Windows.Forms.DataGridView dtgthongke;
        private System.Windows.Forms.Button button1;
    }
}