using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otopark1.Model
{
    class TarifeModel
    {
        public int AracTipi { get; set; }
        public string Tip { get; set; }
        public Nullable<int> Fiyat { get; set; }
        public Nullable<int> TarifeTipi { get; set; }
        public Arac arac = new Arac();
    }
}
