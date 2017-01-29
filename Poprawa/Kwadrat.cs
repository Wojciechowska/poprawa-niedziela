using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poprawa
{
    class Kwadrat:Prostokat
    {
        public Kwadrat(double a)
        {
            this.b = a;
            this.c = a;
            this.d = a;
        }
    }
}
