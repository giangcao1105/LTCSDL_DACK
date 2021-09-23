using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_demo.DAO
{
    class DAO_HoaDon
    {
        QLCuaHangBanhNgotEntities db;

        public DAO_HoaDon()
        {
            db = new QLCuaHangBanhNgotEntities();
        }

        public HoaDon layTTHoaDon(int mahd)
        {
            return db.HoaDons.Where(s => s.MaHD == mahd).FirstOrDefault();
        }
        public HoaDon layTTHoaDonChuaThanhToan(int maban)
        {
            return db.HoaDons.Where(s => s.MaBan == maban && s.TrangThaiTT == 0).FirstOrDefault();
        }
        public void ThemHoaDon(HoaDon hd)
        {
            db.HoaDons.Add(hd);
            db.SaveChanges();
        }

        public void SuaHoaDon(HoaDon hd)
        {
            HoaDon hoaDon = db.HoaDons.Find(hd.MaHD);
            hoaDon.MaNV = hd.MaNV;
            hoaDon.MaBan = hd.MaBan;
            hoaDon.NgayBan = hd.NgayBan;
            hoaDon.TrangThaiTT = hd.TrangThaiTT;
            db.SaveChanges();
        }
        
        public void XoaHoaDon(HoaDon hd)
        {
            HoaDon hoaDon = db.HoaDons.Find(hd.MaHD);
            db.HoaDons.Remove(hoaDon);
            db.SaveChanges();
        }

        public dynamic hienThiDSHD()
        {
            var ds = db.HoaDons.Select(s => new {
                s.MaHD,
                s.NhanVien.HoTenNV,
                s.MaBan,
                s.NgayBan,
                s.TrangThaiTT
            }).ToList();
            return ds;
        }

        public bool KiemTraHD(HoaDon hd)
        {
            HoaDon o = db.HoaDons.Find(hd.MaHD);
            if (o != null)
                return true;
            return false;
        }

        public dynamic hienThiDSCTHD(int mahd)
        {
            var ds = db.CTHDs.Where(s => s.MaHD == mahd).Select(s => new {
                s.SanPham.TenSP,
                s.DonGia,
                s.SoLuong,
                s.GiamGia
            }).ToList();
            return ds;
        }
        public void ThemCTHD(CTHD cthd)
        {
            db.CTHDs.Add(cthd);
            db.SaveChanges();
        }

        public void SuaCTHD(CTHD cthd)
        {
            CTHD ct = db.CTHDs.Find(cthd.MaHD, cthd.MaSP);
            ct.SoLuong = cthd.SoLuong;
            ct.DonGia = cthd.DonGia;
            ct.GiamGia = cthd.GiamGia;
            db.SaveChanges();
        }

        public void XoaCTHD(CTHD cthd)
        {
            CTHD ct = db.CTHDs.Find(cthd.MaHD, cthd.MaSP);
            db.CTHDs.Remove(ct);
            db.SaveChanges();
        }

        public CTHD layTTCTHD(int mahd, int masp)
        {
            return db.CTHDs.Where(s => s.MaHD == mahd && s.MaSP == masp).FirstOrDefault();
        }

        internal bool KiemTraCTHD(CTHD cthd)
        {
            CTHD o = db.CTHDs.Find(cthd.MaHD, cthd.MaSP);
            if (o != null)
                return true;
            return false;
        }
    }
}
