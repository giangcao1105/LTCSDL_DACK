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
    public partial class FQuanLySanPham : Form
    {
        bool flag = false;
        BUS_SanPham bSanPham;
        BUS_LoaiSanPham bLoaiSanPham;
        int maSP = -1;
        public FQuanLySanPham()
        {
            InitializeComponent();
            bSanPham = new BUS_SanPham();
            bLoaiSanPham = new BUS_LoaiSanPham();
        }

        private void themToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FDanhMuc f = new FDanhMuc();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void dg_monan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                
        }

        private void dg_monan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dg_monan.Rows.Count)
            {
                txttendouong.Text = dg_monan.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtdongia.Text = dg_monan.Rows[e.RowIndex].Cells[3].Value.ToString();
                cbtendm.Text = dg_monan.Rows[e.RowIndex].Cells[2].Value.ToString();
                flag = true;
                txtMaSP.Text = dg_monan.Rows[e.RowIndex].Cells[0].Value.ToString();
                //maSP =Int32.Parse(dg_monan.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FQuanLySanPham_Load(object sender, EventArgs e)
        {
            bSanPham.hienThiDSSP(dg_monan);
            bLoaiSanPham.hienThiDSLoaiSP(cbtendm);
            
        }

        private void cbtendm_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btThem_Click(object sender, EventArgs e)
        {

            if (txttendouong.Text == "" || txtdongia.Text == "" || cbtendm.Text == "")
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            else
            {
                
                {
                    SanPham sp = new SanPham();
                    sp.TenSP = txttendouong.Text;
                    sp.DonGia = double.Parse(txtdongia.Text);
                    sp.MaLoaiSP = Int32.Parse(cbtendm.SelectedValue.ToString());
                    if (bSanPham.themSanPhan(sp))
                    {
                        MessageBox.Show("Thêm sản phẩm thành công");
                        bSanPham.hienThiDSSP(dg_monan);
                        flag = false;
                    }
                    else
                        MessageBox.Show("Thêm sản phẩm thất bại");
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (txttendouong.Text == "" || txtdongia.Text == "" || cbtendm.Text == "")
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            else
            {

                {
                    SanPham sp = new SanPham();
                    sp.TenSP = txttendouong.Text;
                    sp.DonGia = double.Parse(txtdongia.Text);
                    sp.MaLoaiSP = Int32.Parse(cbtendm.SelectedValue.ToString());
                    if (bSanPham.capNhatSanPham(Int32.Parse(txtMaSP.Text), sp))
                    {
                        MessageBox.Show("Cập nhật sản phẩm thành công");
                        bSanPham.hienThiDSSP(dg_monan);
                        flag = false;
                    }
                    else
                        MessageBox.Show("Cập nhật sản phẩm thất bại");
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (!flag)
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa");
            else
            {

                {
                    
                    if (bSanPham.xoaSanPham(Int32.Parse(txtMaSP.Text)))
                    {
                        MessageBox.Show("Xóa sản phẩm thành công");
                        bSanPham.hienThiDSSP(dg_monan);
                        flag = false;
                    }
                    else
                        MessageBox.Show("Xóa sản phẩm thất bại");
                }
            }
        }

        private void themKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FQuanLyKho f = new FQuanLyKho();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            bSanPham.hienThiDSSPTimKiem(dg_monan, txtTimKiem.Text);
        }
    }
}
