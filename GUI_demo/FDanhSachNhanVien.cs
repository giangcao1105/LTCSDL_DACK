using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_demo.BUS;

namespace GUI_demo
{
    public partial class FDanhSachNhanVien : Form
    {
        BUS_NhanVien bNhanVien;
        BUS_ChucVu bChucVu;
        public FDanhSachNhanVien()
        {
            InitializeComponent();
            bNhanVien = new BUS_NhanVien();
            bChucVu = new BUS_ChucVu();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            FDangKy f = new FDangKy();
            f.Show();
        }

        private void dg_nhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FDanhSachNhanVien_Load(object sender, EventArgs e)
        {
            dg_nhanvien.DataSource = null;
            bNhanVien.hienThiDSNV(dg_nhanvien);
            bChucVu.hienThiDsChucVu(cbChucVu);
            txtmanv.Enabled = false;
            
        }

        private void cbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtmanv_TextChanged(object sender, EventArgs e)
        {

        }

        private void dg_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dg_nhanvien.Rows.Count)
            {
                txtmanv.Text = dg_nhanvien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txttennv.Text = dg_nhanvien.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbChucVu.Text = dg_nhanvien.Rows[e.RowIndex].Cells[3].Value.ToString();

                if (dg_nhanvien.Rows[e.RowIndex].Cells[2].Value.ToString().Equals("Nam"))
                    rdNam.Checked = true;
                else
                    rdNu.Checked = true;
                dtpNgaySinh.Text = dg_nhanvien.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtSDT.Text = dg_nhanvien.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtDiaChi.Text = dg_nhanvien.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtQueQuan.Text = dg_nhanvien.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
        }
    }
}
