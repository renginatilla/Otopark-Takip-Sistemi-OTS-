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
    class HelperOtoparkArac:IOtoparkArac
    {
        public static int GetAracOtoparkListbyotoparkid(int id)
        {
            int sayac = 0;
            using (OtoparkEntities1 contex=new OtoparkEntities1())
            {
                var a = contex.AracOtopark.ToList();
                foreach (var item in a)
                {
                    if ( (item.OtoparkID==id))
                    {
                        sayac++;
                        if ((item.GirisSaati != null) && (item.CikisSaati != null) && (sayac >0))
                        {
                            sayac--;
                        }
                    }                 
                }
                return sayac;
            }
        }
        
        public static AracOtopark GetAracOtopark(int id)
        {
            using (OtoparkEntities1 contex=new OtoparkEntities1())
            {
                return contex.AracOtopark.Where(x => x.AracOtoparkID == id).FirstOrDefault();
            }
        }

        public bool CUD(AracOtopark aracOtopark, EntityState state)
        {
            using (OtoparkEntities1 contex=new OtoparkEntities1())
            {
                contex.Entry(aracOtopark).State = state;
                if (contex.SaveChanges() > 0)
                {
                    return true;
                }
                else
                    return false;
            }
        }
        public static List<OtoparkAracModel> otoparkmodellist()
        {
            using (OtoparkEntities1 contex=new OtoparkEntities1())
            {
                var list = contex.AracOtopark.ToList();
                List<OtoparkAracModel> oaml = new List<OtoparkAracModel>();
                foreach (var item in list)
                {
                    OtoparkAracModel otopark = new OtoparkAracModel();
                    otopark.AracOtoparkID = item.AracOtoparkID;
                    otopark.GirisSaati = item.GirisSaati;
                    otopark.CikisSaati = item.CikisSaati;
                    otopark.otopark.OtoparkID = item.Otopark.OtoparkID;
                    otopark.arac.AracID = item.Arac.AracID;
                    otopark.arac.AracPlaka = item.Arac.AracPlaka;
                    otopark.musteri.MusteriID = item.Arac.Musteri.MusteriID;
                    otopark.musteri.MusteriAd = item.Arac.Musteri.MusteriAd;
                    otopark.musteri.MusteriSoyad = item.Arac.Musteri.MusteriSoyad;
                    oaml.Add(otopark);
                }
                return oaml;
            }
        }
        public static OtoparkAracModel GetOtoparkAracModel(int aracotoparkid)
        {
            using (OtoparkEntities1 contex=new OtoparkEntities1())
            {
                var sorgu = contex.AracOtopark.Where(x => x.AracOtoparkID == aracotoparkid).FirstOrDefault();
                OtoparkAracModel oam = new OtoparkAracModel();
                oam.AracID = sorgu.AracID;
                oam.otopark.OtoparkID = sorgu.Otopark.OtoparkID;
                oam.otopark.Kapasite = sorgu.Otopark.Kapasite;

                return oam;
            }
        }
        public static List<OtoparkAracModel> otoparkmodellistbyotoparkid()
        {
            using (OtoparkEntities1 contex = new OtoparkEntities1())
            {
                var list = contex.AracOtopark.ToList();
                List<OtoparkAracModel> oaml = new List<OtoparkAracModel>();
                foreach (var item in list)
                {
                    //if (item.Otopark.OtoparkID ==otoparkid)
                    //{
                        OtoparkAracModel otopark = new OtoparkAracModel();
                        otopark.AracOtoparkID = item.AracOtoparkID;
                        otopark.GirisSaati = item.GirisSaati;
                        otopark.CikisSaati = item.CikisSaati;
                        otopark.otopark.OtoparkID = item.Otopark.OtoparkID;
                        otopark.arac.AracID = item.Arac.AracID;
                        otopark.arac.AracPlaka = item.Arac.AracPlaka;                      
                        oaml.Add(otopark);
                    //} 
                }
                return oaml;
            }
        }
    }
}
