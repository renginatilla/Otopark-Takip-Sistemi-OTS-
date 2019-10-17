using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using otopark1.Interface;
using otopark1.Model;
namespace otopark1.DAL
{
    class HelperArac : IArac
    {
        public bool CUD(Arac arac, EntityState state)
        {
            using (OtoparkEntities1 contex=new OtoparkEntities1())
            {
                contex.Entry(arac).State = state;
                if (contex.SaveChanges() > 0)
                {
                    return true;
                }
                else
                    return false;
            }
        }
        public static Arac GetArac(int aracid)
        {
            using (OtoparkEntities1 contex=new OtoparkEntities1())
            {
                return contex.Arac.Where(x => x.AracID == aracid).FirstOrDefault();
            }
        }
        public static List<Arac> GetAracList()
        {
            using (OtoparkEntities1 contex=new OtoparkEntities1())
            {
                return contex.Arac.ToList();
            }
        }
        public static List<AracModel> AracModelList()
        {
            using (OtoparkEntities1 contex=new OtoparkEntities1())
            {
                var araclist = contex.Arac.ToList();
                List<AracModel> aml = new List<AracModel>();
                foreach (var item in araclist)
                {
                    AracModel arac = new AracModel();
                    arac.AracID = item.AracID;
                    arac.AracMarka = item.AracMarka;
                    arac.AracModel1 = item.AracModel;
                    arac.AracPlaka = item.AracPlaka;
                    arac.AracRenk = item.AracRenk;
                    arac.musteri.MusteriID = item.Musteri.MusteriID;
                    arac.musteri.MusteriAd = item.Musteri.MusteriAd;
                    arac.musteri.MusteriSoyad = item.Musteri.MusteriSoyad;
                    arac.tarife.AracTipi = item.Tarife.AracTipi;
                    arac.tarife.Tip = item.Tarife.Tip;
                    aml.Add(arac);
                }
                return aml;
            }
        }
        public static AracModel GetAracModel(int id)
        {
            using (OtoparkEntities1 contex=new OtoparkEntities1())
            {
                var sorgu = contex.Arac.Where(x => x.AracID == id).FirstOrDefault();
                AracModel arac = new AracModel();
                arac.AracID = sorgu.AracID;
                arac.AracPlaka = sorgu.AracPlaka;               
                arac.tarife.AracTipi = sorgu.Tarife.AracTipi;
                arac.tarife.Tip = sorgu.Tarife.Tip;
                arac.tarife.Fiyat = sorgu.Tarife.Fiyat;
                arac.tarife.TarifeTipi = sorgu.Tarife.TarifeTipi;
                return arac;
            }
        }

        
    }
}
