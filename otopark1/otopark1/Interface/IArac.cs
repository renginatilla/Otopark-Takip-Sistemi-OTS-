using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otopark1.Interface
{
    interface IArac
    {
        bool CUD(Arac arac, EntityState state);
    }
}
