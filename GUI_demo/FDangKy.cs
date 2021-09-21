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
    public partial class FDangKy : Form
    {
        BUS_NhanVien busNV;
        BUS_TaiKhoan busTK;
        public FDangKy()
        {
            InitializeComponent();
            busNV = new BUS_NhanVien();
            busTK = new BUS_TaiKhoan();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool ktNhap()
        {
            bool kq = true;
            if (txtTenTK.Text.Equals("") || txtMauKhau.Text.Equals("") || txtNLMatKhau.Text.Equals("") || txtTenNV.Text.Equals("") || txtSDT.Text.Equals(""))
                kq = false;
            return kq;
        }
        private void btDangky_Click(object sender, EventArgs e)
        {
            if (ktNhap())
            {
                NhanVien nv = new NhanVien();
                nv.HoTenNV = txtTenNV.Text;
                if (rdNam.Checked)
                    nv.GioiTinh = "Nam";
                else
                    nv.GioiTinh = "Nữ";
                nv.MaChucVu = int.Parse(cbChucVu.SelectedValue.ToString());
                nv.NgaySinhNV = dtpNgaySinh.Value;
                nv.SDTNV = txtSDT.Text;
                nv.DiaChiNV = null;
                nv.QueQuanNV = null;

                if (busNV.TaoNV(nv))
                {
                    Account tk = new Account();
                    tk.Username = txtTenTK.Text;
                    tk.Password = txtMauKhau.Text;                    
                    if (rdAdmin.Checked)
                        tk.LoaiTK = "Admin";
                    else
                        tk.LoaiTK = "Nhanvien";
                    tk.MaNV = nv.MaNV;

                    if(busTK.ThemTK(tk))
                    {
                        MessageBox.Show("Đã đăng ký thành công!");                       
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đăng ký thất bại. Vui lòng nhập lại thông tin");
                    }
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại. Vui lòng nhập lại thông tin");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần thiết");
            }
        }
    }
}
