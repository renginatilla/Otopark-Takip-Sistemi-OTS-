using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otopark1.DAL
{
    class HelperOtopark
    {
        public static Otopark GetOtopark(int id)
        {
            using (OtoparkEntities1 contex=new OtoparkEntities1())
            {
                return contex.Otopark.Where(x => x.OtoparkID == id).FirstOrDefault();
            }
        }
        public static List<Otopark> getotoparklist()
        {
            using (OtoparkEntities1 contex=new OtoparkEntities1())
            {
                return contex.Otopark.ToList();
            }
        }
        
    }
}
