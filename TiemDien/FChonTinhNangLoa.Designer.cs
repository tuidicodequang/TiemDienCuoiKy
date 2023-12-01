namespace TiemDien
{
    partial class FChonTinhNangLoa
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
            this.label3 = new System.Windows.Forms.Label();
            this.textChatLieu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textTanSo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textKetNoi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(65, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 52;
            this.label3.Text = "Chất Liệu";
            // 
            // textChatLieu
            // 
            this.textChatLieu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textChatLieu.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textChatLieu.Location = new System.Drawing.Point(215, 24);
            this.textChatLieu.Name = "textChatLieu";
            this.textChatLieu.Size = new System.Drawing.Size(225, 27);
            this.textChatLieu.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(65, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 54;
            this.label1.Text = "Tần Số";
            // 
            // textTanSo
            // 
            this.textTanSo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textTanSo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textTanSo.Location = new System.Drawing.Point(215, 81);
            this.textTanSo.Name = "textTanSo";
            this.textTanSo.Size = new System.Drawing.Size(225, 27);
            this.textTanSo.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(65, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 56;
            this.label2.Text = "Kết Nối";
            // 
            // textKetNoi
            // 
            this.textKetNoi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textKetNoi.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textKetNoi.Location = new System.Drawing.Point(215, 140);
            this.textKetNoi.Name = "textKetNoi";
            this.textKetNoi.Size = new System.Drawing.Size(225, 27);
            this.textKetNoi.TabIndex = 55;
            // 
            // FChonTinhNangLoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 283);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textKetNoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textTanSo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textChatLieu);
            this.Name = "FChonTinhNangLoa";
            this.Text = "FChonTinhNangLoa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textChatLieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textTanSo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textKetNoi;
    }
}