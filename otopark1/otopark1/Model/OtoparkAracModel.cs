using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otopark1.Model
{
    class OtoparkAracModel
    {
        public int AracOtoparkID { get; set; }
        public int AracID { get; set; }
        public int OtoparkID { get; set; }
        public Nullable<System.DateTime> GirisSaati { get; set; }
        public Nullable<System.DateTime> CikisSaati { get; set; }

        public Arac arac = new Arac();
        public Otopark otopark = new Otopark();
        public Musteri musteri = new Musteri();
        //public virtual Arac Arac { get; set; }
        //public virtual Otopark Otopark { get; set; }
    }
}
