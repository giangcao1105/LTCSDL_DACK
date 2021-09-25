using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_demo.DAO;

namespace GUI_demo.BUS
{
    class BUS_SanPham
    {
        DAO_SanPham dSanPham;
        public BUS_SanPham()
        {
            dSanPham = new DAO_SanPham();
        }

        public void hienThiDSSP(DataGridView dgv)
        {
            dgv.DataSource = dSanPham.hienThiDSSP();
        }
        public void hienThiDSSP(ComboBox cb)
        {
            cb.DataSource = dSanPham.hienThiDSSP2();
            cb.DisplayMember = "TenSP";
            cb.ValueMember = "MaSP";
        }
        public dynamic layDSSP(int maloai)
        {
            return dSanPham.hienThiDSSP3(maloai);
        }
        public SanPham layTTSP(int masp)
        {
            return dSanPham.layTTSP(masp);
        }

        public void hienThiDSSP2(ComboBox cb, int maloai)
        {
            cb.DataSource = dSanPham.hienThiDSSP3(maloai);
            cb.DisplayMember = "TenSP";
            cb.ValueMember = "MaSP";
        }
        public void layLoaiSP(ComboBox cb, int maSP)
        {
            cb.DataSource = dSanPham.hienThiLoaiSP(maSP);
            cb.DisplayMember = "TenLoaiSP";
            cb.ValueMember = "MaLoaiSP";
        }


        public bool themSanPhan(SanPham sp)
        {
            //using (var trac = new TransactionScope())
            {
                try
                {
                    dSanPham.themSP(sp);
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }
        }

        public bool capNhatSanPham(int maSp, SanPham sp)
        {
            try
            {
                dSanPham.capNhatSP(maSp, sp);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool xoaSanPham(int maSp)
        {
            try
            {
                dSanPham.xoaSP(maSp);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public void hienThiDSSPTimKiem(DataGridView dgv, String str)
        {
            if (str == "")
            {
                dgv.DataSource = dSanPham.hienThiDSSP();
            }
            else
                dgv.DataSource = dSanPham.timKiemSP(str);
        }
    }
}
