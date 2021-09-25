using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_demo.DAO;

namespace GUI_demo.BUS
{
    class BUS_Kho
    {
        DAO_Kho dKho;
        public BUS_Kho()
        {
            dKho = new DAO_Kho();
        }
        public void hienThiKho(DataGridView dgv)
        {
            dgv.DataSource = dKho.hienThiKho();
        }
        public bool themKho(Kho k)
        {
            //using (var trac = new TransactionScope())
            {
                try
                {
                    dKho.themKho(k);
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }
        }

        public bool capNhatKho(int maSp, DateTime ngayNhap,Kho k)
        {
            try
            {
                dKho.capNhatKho(maSp, ngayNhap,k);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool xoaKho(int maSp,DateTime ngayNhap)
        {
            try
            {
                dKho.xoaSP(maSp,ngayNhap);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public dynamic baoCaoKho()
        {
            return dKho.baoCaoKho();
        }

        public void timKiemKho(DataGridView dgv,String str)
        {
                dgv.DataSource = dKho.timKiemKho(str);
        }
    }
}
