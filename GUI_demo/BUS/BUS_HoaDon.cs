using GUI_demo.DAO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_demo.BUS
{
    class BUS_HoaDon
    {
        DAO_HoaDon dHoaDon;

        public BUS_HoaDon()
        {
            dHoaDon = new DAO_HoaDon();
        }

        public HoaDon layTTHoaDon(int mahd)
        {
            return dHoaDon.layTTHoaDon(mahd);
        }
        public HoaDon layTTHoaDonChuaThanhToan(int maban)
        {
            return dHoaDon.layTTHoaDonChuaThanhToan(maban);
        }
        public bool ThemHD(HoaDon hd)
        {
            try
            {
                dHoaDon.ThemHoaDon(hd);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SuaTTHD(HoaDon hd)
        {
            if (dHoaDon.KiemTraHD(hd))
            {
                try
                {
                    dHoaDon.SuaHoaDon(hd);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool XoaHD(HoaDon hd)
        {
            if (dHoaDon.KiemTraHD(hd))
            {
                try
                {

                    foreach (CTHD cthd in dHoaDon.hienThiDSCTHD2(hd.MaHD))
                    {
                        try
                        {
                            XoaCTHD(cthd);
                        }
                        catch (Exception)
                        {
                            return false;
                        }
                    }
                    dHoaDon.XoaHoaDon(hd);
                    return true;                    
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public void hienThiDSHD(DataGridView dgv)
        {
            dgv.DataSource = dHoaDon.hienThiDSHD();
        }

        public void hienThiDSCTHD(DataGridView dgv, int mahd)
        {
            dgv.DataSource = dHoaDon.hienThiDSCTHD(mahd);
        }
        public List<CTHD> hienThiDSCTHD2(int mahd)
        {
            return dHoaDon.hienThiDSCTHD2(mahd);
        }
        public CTHD layTTCTHD(int mahd, int masp)
        {
            return dHoaDon.layTTCTHD(mahd, masp);
        }

        public bool ThemCTHD(CTHD cthd)
        {
            try
            {
                dHoaDon.ThemCTHD(cthd);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SuaCTHD(CTHD cthd)
        {
            if (dHoaDon.KiemTraCTHD(cthd))
            {
                try
                {
                    dHoaDon.SuaCTHD(cthd);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool XoaCTHD(CTHD cthd)
        {
            if (dHoaDon.KiemTraCTHD(cthd))
            {
                try
                {
                    dHoaDon.XoaCTHD(cthd);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
}
