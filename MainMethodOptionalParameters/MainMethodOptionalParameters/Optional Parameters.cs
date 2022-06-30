using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodOptionalParameters
{
    class OptionalParameters
    {
        public int Optional(int x, int y = 12)
        {
               return x + y ;
        }
    }
}
