using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_demo.DAO
{ 
    class DAO_NhanVien
    {
        QLCuaHangBanhNgotEntities db;
        public DAO_NhanVien()
        {
            db = new QLCuaHangBanhNgotEntities();
        }

        public bool KiemTraNV(NhanVien nv)
        {
            NhanVien o = db.NhanViens.Find(nv.MaNV);
            if (o != null)
                return true;
            return false;
        }

        public NhanVien layTTNV(int manv)
        {
            NhanVien nv = db.NhanViens.Where(s => s.MaNV == manv).FirstOrDefault();

            return nv;
        }

        public void ThemNV(NhanVien nv)
        {
            db.NhanViens.Add(nv);
            db.SaveChanges();
        }

        public void SuaTTNV(NhanVien nv)
        {
            NhanVien e = db.NhanViens.Find(nv.MaNV);
            e.HoTenNV = nv.HoTenNV;
            e.GioiTinh = nv.GioiTinh;
            e.MaChucVu = nv.MaChucVu;
            e.NgaySinhNV = nv.NgaySinhNV;
            e.SDTNV = nv.SDTNV;
            e.DiaChiNV = nv.DiaChiNV;
            e.QueQuanNV = nv.QueQuanNV;

            db.SaveChanges();
        }

        public void XoaNV(NhanVien nv)
        {
            NhanVien e = db.NhanViens.Find(nv.MaNV);
            db.NhanViens.Remove(e);
            db.SaveChanges();
        }

        public dynamic hienThiDSNV()
        {
            var ds = db.NhanViens.Select(s => new { 
            
                s.MaNV,
                s.HoTenNV,
                s.GioiTinh,
                s.ChucVu.TenChucVu,
                s.NgaySinhNV,
                s.SDTNV,
                s.DiaChiNV,
                s.QueQuanNV
            }).ToList();
            return ds;
        }
    }
}
