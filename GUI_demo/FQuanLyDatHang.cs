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
        BUS_LoaiSanPham bLoaiSP;
        BUS_SanPham bSP;

        public int manv;
        bool ktClick, ktHoaDon;
        int maBanLonNhat = 0;
        int maBanClick;
        int maHDClick = -1;
        public FQuanLyDatHang()
        {
            InitializeComponent();
            bBan = new BUS_Ban();
            bHoaDon = new BUS_HoaDon();
            bLoaiSP = new BUS_LoaiSanPham();
            bSP = new BUS_SanPham();
        }

        private void hienThiDSCTHD(int mahd)
        {
            gV_CTHD.DataSource = null;
            bHoaDon.hienThiDSCTHD(gV_CTHD, mahd);
            gV_CTHD.Columns[0].Width = (int)(gV_CTHD.Width * 0.35);
            gV_CTHD.Columns[1].Width = (int)(gV_CTHD.Width * 0.2);
            gV_CTHD.Columns[2].Width = (int)(gV_CTHD.Width * 0.15);
            gV_CTHD.Columns[3].Width = (int)(gV_CTHD.Width * 0.15);
        }

        public void kiemTraCTHD()       {
            if(bHoaDon.hienThiDSCTHD2(maHDClick).Count == 0)
            {
                try
                {
                    bHoaDon.XoaHD(bHoaDon.layTTHoaDon(maHDClick));
                    Ban b = bBan.layTTBan(maBanClick);
                    b.TrangThai = "Trống";
                    bBan.SuaBan(b);
                    loadDSBan();
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi");
                }
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

            if (bHoaDon.layTTHoaDonChuaThanhToan(maBanClick) != null)
            {
                maHDClick = bHoaDon.layTTHoaDonChuaThanhToan(maBanClick).MaHD;
                ktHoaDon = true;
                hienThiDSCTHD(maHDClick);
            }
            else
            {
                maHDClick = -1;
                gV_CTHD.DataSource = null;
                ktHoaDon = false;
            }

            bLoaiSP.hienThiDSLoaiSP(cbdanhmuc);
            bSP.hienThiDSSP2(cbten, int.Parse(cbdanhmuc.SelectedValue.ToString()));
            DSMON.Text = "Danh sách món ăn của bàn: " + maBanClick;
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
            DSMON.Text = "Danh sách món ăn của bàn:";
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
                        DSMON.Text = "Danh sách món ăn của bàn:";
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
            try
            {
                bool flag = true;

                if (!ktHoaDon)
                {
                    HoaDon hd = new HoaDon();
                    hd.MaNV = manv;
                    hd.MaBan = maBanClick;
                    DateTime date = DateTime.Now;
                    DateTime d1 = new DateTime(date.Year, date.Month, date.Day);
                    hd.NgayBan = d1;
                    hd.TrangThaiTT = 0;

                    bHoaDon.ThemHD(hd);
                    Ban b = bBan.layTTBan(maBanClick);
                    b.TrangThai = "Có người";
                    bBan.SuaBan(b);
                    maHDClick = hd.MaHD;
                    ktHoaDon = true;
                    loadDSBan();
                }

                CTHD cthd = new CTHD();
                cthd.MaHD = maHDClick;
                cthd.MaSP = int.Parse(cbten.SelectedValue.ToString());
                cthd.SoLuong = int.Parse(numericsoluongdoan.Value.ToString());
                if (txtGiamGia.Text != "")
                    cthd.GiamGia = double.Parse(txtGiamGia.Text);
                else
                    cthd.GiamGia = 0;
                cthd.DonGia = bSP.layTTSP(int.Parse(cbten.SelectedValue.ToString())).DonGia;
                numericsoluongdoan.Value = 1;

                foreach(CTHD ct in bHoaDon.hienThiDSCTHD2(maHDClick))
                {
                    if(ct.MaSP == cthd.MaSP)
                    {
                        cthd.SoLuong += ct.SoLuong;
                        flag = false;
                        if (bHoaDon.SuaCTHD(cthd))
                        {
                            MessageBox.Show("Thêm CTHD thành công");
                            hienThiDSCTHD(maHDClick);
                        }
                        else
                            MessageBox.Show("Thêm CTHD thất bại");
                        break;
                    }
                }

                if (flag)
                {
                    if (bHoaDon.ThemCTHD(cthd))
                    {
                        MessageBox.Show("Thêm CTHD thành công");
                        hienThiDSCTHD(maHDClick);
                    }
                    else
                        MessageBox.Show("Thêm CTHD thất bại"); 
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm CTHD  thất bại");
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                CTHD cthd = new CTHD();
                cthd.MaHD = maHDClick;
                cthd.MaSP = int.Parse(cbten.SelectedValue.ToString());
                cthd.SoLuong = int.Parse(numericsoluongdoan.Value.ToString());
                if (txtGiamGia.Text != "")
                    cthd.GiamGia = double.Parse(txtGiamGia.Text);
                else
                    cthd.GiamGia = 0;
                cthd.DonGia = bSP.layTTSP(int.Parse(cbten.SelectedValue.ToString())).DonGia;

                if (numericsoluongdoan.Value == 0)
                {
                    if (bHoaDon.XoaCTHD(cthd))
                    {
                        MessageBox.Show("Sửa thông tin CTHD thành công");
                        hienThiDSCTHD(maHDClick);
                        kiemTraCTHD();
                    }
                    else
                        MessageBox.Show("Sửa thông tin CTHD thất bại");
                }
                else
                {
                    if (bHoaDon.SuaCTHD(cthd))
                    {
                        MessageBox.Show("Sửa thông tin CTHD thành công");
                        hienThiDSCTHD(maHDClick);
                    }
                    else
                        MessageBox.Show("Sửa thông tin CTHD thất bại");
                }
            }
            catch
            {
                MessageBox.Show("Sửa thông tin CTHD thất bại");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                CTHD cthd = new CTHD();
                cthd.MaHD = maHDClick;
                cthd.MaSP = int.Parse(cbten.SelectedValue.ToString());
                cthd.SoLuong = int.Parse(numericsoluongdoan.Value.ToString());
                if (txtGiamGia.Text != "")
                    cthd.GiamGia = double.Parse(txtGiamGia.Text);
                else
                    cthd.GiamGia = 0;
                cthd.DonGia = bSP.layTTSP(int.Parse(cbten.SelectedValue.ToString())).DonGia;

                if (bHoaDon.XoaCTHD(cthd))
                {
                    MessageBox.Show("Xóa thông tin CTHD thành công");
                    hienThiDSCTHD(maHDClick);
                    kiemTraCTHD();
                }
                else
                    MessageBox.Show("Xóa thông tin CTHD thất bại");
            }
            catch
            {
                MessageBox.Show("Xóa thông tin CTHD thất bại");
            }
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            if (ktClick && maHDClick != -1 && bHoaDon.hienThiDSCTHD2(maHDClick).Count > 0)
            {
                FThanhToan f = new FThanhToan();
                f.Show();
            }
            else
                MessageBox.Show("Vui lòng chọn bàn để thanh toán!");
        }

        private void gV_CTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= gV_CTHD.Rows.Count)
            {               
                foreach(CTHD cthd in bHoaDon.hienThiDSCTHD2(maHDClick))
                {
                    SanPham sp = bSP.layTTSP(cthd.MaSP);
                    if (gV_CTHD.Rows[e.RowIndex].Cells[0].Value.ToString().Equals(sp.TenSP))
                    {
                        cbdanhmuc.SelectedValue = sp.MaLoaiSP;
                        cbten.SelectedValue = sp.MaSP;
                        numericsoluongdoan.Value = decimal.Parse(gV_CTHD.Rows[e.RowIndex].Cells[2].Value.ToString());
                        txtGiamGia.Text = gV_CTHD.Rows[e.RowIndex].Cells[3].Value.ToString();
                    }
                }
            }
        }

        private void cbdanhmuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (bSP.layDSSP(int.Parse(cbdanhmuc.SelectedValue.ToString())) != null)
                    bSP.hienThiDSSP2(cbten, int.Parse(cbdanhmuc.SelectedValue.ToString()));
                else
                {
                    cbten.DataSource = null;
                    cbten.Text = "";
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
