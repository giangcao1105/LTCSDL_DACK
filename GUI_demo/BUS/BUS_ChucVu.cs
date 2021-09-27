using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_demo.DAO;

namespace GUI_demo.BUS
{
    class BUS_ChucVu
    {
        DAO_ChucVu dChucVu;
        public BUS_ChucVu()
        {
            dChucVu = new DAO_ChucVu();
        }

        public void hienThiDsChucVu(ComboBox cb)
        {
            cb.DataSource = dChucVu.hienThiDSChucVu();
            cb.DisplayMember = "TenChucVu";
            cb.ValueMember = "MaChucVu";
        }

        public void hienThiDsChucVu(DataGridView dgv)
        {
            dgv.DataSource = dChucVu.hienThiDSChucVu();
        }

        public bool themChucVu(ChucVu cv)
        {
            try
            {
                dChucVu.themChucVu(cv);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool suaChucVu(int macv, ChucVu cv)
        {
            try
            {
                dChucVu.suaChucVu(macv, cv);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool xoaChucVu(int macv)
        {
            try
            {
                dChucVu.xoaChucVu(macv);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
