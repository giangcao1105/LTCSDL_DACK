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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btthanhtoan = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txttongtien = new System.Windows.Forms.RichTextBox();
            this.groupBoxhd = new System.Windows.Forms.GroupBox();
            this.dg_monan_ofban = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxhd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_monan_ofban)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Ivory;
            this.groupBox3.Controls.Add(this.btthanhtoan);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(550, 288);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(106, 84);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thanh toán";
            // 
            // btthanhtoan
            // 
            this.btthanhtoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btthanhtoan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btthanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btthanhtoan.Location = new System.Drawing.Point(6, 19);
            this.btthanhtoan.Name = "btthanhtoan";
            this.btthanhtoan.Size = new System.Drawing.Size(94, 62);
            this.btthanhtoan.TabIndex = 4;
            this.btthanhtoan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btthanhtoan.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Ivory;
            this.groupBox2.Controls.Add(this.txttongtien);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(15, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(529, 84);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tổng Tiền (VNĐ)";
            // 
            // txttongtien
            // 
            this.txttongtien.BackColor = System.Drawing.Color.Azure;
            this.txttongtien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txttongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttongtien.Location = new System.Drawing.Point(3, 20);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txttongtien.Size = new System.Drawing.Size(523, 61);
            this.txttongtien.TabIndex = 1;
            this.txttongtien.Text = "";
            // 
            // groupBoxhd
            // 
            this.groupBoxhd.BackColor = System.Drawing.Color.Ivory;
            this.groupBoxhd.Controls.Add(this.dg_monan_ofban);
            this.groupBoxhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBoxhd.ForeColor = System.Drawing.Color.Red;
            this.groupBoxhd.Location = new System.Drawing.Point(12, 12);
            this.groupBoxhd.Name = "groupBoxhd";
            this.groupBoxhd.Size = new System.Drawing.Size(644, 273);
            this.groupBoxhd.TabIndex = 4;
            this.groupBoxhd.TabStop = false;
            this.groupBoxhd.Text = "Hóa đơn";
            // 
            // dg_monan_ofban
            // 
            this.dg_monan_ofban.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_monan_ofban.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg_monan_ofban.BackgroundColor = System.Drawing.Color.Azure;
            this.dg_monan_ofban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_monan_ofban.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg_monan_ofban.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_monan_ofban.EnableHeadersVisualStyles = false;
            this.dg_monan_ofban.Location = new System.Drawing.Point(3, 20);
            this.dg_monan_ofban.Name = "dg_monan_ofban";
            this.dg_monan_ofban.RowHeadersWidth = 62;
            this.dg_monan_ofban.Size = new System.Drawing.Size(638, 250);
            this.dg_monan_ofban.TabIndex = 1;
            // 
            // FThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 384);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxhd);
            this.Name = "FThanhToan";
            this.Text = "FThanhToan";
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBoxhd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_monan_ofban)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btthanhtoan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txttongtien;
        private System.Windows.Forms.GroupBox groupBoxhd;
        private System.Windows.Forms.DataGridView dg_monan_ofban;
    }
}