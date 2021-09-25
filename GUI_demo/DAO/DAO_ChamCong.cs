using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_demo.DAO
{
    class DAO_ChamCong
    {
        QLCuaHangBanhNgotEntities db;

        public DAO_ChamCong()
        {
            db = new QLCuaHangBanhNgotEntities();
        }

        public void themChamCong(BangChamCong chamCong)
        {
            db.BangChamCongs.Add(chamCong);
            db.SaveChanges();
        }

        public void ketThucCa(BangChamCong chamCong)
        {
            BangChamCong bcc = db.BangChamCongs.Find(chamCong.MaNV, chamCong.NgayLamViec, chamCong.GioBatDau);
            bcc.GioKetThuc = chamCong.GioKetThuc;
            db.SaveChanges();
        }

        public BangChamCong kiemTraKetThuc(BangChamCong chamCong)
        {
            return db.BangChamCongs.Find(chamCong.MaNV, chamCong.NgayLamViec, chamCong.GioBatDau);
        }

        public dynamic kiemTraChamCongTonTai(BangChamCong chamCong)
        {
            var bcc = db.BangChamCongs.Where(w => w.MaNV == chamCong.MaNV)
                .Where(w => w.NgayLamViec == w.NgayLamViec)
                .Select(s => s).ToList();
            return bcc;
        }
    }
}
