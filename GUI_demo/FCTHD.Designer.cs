namespace GUI_demo
{
    partial class FCTHD
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
            this.dtgvCTHD = new System.Windows.Forms.DataGridView();
            this.lbBan = new System.Windows.Forms.Label();
            this.lbNgayLap = new System.Windows.Forms.Label();
            this.lbMaHD = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvCTHD
            // 
            this.dtgvCTHD.BackgroundColor = System.Drawing.Color.White;
            this.dtgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCTHD.Location = new System.Drawing.Point(11, 167);
            this.dtgvCTHD.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvCTHD.Name = "dtgvCTHD";
            this.dtgvCTHD.RowHeadersWidth = 51;
            this.dtgvCTHD.RowTemplate.Height = 24;
            this.dtgvCTHD.Size = new System.Drawing.Size(351, 224);
            this.dtgvCTHD.TabIndex = 7;
            // 
            // lbBan
            // 
            this.lbBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBan.Location = new System.Drawing.Point(214, 130);
            this.lbBan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBan.Name = "lbBan";
            this.lbBan.Size = new System.Drawing.Size(139, 24);
            this.lbBan.TabIndex = 4;
            this.lbBan.Text = "Bàn: ";
            // 
            // lbNgayLap
            // 
            this.lbNgayLap.AutoSize = true;
            this.lbNgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayLap.Location = new System.Drawing.Point(9, 130);
            this.lbNgayLap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNgayLap.Name = "lbNgayLap";
            this.lbNgayLap.Size = new System.Drawing.Size(89, 24);
            this.lbNgayLap.TabIndex = 5;
            this.lbNgayLap.Text = "Ngày lập:";
            // 
            // lbMaHD
            // 
            this.lbMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaHD.Location = new System.Drawing.Point(9, 106);
            this.lbMaHD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaHD.Name = "lbMaHD";
            this.lbMaHD.Size = new System.Drawing.Size(249, 24);
            this.lbMaHD.TabIndex = 6;
            this.lbMaHD.Text = "Mã hóa đơn: ";
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(374, 47);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "Chi tiết hóa đơn";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FCTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 399);
            this.Controls.Add(this.dtgvCTHD);
            this.Controls.Add(this.lbBan);
            this.Controls.Add(this.lbNgayLap);
            this.Controls.Add(this.lbMaHD);
            this.Controls.Add(this.lbTitle);
            this.Name = "FCTHD";
            this.Text = "FCTHD";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCTHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvCTHD;
        private System.Windows.Forms.Label lbBan;
        private System.Windows.Forms.Label lbNgayLap;
        private System.Windows.Forms.Label lbMaHD;
        private System.Windows.Forms.Label lbTitle;
    }
}