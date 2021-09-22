using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_demo.DAO
{
    class DAO_LoaiSanPham
    {
        QLCuaHangBanhNgotEntities db;
        public DAO_LoaiSanPham()
        {
            db = new QLCuaHangBanhNgotEntities();
        }

        public dynamic layDSLoaiSP()
        {
            var sp = db.LoaiSPs.Select(s => new { s.MaLoaiSP, s.TenLoaiSP}).ToList();
            return sp;
        }

        public void themLoaiSP(LoaiSP lsp)
        {
            db.LoaiSPs.Add(lsp);
            db.SaveChanges();
        }

        public void capNhatSP(int maSP, LoaiSP lsp)
        {
            LoaiSP l = db.LoaiSPs.Where(w => w.MaLoaiSP == maSP).Select(s => s).FirstOrDefault();
            l.TenLoaiSP = lsp.TenLoaiSP;
            db.SaveChanges();
        }

        public void xoaSP(int maSP)
        {
            LoaiSP l = db.LoaiSPs.Find(maSP);
            db.LoaiSPs.Remove(l);
            db.SaveChanges();
        }
    }
}
