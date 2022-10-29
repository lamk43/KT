using KT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT.ViewModel
{
    public class TenNhomViewModel
    {
        public int ID { get; set; }
        public string TenNhom { get; set; }


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
    }
}
