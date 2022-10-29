using KT.Model;
using KT.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT.Services
{
    internal class TenGoiService
    {
        public static List<TenGoiViewModel> GetList()
        {
            var db = new AppDBContext();
            var rs = db.TenGois.Select(e => new TenGoiViewModel
            {
                ID = e.ID,
                DiaChi = e.DiaChi,
                Email = e.Email,
                HoTen = e.TenGoi1,
                ID_Nhom = e.ID,
                SoDienThoai = e.Sodienthoai,

            }).ToList();

            return rs;
        }

        public static List<TenGoiViewModel> GetList(int ID)
        {
            var db = new AppDBContext();
            var rs = db.TenGois
                .Where(e => e.ID == ID)
                .Select(e => new TenGoiViewModel
                {
                    ID = e.ID,
                    DiaChi = e.DiaChi,
                    Email = e.Email,
                    HoTen = e.TenGoi1,
                    ID_Nhom = e.ID,
                    SoDienThoai = e.Sodienthoai,

                }).ToList();

            return rs;
        }

        public static KetQua AddTenGoi(TenGoi TG)
        {
            var db = new AppDBContext();
            var count = db.TenGois.Where(e => e.ID == TG.ID).Count();
            if (count > 0)
            {
                return 0;
            }
            else
            {
                db.TenGois.Add(TG);
                db.SaveChanges();
                return KetQua.ThanhCong;
            }
        }

        public static KetQua UpdateSinhVien(TenGoiViewModel TG)
        {
            var db = new AppDBContext();
            var TenGoi = db.TenGois.Where(e => e.ID == TG.ID).FirstOrDefault();
            TenGoi.ID = TG.ID;
            TenGoi.DiaChi = TG.DiaChi;
            TG.Email = TG.Email;
            TG.HoTen = TG.HoTen;
            TG.ID_Nhom = TG.ID;
            TG.SoDienThoai = TG.SoDienThoai;
            db.SaveChanges();
            return KetQua.ThanhCong;
        }

        public static KetQua RemoveSinhVien(TenGoiViewModel TG)
        {
            var db = new AppDBContext();
            var TGs = db.TenGois.Where(e => e.ID == TG.ID).FirstOrDefault();
            db.TenGois.Remove(TGs);
            db.SaveChanges();

            return KetQua.ThanhCong;
        }

        internal static KetQua LienLac()
        {
            throw new NotImplementedException();
        }
    }
}
