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
    public partial class FThanhToan : Form
    {
        public int mahd;
        public int maban;
        BUS_HoaDon bHoaDon;
        BUS_Ban bBan;
        public FThanhToan()
        {
            InitializeComponent();
            bHoaDon = new BUS_HoaDon();
            bBan = new BUS_Ban();
        }
        private void loadDSCTHD()
        {           
            gv_hoadon.DataSource = null;
            bHoaDon.hienThiDSCTHD(gv_hoadon, mahd);
            gv_hoadon.Columns[0].Width = (int)(gv_hoadon.Width * 0.35);
            gv_hoadon.Columns[1].Width = (int)(gv_hoadon.Width * 0.2);
            gv_hoadon.Columns[2].Width = (int)(gv_hoadon.Width * 0.15);
            gv_hoadon.Columns[3].Width = (int)(gv_hoadon.Width * 0.15);
        }
        private void FThanhToan_Load(object sender, EventArgs e)
        {
            double tongtien = 0;
            loadDSCTHD();
            foreach(CTHD cthd in bHoaDon.hienThiDSCTHD2(mahd))
            {
                tongtien += (double)(cthd.SoLuong * cthd.DonGia * ((100 - cthd.GiamGia) / 100));
            }
            txttongtien.Text = tongtien.ToString();
        }
    
        private void btthanhtoan_Click(object sender, EventArgs e)
        {
            HoaDon hd = bHoaDon.layTTHoaDon(mahd);
            hd.TrangThaiTT = 1;
            if (bHoaDon.SuaTTHD(hd))
            {
                Ban b = bBan.layTTBan(maban);
                b.TrangThai = "Trống";
                if (bBan.SuaBan(b))
                { 
                    MessageBox.Show("Thanh toán thành công");
                    FQuanLyDatHang.ktThanhToan = true;
                    this.Close();
                }
                else
                    MessageBox.Show("Có lỗi xảy ra trong quá trình thanh toán. Vui lòng kiểm tra và thử lại sau!");
            }
            else
                MessageBox.Show("Có lỗi xảy ra trong quá trình thanh toán. Vui lòng kiểm tra và thử lại sau!");
        }
    }
}
