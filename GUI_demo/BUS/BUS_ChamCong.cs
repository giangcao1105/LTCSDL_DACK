using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_demo.DAO;

namespace GUI_demo.BUS
{
    class BUS_ChamCong
    {
        DAO_ChamCong dChamCong;
        public BUS_ChamCong()
        {
            dChamCong = new DAO_ChamCong();
        }

        public bool themChamCong(BangChamCong chamCong)
        {
            try
            {
                dChamCong.themChamCong(chamCong);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int capNhatKetThucCa(BangChamCong chamCong)
        {
            try
            {
                if (dChamCong.kiemTraKetThuc(chamCong) != null)
                {
                    dChamCong.ketThucCa(chamCong);
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public bool kiemTraChamCongTonTai(BangChamCong chamCong)
        {
            if (dChamCong.kiemTraChamCongTonTai(chamCong) == null)
                return true;
            else
            {
                foreach (BangChamCong b in dChamCong.kiemTraChamCongTonTai(chamCong))
                {
                  
                    if (b.GioKetThuc == null || b.GioKetThuc.ToString() == "00:00:00")
                        return false;
                }
            }
            return true;
        }
    }
}
