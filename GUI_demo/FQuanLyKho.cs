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
    public partial class FQuanLyKho : Form
    {
        BUS_Kho bKho;
        bool flag = false;
        bool flag2 = false;
        DateTime ngayNhap;
        BUS_LoaiSanPham bLoaiSanPham;
        BUS_SanPham bSanPham;
        public FQuanLyKho()
        {
            InitializeComponent();
            bKho = new BUS_Kho();
            bLoaiSanPham = new BUS_LoaiSanPham();
            bSanPham = new BUS_SanPham();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dg_monan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dg_monan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvKho.Rows.Count)
            {
                txtMaSP.Text = dgvKho.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbTenDoUong.Text = dgvKho.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtpNgayNhap.Text = dgvKho.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSoLuong.Text = dgvKho.Rows[e.RowIndex].Cells[3].Value.ToString();
                cbDanhMuc.Text = dgvKho.Rows[e.RowIndex].Cells[4].Value.ToString();
                ngayNhap = dtpNgayNhap.Value;
                flag = true;
                flag2 = true;
            }
        }

        private void FQuanLyKho_Load(object sender, EventArgs e)
        {
            bKho.hienThiKho(dgvKho);
            bSanPham.hienThiDSSP(cbTenDoUong);
            bLoaiSanPham.hienThiDSLoaiSP(cbDanhMuc);
        }

        private void btThem_Click(object sender, EventArgs e)
        {

            if (cbTenDoUong.Text == ""||dtpNgayNhap.Value == null || txtSoLuong.Text == "")
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            else
            {

                {
                    Kho k = new Kho();
                    k.MaSP =Int32.Parse(txtMaSP.Text);
                    k.NgayNhapSP = dtpNgayNhap.Value;
                    k.SoLuong = Int32.Parse(txtSoLuong.Text);
                    if (bKho.themKho(k))
                    {
                        MessageBox.Show("Thêm sản phẩm vào kho thành công");
                        bKho.hienThiKho(dgvKho);
                        flag = false;
                    }
                    else
                        MessageBox.Show("Thêm sản phẩm vào kho thất bại");
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (cbTenDoUong.Text == "" || dtpNgayNhap.Value == null || txtSoLuong.Text == "")
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            else
            {

                {
                    Kho k = new Kho();
                    k.MaSP = Int32.Parse(txtMaSP.Text);
                    k.NgayNhapSP = dtpNgayNhap.Value;
                    k.SoLuong = Int32.Parse(txtSoLuong.Text);
                    if (bKho.capNhatKho(Int32.Parse(txtMaSP.Text),ngayNhap,k))
                    {
                        MessageBox.Show("Cập nhật sản phẩm trong kho thành công");
                        bKho.hienThiKho(dgvKho);
                        flag = false;
                    }
                    else
                        MessageBox.Show("Cập nhật sản phẩm trong kho thất bại");
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (!flag)
                MessageBox.Show("Vui lòng chọn dòng cần xóa");
            else
            {

                {
                    Kho k = new Kho();
                    k.MaSP = Int32.Parse(txtMaSP.Text);
                    k.NgayNhapSP = dtpNgayNhap.Value;
                    k.SoLuong = Int32.Parse(txtSoLuong.Text);
                    if (bKho.xoaKho(Int32.Parse(txtMaSP.Text), ngayNhap))
                    {
                        MessageBox.Show("Xóa sản phẩm trong kho thành công");
                        bKho.hienThiKho(dgvKho);
                        flag = false;
                    }
                    else
                        MessageBox.Show("Xóa sản phẩm trong kho thất bại");
                }
            }
        }

        private void cbTenDoUong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag2)
            {
                txtMaSP.Text = cbTenDoUong.SelectedValue.ToString();
                bSanPham.layLoaiSP(cbDanhMuc, Int32.Parse(cbTenDoUong.SelectedValue.ToString())); 
            }
        }
    }
}
