using GUI_demo.BUS;
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
    public partial class FDangNhap : Form
    {
        BUS_TaiKhoan busTK;
        public FDangNhap()
        {
            InitializeComponent();
            busTK = new BUS_TaiKhoan();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            String tk = txtTenTK.Text;
            String mk = txtMatKhau.Text;

            if (busTK.kiemTraDN(tk, mk))
            {
                MessageBox.Show("Đăng nhập thành công");
                Account taiKhoan = busTK.layThongTinTK(tk, mk);
                if(taiKhoan.LoaiTK.ToString().Equals("Admin"))
                {
                    FMainAdmin f = new FMainAdmin();
                    f.StartPosition = FormStartPosition.CenterScreen;
                    f.maNV = taiKhoan.MaNV;
                    f.Show();
                    this.Hide();

                }
                else
                {
                    FMainNhanVien f = new FMainNhanVien();
                    f.StartPosition = FormStartPosition.CenterScreen;
                    f.maNV = taiKhoan.MaNV;
                    f.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác, vui lòng thử lại!");
            }
        }

        private void btDangKy_Click(object sender, EventArgs e)
        {
            FDangKy f = new FDangKy();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void FDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
