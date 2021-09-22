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
    public partial class FQuanLyDatHang : Form
    {
        BUS_Ban bBan;
        bool flag;
        public FQuanLyDatHang()
        {
            InitializeComponent();
            bBan = new BUS_Ban();
        }
        public void taobanan()
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Ban b in bBan.layDSBan())
            {
                Button bt = new Button();
                bt.Click += bt_click;// tạo sự kiện click cho button
                bt.Tag = b; // dùng để xác định ID của mỗi button
                bt.Width = 90;
                bt.Height = 90;
                bt.Text = b.MaBan + "\n" + b.TrangThai;
                if (b.TrangThai == "Trống")
                {
                    bt.BackColor = Color.WhiteSmoke;
                }
                else if (b.TrangThai == "Có người")
                {
                    bt.BackColor = Color.DarkRed;
                }
                flowLayoutPanel1.Controls.Add(bt);
            }
        }



        public void bt_click(object sender, EventArgs e)
        {
            flag = true;
            //idban = ((sender as Button).Tag as ThongTinBan).IDBAN;
            //tenban = ((sender as Button).Tag as ThongTinBan).TEN;
            //trangthaiban = ((sender as Button).Tag as ThongTinBan).TRANGTHAI;
            //DSMON.Text = "Danh sách món ăn của " + tenban;

            //ThongTinHoaDon thongTinHoaDon = new ThongTinHoaDon();
            //thongTinHoaDon.IDBAN = idban;
            //int sohoadonban = xuLyHoaDon.count_hoadon_ban(thongTinHoaDon);
            //if (sohoadonban == 0)
            //{
            //    thongTinHoaDon.IDNV = idnv;// lấy từ mã từ tài khoản nhân viên đăng nhập vào
            //    thongTinHoaDon.NGAYLAP = DateTime.Now;
            //    thongTinHoaDon.TRANGTHAI = "Chưa";
            //    xuLyHoaDon.insert_hoadon(thongTinHoaDon);
            //    taobanan();
            //}
            //idhd = xuLyHoaDon.load_IDHD_WITH_IDBAN(thongTinHoaDon);
            //Load_CTHD(idhd);
            //numericsoluongdoan.Value = 1;
        }
        private void btthemban_Click(object sender, EventArgs e)
        {

        }

        private void btXoaBan_Click(object sender, EventArgs e)
        {

        }
    }
}
