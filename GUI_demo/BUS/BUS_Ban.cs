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
    class BUS_Ban
    {
        DAO_Ban dBan;

        public BUS_Ban()
        {
            dBan = new DAO_Ban();
        }

        public Ban layTTBan(int maBan)
        {
            return dBan.layTTBan(maBan);
        }

        public bool TaoBan(Ban b)
        {
            try
            {
                dBan.ThemBan(b);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SuaBan(Ban b)
        {
            if (dBan.KiemTraBan(b))
            {
                try
                {
                    dBan.SuaBan(b);
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

        public bool XoaBan(Ban b)
        {
            if (dBan.KiemTraBan(b))
            {
                try
                {
                    dBan.XoaBan(b);
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
        public List<Ban> layDSBan()
        {
            return dBan.layDSBan();
        }
    }
}
