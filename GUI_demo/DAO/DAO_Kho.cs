using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_demo.DAO
{
    class DAO_Kho
    {
        QLCuaHangBanhNgotEntities db;
        public DAO_Kho()
        {
            db = new QLCuaHangBanhNgotEntities();
        }

        public dynamic hienThiKho()
        {
            var sp = db.Khoes.Select(s => new { 
                s.MaSP,
                s.SanPham.TenSP,
                s.NgayNhapSP,
                s.SoLuong,
                s.SanPham.LoaiSP.TenLoaiSP
            }).ToList();
            return sp;
        }
        public void themKho(Kho k)
        {
            db.Khoes.Add(k);
            db.SaveChanges();
        }

        public void capNhatKho(int maKho, DateTime ngayNhapHang, Kho k)
        {
            Kho kho = db.Khoes.Where(w => w.MaSP == maKho).Where(w => w.NgayNhapSP == ngayNhapHang).Select(s => s).FirstOrDefault();
            kho.SoLuong = k.SoLuong;
            db.SaveChanges();
        }

        public void xoaSP(int maKho, DateTime ngayNhapHang)
        {
            Kho l = db.Khoes.Find(maKho,ngayNhapHang);
            db.Khoes.Remove(l);
            db.SaveChanges();
        }

        public dynamic baoCaoKho()
        {
            var sp = db.Khoes.Select(s => new{ 
                s.MaSP,
                s.SanPham.TenSP,
                s.SoLuong,
                s.NgayNhapSP
            }).ToList();
            return sp;
        }

        public dynamic timKiemKho(String str)
        {
            var sp = db.Khoes.Where(w => w.SanPham.TenSP.Contains(str)).Select(s => new {
                s.MaSP,
                s.SanPham.TenSP,
                s.NgayNhapSP,
                s.SoLuong,
                s.SanPham.LoaiSP.TenLoaiSP
            }).ToList();
            return sp;
        }
    }
}
