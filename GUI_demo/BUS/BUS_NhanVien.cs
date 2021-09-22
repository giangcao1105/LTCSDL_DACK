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

        public BUS_NhanVien()
        {
            dNV = new DAO_NhanVien();
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
                    dNV.XoaNV(nv);
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

        public void hienThiDSNV(DataGridView dgv)
        {
            dgv.DataSource = dNV.hienThiDSNV();
        }
    }
}
