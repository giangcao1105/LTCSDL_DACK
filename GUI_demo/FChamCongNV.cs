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
    public partial class FChamCongNV : Form
    {
        public int MaNV ;
        BUS_ChamCong bChamCong;
        public static TimeSpan gioChamCong;
        public FChamCongNV()
        {
            InitializeComponent();
            bChamCong = new BUS_ChamCong();
        }

        private void btChamCong_Click(object sender, EventArgs e)
        {
            BangChamCong bcc = new BangChamCong();
            bcc.MaNV = MaNV;
            bcc.NgayLamViec = DateTime.Today;
            bcc.GioBatDau = DateTime.Now.TimeOfDay;
            if (bChamCong.kiemTraChamCongTonTai(bcc))
            {
                if (bChamCong.themChamCong(bcc))
                {
                    gioChamCong = bcc.GioBatDau;
                    MessageBox.Show("Chấm công thành công");
                    lbChamCong.Text = "Chấm công thành công vào lúc: " + gioChamCong;
                }
                else
                {
                    MessageBox.Show("Chấm công thất bại.");
                }
            }
            else
            {
                MessageBox.Show("Chưa kết thúc ca, không cho phép chấm công.");
            }
        }

        private void btKtCa_Click(object sender, EventArgs e)
        {
            BangChamCong bcc = new BangChamCong();
            bcc.MaNV = MaNV;
            bcc.NgayLamViec = DateTime.Today;
            bcc.GioBatDau = gioChamCong;
            bcc.GioKetThuc = DateTime.Now.TimeOfDay;
            int flag = bChamCong.capNhatKetThucCa(bcc);
            if (flag == 1)
            {
                MessageBox.Show("Kết thúc ca thành công");
                lbChamCong.Text = "Kết thúc ca thành công vào lúc: " + bcc.GioKetThuc;
                gioChamCong = TimeSpan.Parse("00:00:00");
            }
            else if (flag == -1)
            {
                MessageBox.Show("Bạn chưa thực hiện chấm công.");
            }
            else
            {
                MessageBox.Show("Kết thúc ca thất bại.");
            }
        }
    }
}
