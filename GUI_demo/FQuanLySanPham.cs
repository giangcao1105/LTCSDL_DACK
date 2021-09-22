using System;
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
    public partial class FQuanLySanPham : Form
    {
        public FQuanLySanPham()
        {
            InitializeComponent();
        }

        private void themToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FDanhMuc f = new FDanhMuc();
            f.Show();
        }
    }
}
