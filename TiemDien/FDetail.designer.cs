namespace TiemDien
{
    partial class FDetail
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
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.textTenKH = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textNgayGiaoDich = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.textMaHD = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textThanhTien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textSDT = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textMaKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textDiaChi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(298, 592);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 44);
            this.button3.TabIndex = 9;
            this.button3.Text = "Xuất file Excel";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(448, 591);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "In hóa đơn";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(441, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 38);
            this.label1.TabIndex = 10;
            this.label1.Text = "Chi tiết hóa đơn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Location = new System.Drawing.Point(3, 278);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.RowTemplate.Height = 24;
            this.dgvSanPham.Size = new System.Drawing.Size(1305, 259);
            this.dgvSanPham.TabIndex = 11;
            this.dgvSanPham.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvSanPham_MouseDoubleClick);
            // 
            // textTenKH
            // 
            this.textTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textTenKH.Location = new System.Drawing.Point(664, 182);
            this.textTenKH.Name = "textTenKH";
            this.textTenKH.ReadOnly = true;
            this.textTenKH.Size = new System.Drawing.Size(196, 27);
            this.textTenKH.TabIndex = 68;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(475, 189);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 19);
            this.label13.TabIndex = 67;
            this.label13.Text = "Tên Khách Hàng";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.Location = new System.Drawing.Point(465, 92);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 19);
            this.label14.TabIndex = 65;
            this.label14.Text = "Mã Khách Hàng";
            // 
            // textNgayGiaoDich
            // 
            this.textNgayGiaoDich.CustomFormat = "dd/MM/yyyy";
            this.textNgayGiaoDich.Enabled = false;
            this.textNgayGiaoDich.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textNgayGiaoDich.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.textNgayGiaoDich.Location = new System.Drawing.Point(196, 182);
            this.textNgayGiaoDich.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textNgayGiaoDich.Name = "textNgayGiaoDich";
            this.textNgayGiaoDich.Size = new System.Drawing.Size(196, 27);
            this.textNgayGiaoDich.TabIndex = 64;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(14, 186);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 23);
            this.label15.TabIndex = 63;
            this.label15.Text = "Ngày Giao Dịch";
            // 
            // textMaHD
            // 
            this.textMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textMaHD.Location = new System.Drawing.Point(196, 88);
            this.textMaHD.Name = "textMaHD";
            this.textMaHD.ReadOnly = true;
            this.textMaHD.Size = new System.Drawing.Size(196, 27);
            this.textMaHD.TabIndex = 62;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label16.Location = new System.Drawing.Point(14, 96);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 19);
            this.label16.TabIndex = 61;
            this.label16.Text = "Mã Hóa Đơn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textDiaChi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dgvSanPham);
            this.panel1.Controls.Add(this.textThanhTien);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textSDT);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.textTenKH);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.textMaKH);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.textNgayGiaoDich);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.textMaHD);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1308, 657);
            this.panel1.TabIndex = 12;
            // 
            // textThanhTien
            // 
            this.textThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textThanhTien.Location = new System.Drawing.Point(985, 591);
            this.textThanhTien.Name = "textThanhTien";
            this.textThanhTien.ReadOnly = true;
            this.textThanhTien.Size = new System.Drawing.Size(249, 27);
            this.textThanhTien.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(826, 592);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 84;
            this.label2.Text = "Tổng Cộng";
            // 
            // textSDT
            // 
            this.textSDT.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textSDT.Location = new System.Drawing.Point(1105, 100);
            this.textSDT.Name = "textSDT";
            this.textSDT.ReadOnly = true;
            this.textSDT.Size = new System.Drawing.Size(169, 27);
            this.textSDT.TabIndex = 82;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(936, 100);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 19);
            this.label12.TabIndex = 69;
            this.label12.Text = "Số Điện Thoại";
            // 
            // textMaKH
            // 
            this.textMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textMaKH.Location = new System.Drawing.Point(664, 88);
            this.textMaKH.Name = "textMaKH";
            this.textMaKH.ReadOnly = true;
            this.textMaKH.Size = new System.Drawing.Size(196, 27);
            this.textMaKH.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(936, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 86;
            this.label3.Text = "Địa chỉ";
            // 
            // textDiaChi
            // 
            this.textDiaChi.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textDiaChi.Location = new System.Drawing.Point(1105, 186);
            this.textDiaChi.Name = "textDiaChi";
            this.textDiaChi.ReadOnly = true;
            this.textDiaChi.Size = new System.Drawing.Size(169, 27);
            this.textDiaChi.TabIndex = 87;
            // 
            // FDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 657);
            this.Controls.Add(this.panel1);
            this.Name = "FDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem chi tiết";
            this.Load += new System.EventHandler(this.FDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel detailsPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.TextBox textTenKH;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker textNgayGiaoDich;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textMaHD;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textThanhTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSDT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textMaKH;
        private System.Windows.Forms.TextBox textDiaChi;
        private System.Windows.Forms.Label label3;
    }
}