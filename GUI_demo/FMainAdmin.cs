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
    public partial class FMainAdmin : Form
    {
        public int maNV;
        public FMainAdmin()
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

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FDanhSachNhanVien f = new FDanhSachNhanVien();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void quanLyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FQuanLySanPham f = new FQuanLySanPham();
            f.Show();
        }

        private void chấmCôngNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
