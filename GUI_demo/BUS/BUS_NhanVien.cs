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
    class BUS_NhanVien
    {
        DAO_NhanVien dNV;
        BUS_TaiKhoan bTK;
        public BUS_NhanVien()
        {
            dNV = new DAO_NhanVien();
            bTK = new BUS_TaiKhoan();
        }

        public NhanVien layTTNV(int manv)
        {
            return dNV.layTTNV(manv);
        }

        public bool TaoNV(NhanVien nv)
        {
            try
            {
                dNV.ThemNV(nv);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SuaTTNV(NhanVien nv)
        {
            if (dNV.KiemTraNV(nv))
            {
                try
                {
                    dNV.SuaTTNV(nv);
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

        public bool XoaNV(NhanVien nv)
        {
            if (dNV.KiemTraNV(nv))
            {
                try
                {
                    if (bTK.XoaTK(bTK.layTTTK(nv.MaNV)))
                    {
                        dNV.XoaNV(nv);
                        return true;
                    }
                    else
                        return false;
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

        public void hienThiDSNV(DataGridView dgv)
        {
            dgv.DataSource = dNV.hienThiDSNV();
        }
    }
}
