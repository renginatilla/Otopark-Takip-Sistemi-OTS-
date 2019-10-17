using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using otopark1.Interface;

namespace otopark1.DAL
{
    class OdemeHelper : IOdeme
    {
        public bool CUD(Odeme odeme, EntityState state)
        {
            using (OtoparkEntities1 contex=new OtoparkEntities1())
            {
                contex.Entry(odeme).State = state;
                if (contex.SaveChanges() > 0)
                {
                    return true;
                }
                else
                    return false;
            }
        }
        public static int toplamkazanc()
        {
            using (OtoparkEntities1 contex=new OtoparkEntities1())
            {
                int toplam = 0;
                var a = contex.Odeme.ToList();
                foreach (var item in a)
                {
                    toplam += item.Odeme1.Value;
                }
                return toplam;
            }
        }
        public static List<Odeme> odemelist()
        {
            using (OtoparkEntities1 contex=new OtoparkEntities1())
            {
                return contex.Odeme.ToList();
            }
        }

    }
}
