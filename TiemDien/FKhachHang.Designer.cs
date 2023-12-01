﻿namespace TiemDien
{
    partial class FKhachHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textTimNV = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.textTimNV);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.dgvKH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1471, 713);
            this.panel1.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(570, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 30);
            this.button2.TabIndex = 23;
            this.button2.Text = "refesh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(635, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Khách Hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdate.Location = new System.Drawing.Point(1282, 170);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 30);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.Location = new System.Drawing.Point(1116, 170);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 30);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // textTimNV
            // 
            this.textTimNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textTimNV.Location = new System.Drawing.Point(51, 174);
            this.textTimNV.Name = "textTimNV";
            this.textTimNV.Size = new System.Drawing.Size(340, 27);
            this.textTimNV.TabIndex = 5;
            this.textTimNV.TextChanged += new System.EventHandler(this.textTimNV_TextChanged);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnInsert.Location = new System.Drawing.Point(931, 170);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(135, 30);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearch.Location = new System.Drawing.Point(408, 170);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(135, 30);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dgvKH
            // 
            this.dgvKH.AllowUserToAddRows = false;
            this.dgvKH.AllowUserToDeleteRows = false;
            this.dgvKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKH.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerId,
            this.LastName,
            this.Sex,
            this.DateOfBirth,
            this.Address,
            this.Phone,
            this.Column1,
            this.password});
            this.dgvKH.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvKH.Location = new System.Drawing.Point(0, 207);
            this.dgvKH.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvKH.MultiSelect = false;
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.ReadOnly = true;
            this.dgvKH.RowHeadersWidth = 51;
            this.dgvKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKH.Size = new System.Drawing.Size(1479, 506);
            this.dgvKH.TabIndex = 19;
            this.dgvKH.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvKH_MouseDoubleClick);
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
            // FKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 713);
            this.Controls.Add(this.panel1);
            this.Name = "FKhachHang";
            this.Text = "FKhachHang";
            this.Load += new System.EventHandler(this.FKhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox textTimNV;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.Button button2;
    }
}