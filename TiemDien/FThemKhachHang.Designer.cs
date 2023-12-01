namespace TiemDien
{
    partial class FThemKhachHang
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
            this.button1 = new System.Windows.Forms.Button();
            this.textNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.ButtonLuu = new System.Windows.Forms.Button();
            this.txtDiaChiNV = new System.Windows.Forms.TextBox();
            this.textSDT = new System.Windows.Forms.TextBox();
            this.textHoTen = new System.Windows.Forms.TextBox();
            this.TickNu = new System.Windows.Forms.RadioButton();
            this.TickNam = new System.Windows.Forms.RadioButton();
            this.textMAKH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textLoaiKH = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(993, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 33);
            this.button1.TabIndex = 48;
            this.button1.Text = "Hủy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textNgaySinh
            // 
            this.textNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.textNgaySinh.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.textNgaySinh.Location = new System.Drawing.Point(310, 357);
            this.textNgaySinh.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textNgaySinh.Name = "textNgaySinh";
            this.textNgaySinh.Size = new System.Drawing.Size(196, 27);
            this.textNgaySinh.TabIndex = 45;
            // 
            // ButtonLuu
            // 
            this.ButtonLuu.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ButtonLuu.Location = new System.Drawing.Point(800, 311);
            this.ButtonLuu.Name = "ButtonLuu";
            this.ButtonLuu.Size = new System.Drawing.Size(114, 33);
            this.ButtonLuu.TabIndex = 44;
            this.ButtonLuu.Text = "Lưu";
            this.ButtonLuu.UseVisualStyleBackColor = true;
            this.ButtonLuu.Click += new System.EventHandler(this.ButtonLuu_Click);
            // 
            // txtDiaChiNV
            // 
            this.txtDiaChiNV.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiaChiNV.Location = new System.Drawing.Point(303, 433);
            this.txtDiaChiNV.Name = "txtDiaChiNV";
            this.txtDiaChiNV.Size = new System.Drawing.Size(249, 27);
            this.txtDiaChiNV.TabIndex = 40;
            // 
            // textSDT
            // 
            this.textSDT.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textSDT.Location = new System.Drawing.Point(883, 138);
            this.textSDT.Name = "textSDT";
            this.textSDT.Size = new System.Drawing.Size(249, 27);
            this.textSDT.TabIndex = 41;
            // 
            // textHoTen
            // 
            this.textHoTen.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textHoTen.Location = new System.Drawing.Point(310, 207);
            this.textHoTen.Name = "textHoTen";
            this.textHoTen.Size = new System.Drawing.Size(241, 27);
            this.textHoTen.TabIndex = 37;
            // 
            // TickNu
            // 
            this.TickNu.AutoSize = true;
            this.TickNu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TickNu.Location = new System.Drawing.Point(476, 290);
            this.TickNu.Name = "TickNu";
            this.TickNu.Size = new System.Drawing.Size(54, 27);
            this.TickNu.TabIndex = 39;
            this.TickNu.TabStop = true;
            this.TickNu.Text = "Nữ";
            this.TickNu.UseVisualStyleBackColor = true;
            // 
            // TickNam
            // 
            this.TickNam.AutoSize = true;
            this.TickNam.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TickNam.Location = new System.Drawing.Point(310, 290);
            this.TickNam.Name = "TickNam";
            this.TickNam.Size = new System.Drawing.Size(68, 27);
            this.TickNam.TabIndex = 38;
            this.TickNam.TabStop = true;
            this.TickNam.Text = "Nam";
            this.TickNam.UseVisualStyleBackColor = true;
            // 
            // textMAKH
            // 
            this.textMAKH.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textMAKH.Location = new System.Drawing.Point(310, 134);
            this.textMAKH.Name = "textMAKH";
            this.textMAKH.Size = new System.Drawing.Size(241, 27);
            this.textMAKH.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(133, 433);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 23);
            this.label9.TabIndex = 35;
            this.label9.Text = "Địa Chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(709, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 23);
            this.label8.TabIndex = 34;
            this.label8.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(133, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 23);
            this.label6.TabIndex = 32;
            this.label6.Text = "Giới Tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(133, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 31;
            this.label5.Text = "Năm Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "Mã Khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Họ Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(490, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 38);
            this.label1.TabIndex = 27;
            this.label1.Text = "Thêm Khách Hàng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(709, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 23);
            this.label10.TabIndex = 47;
            this.label10.Text = "Loại khách hàng";
            // 
            // textLoaiKH
            // 
            this.textLoaiKH.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textLoaiKH.FormattingEnabled = true;
            this.textLoaiKH.Items.AddRange(new object[] {
            "VIP",
            "Thường"});
            this.textLoaiKH.Location = new System.Drawing.Point(883, 211);
            this.textLoaiKH.Name = "textLoaiKH";
            this.textLoaiKH.Size = new System.Drawing.Size(241, 27);
            this.textLoaiKH.TabIndex = 49;
            // 
            // FThemKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 484);
            this.Controls.Add(this.textLoaiKH);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textNgaySinh);
            this.Controls.Add(this.ButtonLuu);
            this.Controls.Add(this.txtDiaChiNV);
            this.Controls.Add(this.textSDT);
            this.Controls.Add(this.textHoTen);
            this.Controls.Add(this.TickNu);
            this.Controls.Add(this.TickNam);
            this.Controls.Add(this.textMAKH);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FThemKhachHang";
            this.Text = "FThemKhachHang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker textNgaySinh;
        private System.Windows.Forms.Button ButtonLuu;
        private System.Windows.Forms.TextBox txtDiaChiNV;
        private System.Windows.Forms.TextBox textSDT;
        private System.Windows.Forms.TextBox textHoTen;
        private System.Windows.Forms.RadioButton TickNu;
        private System.Windows.Forms.RadioButton TickNam;
        private System.Windows.Forms.TextBox textMAKH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox textLoaiKH;
    }
}