using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using otopark1.Interface;


namespace otopark1.DAL
{
    class HelperMusteri:IMusteri
    {
        
        public static Musteri GetMusteri(int musteriid)
        {
            using (OtoparkEntities1 contex=new OtoparkEntities1())
            {
                return contex.Musteri.Where(x => x.MusteriID == musteriid).FirstOrDefault();
            }
        }
        public static List<Musteri> GetMusteriList()
        {
            using (OtoparkEntities1 contex=new OtoparkEntities1())
            {
                return contex.Musteri.ToList();
            }
        }

        public  bool CUD(Musteri m, EntityState state)
        {
            using (OtoparkEntities1 contex = new OtoparkEntities1())
            {
                contex.Entry(m).State = state;
                if (contex.SaveChanges() > 0)
                {
                    return true;
                }

                return false;
            }
        }
      
        
    }
}
