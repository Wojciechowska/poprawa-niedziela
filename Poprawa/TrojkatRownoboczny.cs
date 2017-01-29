using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poprawa
{
    class TrojkatRownoboczny:Trojkat
    {
        public TrojkatRownoboczny()
        {

        }
        public TrojkatRownoboczny(double a)
        {
            this.a = a;
            this.b = a;
            this.c = a;
        }
    }
}
