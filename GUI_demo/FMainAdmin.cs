using GUI_demo.BUS;
using GUI_demo.Report;
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
        BUS_HoaDon bHD;
        DateTime d1, d2;
        public FMainAdmin()
        {
            InitializeComponent();
            bHD = new BUS_HoaDon();
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
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void chấmCôngNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FChamCong f = new FChamCong();
            f.Show();
        }

        private void quảnLýĐặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FQuanLyDatHang f = new FQuanLyDatHang();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.manv = maNV;
            f.Show();
        }

        private void thongKeHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FThongKeHoaDon f = new FThongKeHoaDon();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void FMainAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void thốngKêDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FTongDT f = new FTongDT();   
            CRBaoCaoDoanhThu cr = new CRBaoCaoDoanhThu();
            cr.SetDataSource(bHD.baoCaoDoanhThu(d1, d2));
            f.crystalReportViewer1.ReportSource = cr;
            f.Show();
        }
    }
}
