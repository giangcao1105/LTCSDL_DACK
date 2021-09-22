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
    }
}
