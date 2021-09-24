namespace GUI_demo
{
    partial class FThanhToan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btthanhtoan = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txttongtien = new System.Windows.Forms.RichTextBox();
            this.groupBoxhd = new System.Windows.Forms.GroupBox();
            this.gv_hoadon = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxhd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_hoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Ivory;
            this.groupBox3.Controls.Add(this.btthanhtoan);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(733, 354);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(141, 103);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thanh toán";
            // 
            // btthanhtoan
            // 
            this.btthanhtoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btthanhtoan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btthanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btthanhtoan.Location = new System.Drawing.Point(8, 23);
            this.btthanhtoan.Margin = new System.Windows.Forms.Padding(4);
            this.btthanhtoan.Name = "btthanhtoan";
            this.btthanhtoan.Size = new System.Drawing.Size(125, 76);
            this.btthanhtoan.TabIndex = 4;
            this.btthanhtoan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btthanhtoan.UseVisualStyleBackColor = false;
            this.btthanhtoan.Click += new System.EventHandler(this.btthanhtoan_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Ivory;
            this.groupBox2.Controls.Add(this.txttongtien);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(20, 354);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(705, 103);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tổng Tiền (VNĐ)";
            // 
            // txttongtien
            // 
            this.txttongtien.BackColor = System.Drawing.Color.Azure;
            this.txttongtien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txttongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttongtien.Location = new System.Drawing.Point(4, 26);
            this.txttongtien.Margin = new System.Windows.Forms.Padding(4);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txttongtien.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txttongtien.Size = new System.Drawing.Size(697, 73);
            this.txttongtien.TabIndex = 1;
            this.txttongtien.Text = "";
            // 
            // groupBoxhd
            // 
            this.groupBoxhd.BackColor = System.Drawing.Color.Ivory;
            this.groupBoxhd.Controls.Add(this.gv_hoadon);
            this.groupBoxhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBoxhd.ForeColor = System.Drawing.Color.Red;
            this.groupBoxhd.Location = new System.Drawing.Point(16, 15);
            this.groupBoxhd.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxhd.Name = "groupBoxhd";
            this.groupBoxhd.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxhd.Size = new System.Drawing.Size(859, 336);
            this.groupBoxhd.TabIndex = 4;
            this.groupBoxhd.TabStop = false;
            this.groupBoxhd.Text = "Hóa đơn";
            // 
            // gv_hoadon
            // 
            this.gv_hoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_hoadon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gv_hoadon.BackgroundColor = System.Drawing.Color.Azure;
            this.gv_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_hoadon.DefaultCellStyle = dataGridViewCellStyle1;
            this.gv_hoadon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_hoadon.EnableHeadersVisualStyles = false;
            this.gv_hoadon.Location = new System.Drawing.Point(4, 26);
            this.gv_hoadon.Margin = new System.Windows.Forms.Padding(4);
            this.gv_hoadon.MultiSelect = false;
            this.gv_hoadon.Name = "gv_hoadon";
            this.gv_hoadon.RowHeadersWidth = 62;
            this.gv_hoadon.Size = new System.Drawing.Size(851, 306);
            this.gv_hoadon.TabIndex = 1;
            // 
            // FThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 473);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxhd);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FThanhToan";
            this.Text = "FThanhToan";
            this.Load += new System.EventHandler(this.FThanhToan_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBoxhd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_hoadon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btthanhtoan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txttongtien;
        private System.Windows.Forms.GroupBox groupBoxhd;
        private System.Windows.Forms.DataGridView gv_hoadon;
    }
}