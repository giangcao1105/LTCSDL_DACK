namespace GUI_demo
{
    partial class FThongKeHoaDon
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
            this.gbXemCTHD = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btTim_Ngay = new System.Windows.Forms.Button();
            this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.gbXemCTHD.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbXemCTHD
            // 
            this.gbXemCTHD.Controls.Add(this.label3);
            this.gbXemCTHD.Controls.Add(this.label4);
            this.gbXemCTHD.Controls.Add(this.btTim_Ngay);
            this.gbXemCTHD.Controls.Add(this.dtpNgayKT);
            this.gbXemCTHD.Controls.Add(this.dtpNgayBD);
            this.gbXemCTHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbXemCTHD.ForeColor = System.Drawing.Color.Red;
            this.gbXemCTHD.Location = new System.Drawing.Point(16, 16);
            this.gbXemCTHD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbXemCTHD.Name = "gbXemCTHD";
            this.gbXemCTHD.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbXemCTHD.Size = new System.Drawing.Size(628, 175);
            this.gbXemCTHD.TabIndex = 16;
            this.gbXemCTHD.TabStop = false;
            this.gbXemCTHD.Text = "Tính doanh thu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(49, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Đến ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(49, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Từ ngày";
            // 
            // btTim_Ngay
            // 
            this.btTim_Ngay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btTim_Ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTim_Ngay.ForeColor = System.Drawing.Color.Black;
            this.btTim_Ngay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTim_Ngay.Location = new System.Drawing.Point(459, 36);
            this.btTim_Ngay.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btTim_Ngay.Name = "btTim_Ngay";
            this.btTim_Ngay.Size = new System.Drawing.Size(144, 118);
            this.btTim_Ngay.TabIndex = 34;
            this.btTim_Ngay.Text = "Tìm";
            this.btTim_Ngay.UseVisualStyleBackColor = false;
            this.btTim_Ngay.Click += new System.EventHandler(this.btTim_Ngay_Click);
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKT.Location = new System.Drawing.Point(204, 108);
            this.dtpNgayKT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(203, 26);
            this.dtpNgayKT.TabIndex = 2;
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBD.Location = new System.Drawing.Point(204, 48);
            this.dtpNgayBD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(203, 26);
            this.dtpNgayBD.TabIndex = 2;
            // 
            // FThongKeHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 210);
            this.Controls.Add(this.gbXemCTHD);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FThongKeHoaDon";
            this.Text = "FThongKeHoaDon";
            this.gbXemCTHD.ResumeLayout(false);
            this.gbXemCTHD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbXemCTHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btTim_Ngay;
        private System.Windows.Forms.DateTimePicker dtpNgayKT;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
    }
}