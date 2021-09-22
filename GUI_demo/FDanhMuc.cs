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
    public partial class FDanhMuc : Form
    {
        bool flag = false;
        BUS_LoaiSanPham bLoaiSanPham;
        int maSP;
        public FDanhMuc()
        {
            InitializeComponent();
            bLoaiSanPham = new BUS_LoaiSanPham();
        }

        private void TV_DANHMUC_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void FDanhMuc_Load(object sender, EventArgs e)
        {
            bLoaiSanPham.hienThiDSLoaiSP(dGVDanhMuc);
        }

        private void dGVDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dGVDanhMuc.Rows.Count)
            {
                flag = true;
                txttendm.Text = dGVDanhMuc.Rows[e.RowIndex].Cells[1].Value.ToString();
                maSP = Int32.Parse(dGVDanhMuc.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txttendm.Text == "")
            {
                MessageBox.Show("Vui lòng điền tên loại danh mục");
            }
            else {
                LoaiSP lsp = new LoaiSP();
                lsp.TenLoaiSP = txttendm.Text;
                if (bLoaiSanPham.themLoaiSanPhan(lsp))
                {
                    MessageBox.Show("Thêm loại danh mục thành công.");
                    bLoaiSanPham.hienThiDSLoaiSP(dGVDanhMuc);
                    flag = false;
                }
                else {
                    MessageBox.Show("Thêm loại danh mục thất bại.");
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (txttendm.Text == "")
            {
                MessageBox.Show("Vui lòng điền tên loại danh mục");
            }
            else
            {
                LoaiSP lsp = new LoaiSP();
                lsp.TenLoaiSP = txttendm.Text;
                if (bLoaiSanPham.capNhatSanPham(maSP,lsp))
                {
                    MessageBox.Show("Cập nhật loại danh mục thành công.");
                    bLoaiSanPham.hienThiDSLoaiSP(dGVDanhMuc);
                    flag = false;
                }
                else
                {
                    MessageBox.Show("Cập nhật loại danh mục thất bại.");
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                MessageBox.Show("Vui lòng chọn loại danh mục cần xóa");
            }
            else
            {

                if (bLoaiSanPham.xoaSanPham(maSP))
                {
                    MessageBox.Show("Xóa loại danh mục thành công.");
                    bLoaiSanPham.hienThiDSLoaiSP(dGVDanhMuc);
                    flag = false;
                }
                else
                {
                    MessageBox.Show("Xóa loại danh mục thất bại.");
                }
            }
        }
    }
}
