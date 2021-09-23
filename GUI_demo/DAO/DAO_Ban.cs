using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_demo.DAO
{
    class DAO_Ban
    {
        QLCuaHangBanhNgotEntities db;

        public DAO_Ban()
        {
            db = new QLCuaHangBanhNgotEntities();
        }
        public bool KiemTraBan(Ban b)
        {
            Ban o = db.Bans.Find(b.MaBan);
            if (o != null)
                return true;
            return false;
        }

        public Ban layTTBan(int maBan)
        {
            return db.Bans.Where(s => s.MaBan == maBan).FirstOrDefault();
        }

        public void ThemBan(Ban b)
        {
            db.Bans.Add(b);
            db.SaveChanges();
        }

        public void SuaBan(Ban b)
        {
            Ban ban = db.Bans.Find(b.MaBan);
            ban.TrangThai = b.TrangThai;

            db.SaveChanges();
        }

        public void XoaBan(Ban b)
        {
            Ban ban = db.Bans.Find(b.MaBan);
            db.Bans.Remove(ban);
            db.SaveChanges();
        }

        public List<Ban> layDSBan()
        {
            List<Ban> ds = db.Bans.Select(s => s).ToList();
            return ds;
        }
    }
}
