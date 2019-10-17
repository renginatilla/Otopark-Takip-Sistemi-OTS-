using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using otopark1.Model;

namespace otopark1.DAL
{
    class HelperTarife
    {
        public static Tarife GetTarife(int id)
        {
            using (OtoparkEntities1 contex=new OtoparkEntities1())
            {
                return contex.Tarife.Where(x => x.AracTipi == id).FirstOrDefault();
            }
        }
        //public static TarifeModel GetTarifeModel(int id)
        //{
        //    using (OtoparkEntities1 contex=new OtoparkEntities1())
        //    {
        //        var sorgu= contex.Tarife.Where(x => x.AracTipi == id).FirstOrDefault();
        //        TarifeModel tarife = new TarifeModel();
        //        tarife.AracTipi = sorgu.AracTipi;
        //        tarife.Tip = sorgu.Tip;
        //        tarife.Fiyat = sorgu.Fiyat;
        //        tarife.TarifeTipi = sorgu.TarifeTipi;
        //        tarife.arac.AracID=sorgu.Arac.
        //    }
           
        //}
    }
}
