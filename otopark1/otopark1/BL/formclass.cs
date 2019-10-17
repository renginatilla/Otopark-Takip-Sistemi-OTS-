using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otopark1.BL
{
    class formclass
    {
        public static string adminname { get; set; }
    }
    public  enum tarifetipi
    {
        motorsaatlik=8,
        motorgünlük=30,
        otomobilsaatlik=10,
        otomobilgünlük=60,
        minibüssaatlik=15,
        minibüsgünlük=90,

    } 
    public enum aractip
    {
        motor=1,
        otomobil=2,
        minibüs=3,
        otobüs=4
    }
    public enum tarifetip
    {
        normal=1,
        abonman=2
    }
   
}
