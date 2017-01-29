using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poprawa
{
    class TrojkatProstokatny:Trojkat
    {
        public TrojkatProstokatny()
        {

        }
        public TrojkatProstokatny(double a,double b)
        {
            this.a = a;
            this.b = b;
            this.c = Math.Sqrt(a * a + b * b);
        }
    }
}
