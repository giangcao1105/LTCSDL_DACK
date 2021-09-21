using GUI_demo.GUI;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_demo.BUS
{
    class BUS_TaiKhoan
    {
        DAO_TaiKhoan dTaiKhoan;

        public BUS_TaiKhoan()
        {
            dTaiKhoan = new DAO_TaiKhoan();
        }

        public bool kiemTraDN(String tk, String mk)
        {
            return dTaiKhoan.kiemTraDN(tk, mk);
        }
        public Account layThongTinTK(String tk, String mk)
        {
            return dTaiKhoan.layThongTinTK(tk, mk);
        }

        public bool ThemTK(Account tk)
        {
            try
            {
                dTaiKhoan.ThemTK(tk);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SuaTK(Account tk)
        {
            if (dTaiKhoan.kiemTraTKTonTai(tk.Username))
            {
                try
                {
                    dTaiKhoan.SuaTK(tk);
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

        public bool XoaTK(Account tk)
        {
            if (dTaiKhoan.kiemTraTKTonTai(tk.Username))
            {
                try
                {
                    dTaiKhoan.XoaTK(tk);
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
