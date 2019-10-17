using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otopark1.Model
{
    class AracModel
    {
        public int AracID { get; set; }
        public string AracPlaka { get; set; }
        public string AracMarka { get; set; }
        public string AracModel1 { get; set; }
        public string AracRenk { get; set; }
        public int MusteriID { get; set; }
        public int AracTipi { get; set; }

        public Musteri musteri = new Musteri();
        public Tarife tarife = new Tarife();
    }
}
