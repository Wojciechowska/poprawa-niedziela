using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poprawa
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ksztalt> figury = new List<Ksztalt>();
            figury.Add(new Trojkat(3, 4, 6));
            figury.Add(new TrojkatRownoboczny(4));
            figury.Add(new TrojkatProstokatny(3, 4));
            figury.Add(new Trojkat(4, 5, 7));
            figury.Add(new TrojkatRownoboczny(6));
            figury.Add(new TrojkatProstokatny(2, 6));
            figury.Add(new Trojkat(3, 6, 8));
            figury.Add(new TrojkatRownoboczny(2));
            figury.Add(new TrojkatProstokatny(7, 4));
            figury.Add(new TrojkatProstokatny(10, 10));

            Console.WriteLine("Pole wieksze od 10:");
            foreach(var e in figury)
            {
                if(e.ObliczPole()>10)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            Console.WriteLine("Obwod mniejszy od 20:");
            foreach (var e in figury)
            {
                if (e.ObliczObwod() <= 20)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            Console.ReadKey();
        }
    }
}
