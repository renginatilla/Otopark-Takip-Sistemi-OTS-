using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otopark1.DAL
{
    class HelperAdmin
    {
        public static Admin GetAdmin(string kullaniciad, string sifre)
        {
            using (OtoparkEntities1 contex=new OtoparkEntities1())
            {
                return contex.Admin.Where(x => x.KullaniciAdi == kullaniciad && x.KullaniciSifre == sifre).FirstOrDefault();
            }
        }
    }
}
