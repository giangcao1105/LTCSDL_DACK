using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_demo.DAO
{
    class DAO_SanPham
    {
        QLCuaHangBanhNgotEntities db;
        public DAO_SanPham()
        {
            db = new QLCuaHangBanhNgotEntities();
        }
        public SanPham layTTSP(int masp)
        {
            return db.SanPhams.Where(s => s.MaSP == masp).FirstOrDefault();
        }

        public dynamic hienThiDSSP()
        {
            var sp = db.SanPhams.Select(s => new { 
                s.MaSP,
                s.TenSP,
                s.LoaiSP.TenLoaiSP,
                s.DonGia
            }).ToList();
            return sp;
        }

        public dynamic hienThiLoaiSP(int maSP)
        {
            var sp = db.SanPhams.Where(s => s.MaSP == maSP).Select(s => new { 
                s.LoaiSP.TenLoaiSP,
                s.LoaiSP.MaLoaiSP
            }).ToList();
            return sp;
        }

        public dynamic hienThiDSSP2()
        {
            var sp = db.SanPhams.Select(s => new {
                s.MaSP,
                s.TenSP,
                s.LoaiSP.TenLoaiSP,
                s.DonGia
            }).ToList();
            return sp;
        }
        public dynamic hienThiDSSP3(int maloai)
        {
            var sp = db.SanPhams.Where(s=>s.MaLoaiSP == maloai).Select(s =>s).ToList();
            return sp;
        }
        public void themSP(SanPham sp)
        {
            db.SanPhams.Add(sp);
            db.SaveChanges();
        }

        public void capNhatSP(int maSP, SanPham sp)
        {
            SanPham l = db.SanPhams.Where(w => w.MaSP == maSP).Select(s => s).FirstOrDefault();
            l.TenSP = sp.TenSP;
            l.MaLoaiSP = sp.MaLoaiSP;
            l.DonGia = sp.DonGia;
            db.SaveChanges();
        }
        public dynamic layDSSP()
        {
            var sp = db.SanPhams.Select(s => new
            {
                s.MaSP,
                s.TenSP
            }).ToList();
            return sp;
        }

        public void xoaSP(int maSP)
        {
            SanPham l = db.SanPhams.Find(maSP);
            db.SanPhams.Remove(l);
            db.SaveChanges();
        }

        public dynamic timKiemSP(String str)
        {
            var sp = db.SanPhams.Where(s => s.TenSP.Contains(str)).Select(s => new {
                s.MaSP,
                s.TenSP,
                s.LoaiSP.TenLoaiSP,
                s.DonGia
            }).ToList();
            return sp;
        }
    }
}
