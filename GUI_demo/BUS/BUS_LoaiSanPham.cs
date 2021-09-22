using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_demo.DAO;
using System.Transactions;

namespace GUI_demo.BUS
{
    class BUS_LoaiSanPham
    {
        DAO_LoaiSanPham dLoaiSanPham;
        public BUS_LoaiSanPham()
        {
            dLoaiSanPham = new DAO_LoaiSanPham();
        }

        public void hienThiDSLoaiSP(DataGridView dgv)
        {
            dgv.DataSource = dLoaiSanPham.layDSLoaiSP();
        }

        public bool themLoaiSanPhan(LoaiSP lsp)
        {
            //using (var trac = new TransactionScope())
            {
                try
                {
                    dLoaiSanPham.themLoaiSP(lsp);
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }
        }

        public bool capNhatSanPham(int maSp, LoaiSP lsp)
        {
            try
            {
                dLoaiSanPham.capNhatSP(maSp, lsp);
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
                dLoaiSanPham.xoaSP(maSp);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
