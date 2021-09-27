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
    public partial class FQuanLyChucVu : Form
    {
        BUS_ChucVu bChucVu;
        int manv;
        public FQuanLyChucVu()
        {
            InitializeComponent();
            bChucVu = new BUS_ChucVu();
        }

        private void FQuanLyChucVu_Load(object sender, EventArgs e)
        {
            // HIỂN THỊ DS CHỨC VỤ
            dg_ChucVu.DataSource = null;
            bChucVu.hienThiDsChucVu(dg_ChucVu);
        }

        private void dg_ChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dg_ChucVu.Rows.Count)
            {
                txtTenChucVu.Text = dg_ChucVu.Rows[e.RowIndex].Cells[1].Value.ToString();
                manv = Int32.Parse(dg_ChucVu.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtTenChucVu.Text == "")
                MessageBox.Show("Vui lòng điền tên chức vụ!!");
            else
            {
                ChucVu cv = new ChucVu();
                cv.TenChucVu = txtTenChucVu.Text;
                if (bChucVu.themChucVu(cv))
                {
                    MessageBox.Show("Thêm chức vụ thành công !!");
                    bChucVu.hienThiDsChucVu(dg_ChucVu);
                }
                else
                {
                    MessageBox.Show("Thêm chức vụ thất bại");
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (txtTenChucVu.Text == "")
            {
                MessageBox.Show("Tên chức cần sửa đang để trống !!");
            }
            else
            {
                ChucVu cv = new ChucVu();
                cv.TenChucVu = txtTenChucVu.Text;
                if (bChucVu.suaChucVu(manv,cv))
                {
                    MessageBox.Show("Sửa chức vụ thành công !!");
                    bChucVu.hienThiDsChucVu(dg_ChucVu);
                }
                else
                {
                    MessageBox.Show("Sửa chức vụ thất bại");
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (bChucVu.xoaChucVu(manv))
            {
                MessageBox.Show("Xóa chức vụ thành công.");
                bChucVu.hienThiDsChucVu(dg_ChucVu);
            }
            else
            {
                MessageBox.Show("Xóa chức thất bại.");
            }
        }
    }
}
