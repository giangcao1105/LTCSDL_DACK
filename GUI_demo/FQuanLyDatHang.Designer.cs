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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DSMON = new System.Windows.Forms.GroupBox();
            this.gV_CTHD = new System.Windows.Forms.DataGridView();
            this.THUCDON = new System.Windows.Forms.GroupBox();
            this.btSua = new System.Windows.Forms.Button();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.cbten = new System.Windows.Forms.ComboBox();
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
            this.btXoaBan = new System.Windows.Forms.Button();
            this.btthemban = new System.Windows.Forms.Button();
            this.Soban = new System.Windows.Forms.NumericUpDown();
            this.lbthemban = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.DSMON.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gV_CTHD)).BeginInit();
            this.THUCDON.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericsoluongdoan)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Soban)).BeginInit();
            this.SuspendLayout();
            // 
            // DSMON
            // 
            this.DSMON.BackColor = System.Drawing.Color.Transparent;
            this.DSMON.Controls.Add(this.gV_CTHD);
            this.DSMON.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DSMON.ForeColor = System.Drawing.Color.Red;
            this.DSMON.Location = new System.Drawing.Point(679, 177);
            this.DSMON.Margin = new System.Windows.Forms.Padding(4);
            this.DSMON.Name = "DSMON";
            this.DSMON.Padding = new System.Windows.Forms.Padding(4);
            this.DSMON.Size = new System.Drawing.Size(827, 634);
            this.DSMON.TabIndex = 7;
            this.DSMON.TabStop = false;
            this.DSMON.Text = "Danh sách món ăn của bàn:";
            // 
            // gV_CTHD
            // 
            this.gV_CTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gV_CTHD.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gV_CTHD.BackgroundColor = System.Drawing.Color.Azure;
            this.gV_CTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gV_CTHD.DefaultCellStyle = dataGridViewCellStyle2;
            this.gV_CTHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gV_CTHD.EnableHeadersVisualStyles = false;
            this.gV_CTHD.Location = new System.Drawing.Point(4, 26);
            this.gV_CTHD.Margin = new System.Windows.Forms.Padding(4);
            this.gV_CTHD.MultiSelect = false;
            this.gV_CTHD.Name = "gV_CTHD";
            this.gV_CTHD.RowHeadersWidth = 62;
            this.gV_CTHD.Size = new System.Drawing.Size(819, 604);
            this.gV_CTHD.TabIndex = 0;
            this.gV_CTHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gV_CTHD_CellClick);
            // 
            // THUCDON
            // 
            this.THUCDON.BackColor = System.Drawing.Color.Transparent;
            this.THUCDON.Controls.Add(this.btSua);
            this.THUCDON.Controls.Add(this.txtGiamGia);
            this.THUCDON.Controls.Add(this.cbten);
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
            this.THUCDON.Location = new System.Drawing.Point(679, 15);
            this.THUCDON.Margin = new System.Windows.Forms.Padding(4);
            this.THUCDON.Name = "THUCDON";
            this.THUCDON.Padding = new System.Windows.Forms.Padding(4);
            this.THUCDON.Size = new System.Drawing.Size(827, 153);
            this.THUCDON.TabIndex = 6;
            this.THUCDON.TabStop = false;
            this.THUCDON.Text = "Chọn thực đơn";
            // 
            // btSua
            // 
            this.btSua.ForeColor = System.Drawing.Color.Black;
            this.btSua.Location = new System.Drawing.Point(687, 26);
            this.btSua.Margin = new System.Windows.Forms.Padding(4);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(132, 48);
            this.btSua.TabIndex = 18;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.BackColor = System.Drawing.Color.White;
            this.txtGiamGia.Location = new System.Drawing.Point(298, 103);
            this.txtGiamGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(169, 29);
            this.txtGiamGia.TabIndex = 17;
            // 
            // cbten
            // 
            this.cbten.BackColor = System.Drawing.Color.Azure;
            this.cbten.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbten.FormattingEnabled = true;
            this.cbten.Location = new System.Drawing.Point(123, 63);
            this.cbten.Margin = new System.Windows.Forms.Padding(4);
            this.cbten.Name = "cbten";
            this.cbten.Size = new System.Drawing.Size(344, 32);
            this.cbten.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(208, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Giảm giá";
            // 
            // btThanhToan
            // 
            this.btThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btThanhToan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThanhToan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btThanhToan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btThanhToan.Location = new System.Drawing.Point(687, 79);
            this.btThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.btThanhToan.Name = "btThanhToan";
            this.btThanhToan.Size = new System.Drawing.Size(132, 48);
            this.btThanhToan.TabIndex = 12;
            this.btThanhToan.Text = "Thanh toán";
            this.btThanhToan.UseVisualStyleBackColor = false;
            this.btThanhToan.Click += new System.EventHandler(this.btThanhToan_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btXoa.Location = new System.Drawing.Point(527, 79);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(132, 48);
            this.btXoa.TabIndex = 10;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btThem.Location = new System.Drawing.Point(527, 23);
            this.btThem.Margin = new System.Windows.Forms.Padding(4);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(132, 48);
            this.btThem.TabIndex = 9;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // numericsoluongdoan
            // 
            this.numericsoluongdoan.BackColor = System.Drawing.Color.Azure;
            this.numericsoluongdoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numericsoluongdoan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.numericsoluongdoan.Location = new System.Drawing.Point(123, 103);
            this.numericsoluongdoan.Margin = new System.Windows.Forms.Padding(4);
            this.numericsoluongdoan.Name = "numericsoluongdoan";
            this.numericsoluongdoan.Size = new System.Drawing.Size(58, 29);
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
            this.label3.Location = new System.Drawing.Point(8, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số lượng:";
            // 
            // cbdanhmuc
            // 
            this.cbdanhmuc.BackColor = System.Drawing.Color.Azure;
            this.cbdanhmuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbdanhmuc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbdanhmuc.FormattingEnabled = true;
            this.cbdanhmuc.Location = new System.Drawing.Point(123, 26);
            this.cbdanhmuc.Margin = new System.Windows.Forms.Padding(4);
            this.cbdanhmuc.Name = "cbdanhmuc";
            this.cbdanhmuc.Size = new System.Drawing.Size(344, 32);
            this.cbdanhmuc.TabIndex = 2;
            this.cbdanhmuc.SelectedIndexChanged += new System.EventHandler(this.cbdanhmuc_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(8, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên món:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh mục:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btXoaBan);
            this.groupBox1.Controls.Add(this.btthemban);
            this.groupBox1.Controls.Add(this.Soban);
            this.groupBox1.Controls.Add(this.lbthemban);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(652, 814);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sơ đồ bàn";
            // 
            // btXoaBan
            // 
            this.btXoaBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btXoaBan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btXoaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXoaBan.ForeColor = System.Drawing.Color.Black;
            this.btXoaBan.Location = new System.Drawing.Point(409, 20);
            this.btXoaBan.Margin = new System.Windows.Forms.Padding(4);
            this.btXoaBan.Name = "btXoaBan";
            this.btXoaBan.Size = new System.Drawing.Size(89, 27);
            this.btXoaBan.TabIndex = 6;
            this.btXoaBan.Text = "Xóa";
            this.btXoaBan.UseVisualStyleBackColor = false;
            this.btXoaBan.Click += new System.EventHandler(this.btXoaBan_Click);
            // 
            // btthemban
            // 
            this.btthemban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btthemban.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btthemban.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btthemban.ForeColor = System.Drawing.Color.Black;
            this.btthemban.Location = new System.Drawing.Point(313, 20);
            this.btthemban.Margin = new System.Windows.Forms.Padding(4);
            this.btthemban.Name = "btthemban";
            this.btthemban.Size = new System.Drawing.Size(89, 27);
            this.btthemban.TabIndex = 6;
            this.btthemban.Text = "Thêm";
            this.btthemban.UseVisualStyleBackColor = false;
            this.btthemban.Click += new System.EventHandler(this.btthemban_Click);
            // 
            // Soban
            // 
            this.Soban.BackColor = System.Drawing.Color.Azure;
            this.Soban.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Soban.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Soban.Location = new System.Drawing.Point(229, 20);
            this.Soban.Margin = new System.Windows.Forms.Padding(4);
            this.Soban.Name = "Soban";
            this.Soban.Size = new System.Drawing.Size(76, 26);
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
            this.lbthemban.Location = new System.Drawing.Point(101, 22);
            this.lbthemban.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbthemban.Name = "lbthemban";
            this.lbthemban.Size = new System.Drawing.Size(111, 20);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 63);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(636, 737);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // FQuanLyDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 839);
            this.Controls.Add(this.DSMON);
            this.Controls.Add(this.THUCDON);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FQuanLyDatHang";
            this.Text = "FQuanLyDatHang";
            this.Load += new System.EventHandler(this.FQuanLyDatHang_Load);
            this.DSMON.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gV_CTHD)).EndInit();
            this.THUCDON.ResumeLayout(false);
            this.THUCDON.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericsoluongdoan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Soban)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox DSMON;
        public System.Windows.Forms.DataGridView gV_CTHD;
        private System.Windows.Forms.GroupBox THUCDON;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.ComboBox cbten;
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
        private System.Windows.Forms.Button btXoaBan;
        private System.Windows.Forms.Button btthemban;
        private System.Windows.Forms.NumericUpDown Soban;
        private System.Windows.Forms.Label lbthemban;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btSua;
    }
}