namespace GUI_demo
{
    partial class FQuanLySanPham
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dg_indanhsach = new System.Windows.Forms.DataGridView();
            this.dg_monan = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbtendm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.txttendouong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btthoat = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btHuy = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.themToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themSPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_indanhsach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_monan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dg_indanhsach);
            this.groupBox2.Controls.Add(this.dg_monan);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(548, 49);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(759, 570);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các món ăn và thức uống";
            // 
            // dg_indanhsach
            // 
            this.dg_indanhsach.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dg_indanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_indanhsach.Location = new System.Drawing.Point(7, 30);
            this.dg_indanhsach.Margin = new System.Windows.Forms.Padding(4);
            this.dg_indanhsach.Name = "dg_indanhsach";
            this.dg_indanhsach.RowHeadersWidth = 62;
            this.dg_indanhsach.Size = new System.Drawing.Size(24, 21);
            this.dg_indanhsach.TabIndex = 1;
            // 
            // dg_monan
            // 
            this.dg_monan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_monan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg_monan.BackgroundColor = System.Drawing.Color.Azure;
            this.dg_monan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_monan.DefaultCellStyle = dataGridViewCellStyle1;
            this.dg_monan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_monan.EnableHeadersVisualStyles = false;
            this.dg_monan.Location = new System.Drawing.Point(4, 26);
            this.dg_monan.Margin = new System.Windows.Forms.Padding(4);
            this.dg_monan.Name = "dg_monan";
            this.dg_monan.RowHeadersWidth = 62;
            this.dg_monan.Size = new System.Drawing.Size(751, 540);
            this.dg_monan.TabIndex = 0;
            this.dg_monan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_monan_CellClick);
            this.dg_monan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_monan_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtMaSP);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbtendm);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtdongia);
            this.groupBox1.Controls.Add(this.txttendouong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(16, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(524, 366);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Menu";
            // 
            // txtMaSP
            // 
            this.txtMaSP.BackColor = System.Drawing.Color.Azure;
            this.txtMaSP.Enabled = false;
            this.txtMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaSP.Location = new System.Drawing.Point(161, 41);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(272, 26);
            this.txtMaSP.TabIndex = 15;
            this.txtMaSP.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(15, 43);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mã SP";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(460, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "VNĐ";
            // 
            // cbtendm
            // 
            this.cbtendm.BackColor = System.Drawing.Color.Azure;
            this.cbtendm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbtendm.FormattingEnabled = true;
            this.cbtendm.Location = new System.Drawing.Point(161, 231);
            this.cbtendm.Margin = new System.Windows.Forms.Padding(4);
            this.cbtendm.Name = "cbtendm";
            this.cbtendm.Size = new System.Drawing.Size(272, 28);
            this.cbtendm.TabIndex = 7;
            this.cbtendm.SelectedIndexChanged += new System.EventHandler(this.cbtendm_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(15, 236);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Danh mục:";
            // 
            // txtdongia
            // 
            this.txtdongia.BackColor = System.Drawing.Color.Azure;
            this.txtdongia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtdongia.Location = new System.Drawing.Point(161, 163);
            this.txtdongia.Margin = new System.Windows.Forms.Padding(4);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(272, 26);
            this.txtdongia.TabIndex = 5;
            // 
            // txttendouong
            // 
            this.txttendouong.BackColor = System.Drawing.Color.Azure;
            this.txttendouong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttendouong.Location = new System.Drawing.Point(161, 96);
            this.txttendouong.Margin = new System.Windows.Forms.Padding(4);
            this.txttendouong.Name = "txttendouong";
            this.txttendouong.Size = new System.Drawing.Size(272, 26);
            this.txttendouong.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(15, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(15, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên:";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.btthoat);
            this.groupBox6.Controls.Add(this.btSua);
            this.groupBox6.Controls.Add(this.btThem);
            this.groupBox6.Controls.Add(this.btHuy);
            this.groupBox6.Controls.Add(this.btLuu);
            this.groupBox6.Controls.Add(this.btXoa);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox6.ForeColor = System.Drawing.Color.Red;
            this.groupBox6.Location = new System.Drawing.Point(16, 422);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(524, 196);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Chức năng";
            // 
            // btthoat
            // 
            this.btthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btthoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btthoat.Location = new System.Drawing.Point(391, 133);
            this.btthoat.Margin = new System.Windows.Forms.Padding(4);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(120, 55);
            this.btthoat.TabIndex = 7;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btSua.Location = new System.Drawing.Point(8, 133);
            this.btSua.Margin = new System.Windows.Forms.Padding(4);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(120, 55);
            this.btSua.TabIndex = 1;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btThem.Location = new System.Drawing.Point(8, 46);
            this.btThem.Margin = new System.Windows.Forms.Padding(4);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(119, 55);
            this.btThem.TabIndex = 0;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btHuy
            // 
            this.btHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btHuy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btHuy.Location = new System.Drawing.Point(211, 133);
            this.btHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(120, 55);
            this.btHuy.TabIndex = 4;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = false;
            // 
            // btLuu
            // 
            this.btLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btLuu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btLuu.Location = new System.Drawing.Point(391, 46);
            this.btLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(120, 55);
            this.btLuu.TabIndex = 3;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = false;
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btXoa.Location = new System.Drawing.Point(211, 46);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(120, 55);
            this.btXoa.TabIndex = 2;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themToolStripMenuItem,
            this.themSPToolStripMenuItem,
            this.themKhoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1324, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // themToolStripMenuItem
            // 
            this.themToolStripMenuItem.Name = "themToolStripMenuItem";
            this.themToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.themToolStripMenuItem.Text = "Thêm danh mục";
            this.themToolStripMenuItem.Click += new System.EventHandler(this.themToolStripMenuItem_Click);
            // 
            // themSPToolStripMenuItem
            // 
            this.themSPToolStripMenuItem.Name = "themSPToolStripMenuItem";
            this.themSPToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.themSPToolStripMenuItem.Text = "Thêm sản phẩm";
            // 
            // themKhoToolStripMenuItem
            // 
            this.themKhoToolStripMenuItem.Name = "themKhoToolStripMenuItem";
            this.themKhoToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.themKhoToolStripMenuItem.Text = "Thêm kho";
            this.themKhoToolStripMenuItem.Click += new System.EventHandler(this.themKhoToolStripMenuItem_Click);
            // 
            // FQuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 640);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FQuanLySanPham";
            this.Text = "FQuanLySanPham";
            this.Load += new System.EventHandler(this.FQuanLySanPham_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_indanhsach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_monan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dg_indanhsach;
        private System.Windows.Forms.DataGridView dg_monan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbtendm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.TextBox txttendouong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem themToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themSPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themKhoToolStripMenuItem;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label6;
    }
}