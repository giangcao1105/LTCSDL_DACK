using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_demo.DAO
{
    class DAO_ChucVu
    {
        QLCuaHangBanhNgotEntities db;

        public DAO_ChucVu()
        {
            db = new QLCuaHangBanhNgotEntities();
        }

        public dynamic hienThiDSChucVu()
        {
            var ds = db.ChucVus.Select(s => s).ToList();
            return ds;
        }

        public void suaChucVu(int maCV, ChucVu cv)
        {
            ChucVu cvu = db.ChucVus.Where(w => w.MaChucVu == maCV).Select(s => s).FirstOrDefault();
            cvu.TenChucVu = cv.TenChucVu;
            db.SaveChanges();
        }

        public void xoaChucVu(int maCV)
        {
            ChucVu cv = db.ChucVus.Find(maCV);
            db.ChucVus.Remove(cv);
            db.SaveChanges();
        }

        public void themChucVu(ChucVu cv)
        {
            db.ChucVus.Add(cv);
            db.SaveChanges();
        }
    }
}
