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
        BUS_HoaDon bHoaDon;
       
        bool ktClick;
        int maBanLonNhat = 0;
        int maBanClick;
        public FQuanLyDatHang()
        {
            InitializeComponent();
            bBan = new BUS_Ban();
            bHoaDon = new BUS_HoaDon();
        }

        private void hienThiDSCTHD(int mahd)
        {
            try
            {
                gV_CTHD.DataSource = null;
                bHoaDon.hienThiDSCTHD(gV_CTHD, mahd);
                gV_CTHD.Columns[0].Width = (int)(gV_CTHD.Width * 0.35);
                gV_CTHD.Columns[1].Width = (int)(gV_CTHD.Width * 0.2);
                gV_CTHD.Columns[2].Width = (int)(gV_CTHD.Width * 0.1);
                gV_CTHD.Columns[3].Width = (int)(gV_CTHD.Width * 0.2);
            }
            catch (Exception)
            {

            }
        }
        public void loadDSBan()
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Ban b in bBan.layDSBan())
            {
                maBanLonNhat = b.MaBan;
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
            ktClick = true;
            maBanClick = ((sender as Button).Tag as Ban).MaBan;
            
            hienThiDSCTHD(bHoaDon.layTTHoaDonChuaThanhToan(maBanClick).MaHD);
            
        }
        private void btthemban_Click(object sender, EventArgs e)
        {
            ktClick = false;
            int sl = int.Parse(Soban.Value.ToString());
            for(int i = maBanLonNhat + 1; i < maBanLonNhat + 1 + sl; i++)
            {
                Ban b = new Ban();
                b.MaBan = i;
                b.TrangThai = "Trống";

                bBan.TaoBan(b);
            }
            loadDSBan();
        }

        private void btXoaBan_Click(object sender, EventArgs e)
        {
            if (ktClick)
            {
                try
                {
                    Ban b = bBan.layTTBan(maBanClick);
                    if (bBan.XoaBan(b))
                    {
                        MessageBox.Show("Xóa bàn thành công");
                        loadDSBan();
                    }
                    else
                        MessageBox.Show("Xóa bàn thất bại");
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa bàn thất bại");
                }
                ktClick = false;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bàn để xóa!");
            }
        }

        private void FQuanLyDatHang_Load(object sender, EventArgs e)
        {
            loadDSBan();
            flowLayoutPanel1.AutoScroll = true;
        }

        private void btThem_Click(object sender, EventArgs e)
        {

        }

        private void btXoa_Click(object sender, EventArgs e)
        {

        }

        private void btSua_Click(object sender, EventArgs e)
        {

        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {

        }
    }
}
