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
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
            dg_nhanvien.DataSource = null;
            bNhanVien.hienThiDSNV(dg_nhanvien);
        }

        private void FDanhSachNhanVien_Load(object sender, EventArgs e)
        {
            dg_nhanvien.DataSource = null;
            bNhanVien.hienThiDSNV(dg_nhanvien);
            bChucVu.hienThiDsChucVu(cbChucVu);
            cbChucVu.SelectedIndex = -1;
            txtmanv.Enabled = false;           
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
                if (dg_nhanvien.Rows[e.RowIndex].Cells[6].Value != null)
                    txtDiaChi.Text = dg_nhanvien.Rows[e.RowIndex].Cells[6].Value.ToString();
                else
                    txtDiaChi.Text = "";
                if (dg_nhanvien.Rows[e.RowIndex].Cells[7].Value != null)
                    txtQueQuan.Text = dg_nhanvien.Rows[e.RowIndex].Cells[7].Value.ToString();
                else
                    txtQueQuan.Text = "";
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien nv = new NhanVien();
                nv.MaNV = int.Parse(txtmanv.Text);
                nv.HoTenNV = txttennv.Text;
                if (rdNam.Checked)
                    nv.GioiTinh = "Nam";
                else
                    nv.GioiTinh = "Nữ";
                nv.MaChucVu = int.Parse(cbChucVu.SelectedValue.ToString());
                nv.NgaySinhNV = dtpNgaySinh.Value;
                nv.SDTNV = txtSDT.Text;
                if (txtDiaChi.Text.Equals(""))
                    nv.DiaChiNV = null;
                else
                    nv.DiaChiNV = txtDiaChi.Text;
                if (txtQueQuan.Text.Equals(""))
                    nv.QueQuanNV = null;
                else
                    nv.QueQuanNV = txtQueQuan.Text;

                if (bNhanVien.SuaTTNV(nv))
                {
                    MessageBox.Show("Sửa thông tin nhân viên thành công");
                    bNhanVien.hienThiDSNV(dg_nhanvien);
                }
                else
                    MessageBox.Show("Sửa thông tin nhân viên thất bại");
            }
            catch (Exception)
            {
                MessageBox.Show("Sửa thông tin nhân viên thất bại");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien nv = bNhanVien.layTTNV(int.Parse(txtmanv.Text));

                if (bNhanVien.XoaNV(nv))
                {
                    MessageBox.Show("Xóa nhân viên thành công");
                    bNhanVien.hienThiDSNV(dg_nhanvien);
                }
                else
                    MessageBox.Show("Xóa nhân viên thất bại");
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa nhân viên thất bại");
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            NhanVien nv = bNhanVien.layTTNV(int.Parse(txtmanv.Text));

            txttennv.Text = nv.HoTenNV;
            cbChucVu.SelectedValue = nv.MaChucVu;

            if (nv.GioiTinh.ToString().Equals("Nam"))
                rdNam.Checked = true;
            else
                rdNu.Checked = true;
            dtpNgaySinh.Text = nv.NgaySinhNV.ToString();
            txtSDT.Text = nv.SDTNV;
            txtDiaChi.Text = nv.DiaChiNV;
            txtQueQuan.Text = nv.QueQuanNV;
            if (nv.DiaChiNV != null)
                txtDiaChi.Text = nv.DiaChiNV;
            else
                txtDiaChi.Text = "";
            if (nv.QueQuanNV != null)
                txtQueQuan.Text = nv.QueQuanNV;
            else
                txtQueQuan.Text = "";
        }
    }
}
