namespace GUI_demo
{
    partial class FQuanLyDatHang
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
            this.DSMON = new System.Windows.Forms.GroupBox();
            this.dg_monan_ofban = new System.Windows.Forms.DataGridView();
            this.THUCDON = new System.Windows.Forms.GroupBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.cbiddouong = new System.Windows.Forms.ComboBox();
            this.cbten = new System.Windows.Forms.ComboBox();
            this.cbiddm = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btThanhToan = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.numericsoluongdoan = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbdanhmuc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dg_dsban = new System.Windows.Forms.DataGridView();
            this.btXoaBan = new System.Windows.Forms.Button();
            this.btthemban = new System.Windows.Forms.Button();
            this.Soban = new System.Windows.Forms.NumericUpDown();
            this.lbthemban = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btSua = new System.Windows.Forms.Button();
            this.DSMON.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_monan_ofban)).BeginInit();
            this.THUCDON.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericsoluongdoan)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_dsban)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Soban)).BeginInit();
            this.SuspendLayout();
            // 
            // DSMON
            // 
            this.DSMON.BackColor = System.Drawing.Color.Transparent;
            this.DSMON.Controls.Add(this.dg_monan_ofban);
            this.DSMON.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DSMON.ForeColor = System.Drawing.Color.Red;
            this.DSMON.Location = new System.Drawing.Point(509, 144);
            this.DSMON.Name = "DSMON";
            this.DSMON.Size = new System.Drawing.Size(620, 515);
            this.DSMON.TabIndex = 7;
            this.DSMON.TabStop = false;
            this.DSMON.Text = "Danh sách món ăn của bàn:";
            // 
            // dg_monan_ofban
            // 
            this.dg_monan_ofban.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_monan_ofban.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg_monan_ofban.BackgroundColor = System.Drawing.Color.Azure;
            this.dg_monan_ofban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_monan_ofban.DefaultCellStyle = dataGridViewCellStyle1;
            this.dg_monan_ofban.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_monan_ofban.EnableHeadersVisualStyles = false;
            this.dg_monan_ofban.Location = new System.Drawing.Point(3, 20);
            this.dg_monan_ofban.Name = "dg_monan_ofban";
            this.dg_monan_ofban.RowHeadersWidth = 62;
            this.dg_monan_ofban.Size = new System.Drawing.Size(614, 492);
            this.dg_monan_ofban.TabIndex = 0;
            // 
            // THUCDON
            // 
            this.THUCDON.BackColor = System.Drawing.Color.Transparent;
            this.THUCDON.Controls.Add(this.btSua);
            this.THUCDON.Controls.Add(this.txtGia);
            this.THUCDON.Controls.Add(this.cbiddouong);
            this.THUCDON.Controls.Add(this.cbten);
            this.THUCDON.Controls.Add(this.cbiddm);
            this.THUCDON.Controls.Add(this.label4);
            this.THUCDON.Controls.Add(this.btThanhToan);
            this.THUCDON.Controls.Add(this.btXoa);
            this.THUCDON.Controls.Add(this.btThem);
            this.THUCDON.Controls.Add(this.numericsoluongdoan);
            this.THUCDON.Controls.Add(this.label3);
            this.THUCDON.Controls.Add(this.cbdanhmuc);
            this.THUCDON.Controls.Add(this.label2);
            this.THUCDON.Controls.Add(this.label1);
            this.THUCDON.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.THUCDON.ForeColor = System.Drawing.Color.Red;
            this.THUCDON.Location = new System.Drawing.Point(509, 12);
            this.THUCDON.Name = "THUCDON";
            this.THUCDON.Size = new System.Drawing.Size(620, 124);
            this.THUCDON.TabIndex = 6;
            this.THUCDON.TabStop = false;
            this.THUCDON.Text = "Chọn thực đơn";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(199, 84);
            this.txtGia.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtGia.Name = "txtGia";
            this.txtGia.ReadOnly = true;
            this.txtGia.Size = new System.Drawing.Size(76, 24);
            this.txtGia.TabIndex = 17;
            // 
            // cbiddouong
            // 
            this.cbiddouong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbiddouong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbiddouong.FormattingEnabled = true;
            this.cbiddouong.Location = new System.Drawing.Point(355, 22);
            this.cbiddouong.Name = "cbiddouong";
            this.cbiddouong.Size = new System.Drawing.Size(34, 26);
            this.cbiddouong.TabIndex = 14;
            // 
            // cbten
            // 
            this.cbten.BackColor = System.Drawing.Color.Azure;
            this.cbten.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbten.FormattingEnabled = true;
            this.cbten.Location = new System.Drawing.Point(92, 51);
            this.cbten.Name = "cbten";
            this.cbten.Size = new System.Drawing.Size(259, 26);
            this.cbten.TabIndex = 16;
            // 
            // cbiddm
            // 
            this.cbiddm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbiddm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbiddm.FormattingEnabled = true;
            this.cbiddm.Location = new System.Drawing.Point(355, 51);
            this.cbiddm.Name = "cbiddm";
            this.cbiddm.Size = new System.Drawing.Size(34, 26);
            this.cbiddm.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(153, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Phần";
            // 
            // btThanhToan
            // 
            this.btThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btThanhToan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThanhToan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btThanhToan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btThanhToan.Location = new System.Drawing.Point(515, 64);
            this.btThanhToan.Name = "btThanhToan";
            this.btThanhToan.Size = new System.Drawing.Size(99, 39);
            this.btThanhToan.TabIndex = 12;
            this.btThanhToan.Text = "Thanh toán";
            this.btThanhToan.UseVisualStyleBackColor = false;
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btXoa.Location = new System.Drawing.Point(395, 64);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(99, 39);
            this.btXoa.TabIndex = 10;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btThem.Location = new System.Drawing.Point(395, 19);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(99, 39);
            this.btThem.TabIndex = 9;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            // 
            // numericsoluongdoan
            // 
            this.numericsoluongdoan.BackColor = System.Drawing.Color.Azure;
            this.numericsoluongdoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numericsoluongdoan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.numericsoluongdoan.Location = new System.Drawing.Point(92, 84);
            this.numericsoluongdoan.Name = "numericsoluongdoan";
            this.numericsoluongdoan.Size = new System.Drawing.Size(56, 24);
            this.numericsoluongdoan.TabIndex = 8;
            this.numericsoluongdoan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số lượng:";
            // 
            // cbdanhmuc
            // 
            this.cbdanhmuc.BackColor = System.Drawing.Color.Azure;
            this.cbdanhmuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbdanhmuc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbdanhmuc.FormattingEnabled = true;
            this.cbdanhmuc.Location = new System.Drawing.Point(92, 21);
            this.cbdanhmuc.Name = "cbdanhmuc";
            this.cbdanhmuc.Size = new System.Drawing.Size(259, 26);
            this.cbdanhmuc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên món:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh mục:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dg_dsban);
            this.groupBox1.Controls.Add(this.btXoaBan);
            this.groupBox1.Controls.Add(this.btthemban);
            this.groupBox1.Controls.Add(this.Soban);
            this.groupBox1.Controls.Add(this.lbthemban);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 661);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sơ đồ bàn";
            // 
            // dg_dsban
            // 
            this.dg_dsban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_dsban.Location = new System.Drawing.Point(382, 16);
            this.dg_dsban.Name = "dg_dsban";
            this.dg_dsban.RowHeadersWidth = 62;
            this.dg_dsban.Size = new System.Drawing.Size(24, 16);
            this.dg_dsban.TabIndex = 7;
            // 
            // btXoaBan
            // 
            this.btXoaBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btXoaBan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btXoaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXoaBan.ForeColor = System.Drawing.Color.Black;
            this.btXoaBan.Location = new System.Drawing.Point(307, 16);
            this.btXoaBan.Name = "btXoaBan";
            this.btXoaBan.Size = new System.Drawing.Size(67, 22);
            this.btXoaBan.TabIndex = 6;
            this.btXoaBan.Text = "Xóa";
            this.btXoaBan.UseVisualStyleBackColor = false;
            // 
            // btthemban
            // 
            this.btthemban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btthemban.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btthemban.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btthemban.ForeColor = System.Drawing.Color.Black;
            this.btthemban.Location = new System.Drawing.Point(235, 16);
            this.btthemban.Name = "btthemban";
            this.btthemban.Size = new System.Drawing.Size(67, 22);
            this.btthemban.TabIndex = 6;
            this.btthemban.Text = "Thêm";
            this.btthemban.UseVisualStyleBackColor = false;
            // 
            // Soban
            // 
            this.Soban.BackColor = System.Drawing.Color.Azure;
            this.Soban.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Soban.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Soban.Location = new System.Drawing.Point(172, 16);
            this.Soban.Name = "Soban";
            this.Soban.Size = new System.Drawing.Size(57, 22);
            this.Soban.TabIndex = 5;
            this.Soban.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbthemban
            // 
            this.lbthemban.AutoSize = true;
            this.lbthemban.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbthemban.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbthemban.Location = new System.Drawing.Point(76, 18);
            this.lbthemban.Name = "lbthemban";
            this.lbthemban.Size = new System.Drawing.Size(90, 16);
            this.lbthemban.TabIndex = 4;
            this.lbthemban.Text = "Thêm số bàn:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Azure;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.flowLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 51);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(477, 599);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // btSua
            // 
            this.btSua.ForeColor = System.Drawing.Color.Black;
            this.btSua.Location = new System.Drawing.Point(515, 21);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(99, 39);
            this.btSua.TabIndex = 18;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            // 
            // FQuanLyDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 682);
            this.Controls.Add(this.DSMON);
            this.Controls.Add(this.THUCDON);
            this.Controls.Add(this.groupBox1);
            this.Name = "FQuanLyDatHang";
            this.Text = "FQuanLyDatHang";
            this.DSMON.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_monan_ofban)).EndInit();
            this.THUCDON.ResumeLayout(false);
            this.THUCDON.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericsoluongdoan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_dsban)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Soban)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox DSMON;
        public System.Windows.Forms.DataGridView dg_monan_ofban;
        private System.Windows.Forms.GroupBox THUCDON;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.ComboBox cbiddouong;
        private System.Windows.Forms.ComboBox cbten;
        private System.Windows.Forms.ComboBox cbiddm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btThanhToan;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.NumericUpDown numericsoluongdoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbdanhmuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dg_dsban;
        private System.Windows.Forms.Button btXoaBan;
        private System.Windows.Forms.Button btthemban;
        private System.Windows.Forms.NumericUpDown Soban;
        private System.Windows.Forms.Label lbthemban;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btSua;
    }
}