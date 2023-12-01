namespace TiemDien
{
    partial class FThemHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FThemHoaDon));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.ButtonDongY = new FontAwesome.Sharp.IconButton();
            this.textThanhTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textSDT = new System.Windows.Forms.TextBox();
            this.buttonThemSP = new System.Windows.Forms.Button();
            this.buttonTimSP = new System.Windows.Forms.Button();
            this.textGia = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.textTenSP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textMaSP = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textTenKH = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textMaKH = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textNgayGiaoDich = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.textMaHD = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textTongCong = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textTongCong);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonHuy);
            this.panel1.Controls.Add(this.ButtonDongY);
            this.panel1.Controls.Add(this.textThanhTien);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvSanPham);
            this.panel1.Controls.Add(this.textSDT);
            this.panel1.Controls.Add(this.buttonThemSP);
            this.panel1.Controls.Add(this.buttonTimSP);
            this.panel1.Controls.Add(this.textGia);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.numSoLuong);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textTenSP);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textMaSP);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.button2);
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
            this.panel1.Size = new System.Drawing.Size(1356, 610);
            this.panel1.TabIndex = 0;
            // 
            // buttonHuy
            // 
            this.buttonHuy.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonHuy.Image = ((System.Drawing.Image)(resources.GetObject("buttonHuy.Image")));
            this.buttonHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHuy.Location = new System.Drawing.Point(505, 556);
            this.buttonHuy.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(131, 42);
            this.buttonHuy.TabIndex = 87;
            this.buttonHuy.Text = "Hủy";
            this.buttonHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonHuy.UseVisualStyleBackColor = true;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // ButtonDongY
            // 
            this.ButtonDongY.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ButtonDongY.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.ButtonDongY.IconColor = System.Drawing.Color.DarkGreen;
            this.ButtonDongY.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.ButtonDongY.IconSize = 30;
            this.ButtonDongY.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonDongY.Location = new System.Drawing.Point(344, 556);
            this.ButtonDongY.Name = "ButtonDongY";
            this.ButtonDongY.Size = new System.Drawing.Size(131, 42);
            this.ButtonDongY.TabIndex = 86;
            this.ButtonDongY.Text = "Đồng ý";
            this.ButtonDongY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonDongY.UseVisualStyleBackColor = true;
            this.ButtonDongY.Click += new System.EventHandler(this.ButtonDongY_Click);
            // 
            // textThanhTien
            // 
            this.textThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textThanhTien.Location = new System.Drawing.Point(947, 574);
            this.textThanhTien.Name = "textThanhTien";
            this.textThanhTien.ReadOnly = true;
            this.textThanhTien.Size = new System.Drawing.Size(196, 27);
            this.textThanhTien.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(818, 518);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 84;
            this.label1.Text = "Tổng Cộng";
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.AllowUserToDeleteRows = false;
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerId,
            this.LastName,
            this.Sex,
            this.DateOfBirth,
            this.Address,
            this.Phone,
            this.Column1,
            this.password});
            this.dgvSanPham.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvSanPham.Location = new System.Drawing.Point(0, 275);
            this.dgvSanPham.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvSanPham.MultiSelect = false;
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(1356, 217);
            this.dgvSanPham.TabIndex = 83;
            // 
            // CustomerId
            // 
            this.CustomerId.DataPropertyName = "CustomerId";
            this.CustomerId.HeaderText = "ID Nhân Viên";
            this.CustomerId.MinimumWidth = 6;
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.ReadOnly = true;
            this.CustomerId.Visible = false;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Họ tên";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Visible = false;
            // 
            // Sex
            // 
            this.Sex.DataPropertyName = "Sex";
            this.Sex.HeaderText = "Giới tính";
            this.Sex.MinimumWidth = 6;
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            this.Sex.Visible = false;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.DataPropertyName = "DateOfBirth";
            this.DateOfBirth.HeaderText = "Ngày sinh";
            this.DateOfBirth.MinimumWidth = 6;
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            this.DateOfBirth.Visible = false;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Địa chỉ";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Visible = false;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Số Điện thoại";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tài khoản";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // password
            // 
            this.password.HeaderText = "Mật Khẩu";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Visible = false;
            // 
            // textSDT
            // 
            this.textSDT.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textSDT.Location = new System.Drawing.Point(1084, 64);
            this.textSDT.Name = "textSDT";
            this.textSDT.Size = new System.Drawing.Size(154, 27);
            this.textSDT.TabIndex = 82;
            this.textSDT.TextChanged += new System.EventHandler(this.textSDT_TextChanged);
            // 
            // buttonThemSP
            // 
            this.buttonThemSP.Location = new System.Drawing.Point(913, 208);
            this.buttonThemSP.Name = "buttonThemSP";
            this.buttonThemSP.Size = new System.Drawing.Size(183, 54);
            this.buttonThemSP.TabIndex = 81;
            this.buttonThemSP.Text = "Thêm Sản Phẩm";
            this.buttonThemSP.UseVisualStyleBackColor = true;
            this.buttonThemSP.Click += new System.EventHandler(this.buttonThemSP_Click);
            // 
            // buttonTimSP
            // 
            this.buttonTimSP.Location = new System.Drawing.Point(913, 153);
            this.buttonTimSP.Name = "buttonTimSP";
            this.buttonTimSP.Size = new System.Drawing.Size(183, 41);
            this.buttonTimSP.TabIndex = 80;
            this.buttonTimSP.Text = "Tìm Sản Phẩm";
            this.buttonTimSP.UseVisualStyleBackColor = true;
            this.buttonTimSP.Click += new System.EventHandler(this.buttonTimSP_Click);
            // 
            // textGia
            // 
            this.textGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textGia.Location = new System.Drawing.Point(643, 208);
            this.textGia.Name = "textGia";
            this.textGia.ReadOnly = true;
            this.textGia.Size = new System.Drawing.Size(196, 27);
            this.textGia.TabIndex = 79;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label17.Location = new System.Drawing.Point(477, 215);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 19);
            this.label17.TabIndex = 78;
            this.label17.Text = "Đơn Giá";
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(643, 156);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(69, 22);
            this.numSoLuong.TabIndex = 77;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(477, 156);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 19);
            this.label8.TabIndex = 76;
            this.label8.Text = "Số Lượng";
            // 
            // textTenSP
            // 
            this.textTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textTenSP.Location = new System.Drawing.Point(204, 211);
            this.textTenSP.Name = "textTenSP";
            this.textTenSP.ReadOnly = true;
            this.textTenSP.Size = new System.Drawing.Size(196, 27);
            this.textTenSP.TabIndex = 75;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(15, 215);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 19);
            this.label10.TabIndex = 74;
            this.label10.Text = "Tên Sản Phẩm";
            // 
            // textMaSP
            // 
            this.textMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textMaSP.Location = new System.Drawing.Point(204, 156);
            this.textMaSP.Name = "textMaSP";
            this.textMaSP.ReadOnly = true;
            this.textMaSP.Size = new System.Drawing.Size(196, 27);
            this.textMaSP.TabIndex = 73;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(15, 163);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 19);
            this.label11.TabIndex = 72;
            this.label11.Text = "Mã Sản Phẩm";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1256, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 31);
            this.button2.TabIndex = 71;
            this.button2.Text = "Tìm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(909, 72);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 19);
            this.label12.TabIndex = 69;
            this.label12.Text = "Số Điện Thoại";
            // 
            // textTenKH
            // 
            this.textTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textTenKH.Location = new System.Drawing.Point(643, 92);
            this.textTenKH.Name = "textTenKH";
            this.textTenKH.ReadOnly = true;
            this.textTenKH.Size = new System.Drawing.Size(196, 27);
            this.textTenKH.TabIndex = 68;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(477, 99);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 19);
            this.label13.TabIndex = 67;
            this.label13.Text = "Tên Khách Hàng";
            // 
            // textMaKH
            // 
            this.textMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textMaKH.Location = new System.Drawing.Point(643, 40);
            this.textMaKH.Name = "textMaKH";
            this.textMaKH.ReadOnly = true;
            this.textMaKH.Size = new System.Drawing.Size(196, 27);
            this.textMaKH.TabIndex = 66;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.Location = new System.Drawing.Point(477, 47);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 19);
            this.label14.TabIndex = 65;
            this.label14.Text = "Mã Khách Hàng";
            // 
            // textNgayGiaoDich
            // 
            this.textNgayGiaoDich.CustomFormat = "dd/MM/yyyy";
            this.textNgayGiaoDich.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textNgayGiaoDich.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.textNgayGiaoDich.Location = new System.Drawing.Point(204, 99);
            this.textNgayGiaoDich.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textNgayGiaoDich.Name = "textNgayGiaoDich";
            this.textNgayGiaoDich.Size = new System.Drawing.Size(196, 27);
            this.textNgayGiaoDich.TabIndex = 64;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 23);
            this.label15.TabIndex = 63;
            this.label15.Text = "Ngày Giao Dịch";
            // 
            // textMaHD
            // 
            this.textMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textMaHD.Location = new System.Drawing.Point(204, 43);
            this.textMaHD.Name = "textMaHD";
            this.textMaHD.ReadOnly = true;
            this.textMaHD.Size = new System.Drawing.Size(196, 27);
            this.textMaHD.TabIndex = 62;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label16.Location = new System.Drawing.Point(13, 50);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 19);
            this.label16.TabIndex = 61;
            this.label16.Text = "Mã Hóa Đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(818, 575);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 88;
            this.label2.Text = "Thành tiền";
            // 
            // textTongCong
            // 
            this.textTongCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textTongCong.Location = new System.Drawing.Point(947, 514);
            this.textTongCong.Name = "textTongCong";
            this.textTongCong.ReadOnly = true;
            this.textTongCong.Size = new System.Drawing.Size(196, 27);
            this.textTongCong.TabIndex = 89;
            // 
            // FThemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 610);
            this.Controls.Add(this.panel1);
            this.Name = "FThemHoaDon";
            this.Text = "FThemHoaDon";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonThemSP;
        private System.Windows.Forms.Button buttonTimSP;
        private System.Windows.Forms.TextBox textGia;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textTenSP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textMaSP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textTenKH;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textMaKH;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker textNgayGiaoDich;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textMaHD;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textSDT;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.TextBox textThanhTien;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton ButtonDongY;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.TextBox textTongCong;
        private System.Windows.Forms.Label label2;
    }
}