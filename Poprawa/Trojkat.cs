using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poprawa
{
    class Trojkat:Ksztalt
    {
        public Trojkat()
        {

        }
        public Trojkat(double a,double b,double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public override double ObliczObwod()
        {
            return a + b + c;
        }
        public override double ObliczPole()
        {
            double p = ObliczObwod() / 2;
            return Math.Sqrt(p*(p - a)*(p - b)*(p - c));
        }
    }
}
