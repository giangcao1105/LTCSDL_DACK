using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_demo.GUI
{
    class DAO_TaiKhoan
    {
        QLCuaHangBanhNgotEntities db;

        public DAO_TaiKhoan()
        {
            db = new QLCuaHangBanhNgotEntities();
        }

        public bool kiemTraTKTonTai(String tk)
        {
            bool kq = false;
            Account t = db.Accounts.FirstOrDefault(s => s.Username == tk);
            if (t != null)
                kq = true;
            return kq;
        }

        public bool kiemTraDN(String tk, String mk)
        {
            bool kq = false;
            Account t = db.Accounts.FirstOrDefault(s => s.Username == tk && s.Password == mk);
            if (t != null)
                kq = true;
            return kq;
        }

        public void ThemTK(Account tk)
        {
            db.Accounts.Add(tk);
            db.SaveChanges();
        }

        public void SuaTK(Account tk)
        {
            Account o = db.Accounts.Find(tk.Username);
            o.Password = tk.Password;
            db.SaveChanges();
        }

        public void XoaTK(Account tk)
        {
            Account o = db.Accounts.Find(tk.Username);
            db.Accounts.Remove(o);
            db.SaveChanges();
        }
    }
}
