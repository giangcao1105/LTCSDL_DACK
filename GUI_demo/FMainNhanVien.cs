﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_demo
{
    public partial class FMainNhanVien : Form
    {
        public int maNV;
        public FMainNhanVien()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FDangNhap f = new FDangNhap();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
            this.Hide();
        }
    }
}
