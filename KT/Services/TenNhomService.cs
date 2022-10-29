using KT.Model;
using KT.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT.Services
{
    internal class TenNhomService
    {
        public static List<TenNhomViewModel> GetList()
        {
            var db = new AppDBContext();
            var rs = db.TenNhoms.Select(e => new TenNhomViewModel
            {
                ID = e.ID,
                TenNhom = e.TenNhom1,
            }).ToList();

            return rs;
        }

        public static List<TenNhomViewModel> GetList(int id)
        {
            var db = new AppDBContext();
            var rs = db.TenNhoms
                .Where(e => e.ID == id)
                .Select(e => new TenNhomViewModel
                {
                    ID = e.ID,
                    TenNhom = e.TenNhom1,
                }).ToList();

            return rs;
        }

        public static KetQua AddNhom(TenNhom TN)
        {
            var db = new AppDBContext();
            var count = db.TenNhoms.Where(e => e.ID == TN.ID).Count();
            if (count > 0)
            {
                return 0;
            }
            else
            {
                db.TenNhoms.Add(TN);
                db.SaveChanges();
                return KetQua.ThanhCong;
            }
        }

        public static KetQua RemoveNhom(TenNhomViewModel TN)
        {
            var db = new AppDBContext();
            var tenNhom = db.TenNhoms.Where(e => e.ID == TN.ID).FirstOrDefault();
            db.TenNhoms.Remove(tenNhom);
            db.SaveChanges();

            return KetQua.ThanhCong;
        }
    }
}
