using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poprawa
{
    class Czworokat:Ksztalt
    {
        public Czworokat()
        {

        }
        public Czworokat(double a, double b, double c, double d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public override double ObliczObwod()
        {
            return a + b + c + d;
        }
        public override double ObliczPole()
        {
            double p = ObliczObwod() / 2;
            return Math.Sqrt((p - a) * (p - b) * (p - c) * (p - d));
        }
    }
}
