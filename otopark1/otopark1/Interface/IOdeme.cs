using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otopark1.Interface
{
    interface IOdeme
    {
        bool CUD(Odeme odeme, EntityState state);
    }
}
