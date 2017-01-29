using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poprawa
{
    abstract class Ksztalt
    {
        protected double a, b, c, d;
        public Ksztalt()
        {

        }
        public abstract double ObliczPole();
        public abstract double ObliczObwod();
        public override string ToString()
        {
            return string.Format("Obwód:{0},pole:{1}", ObliczObwod(),ObliczPole());
        }
    }
}
