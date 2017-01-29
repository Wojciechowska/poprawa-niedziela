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
            figury.Add(new Prostokat(3, 4));
            figury.Add(new Kwadrat(4));
            figury.Add(new Czworokat(3, 7,2,1));
            figury.Add(new Prostokat(5, 4));
            figury.Add(new Kwadrat(8));
            figury.Add(new Czworokat(12, 3, 2, 7));
            figury.Add(new Prostokat(13, 24));
            figury.Add(new Kwadrat(7));
            figury.Add(new Czworokat(2, 8, 5, 1));
            figury.Add(new Kwadrat(16));
            Console.WriteLine("Pole wieksze od 10:");
            foreach(var e in figury)
            {
                if(e.ObliczPole() > 10)
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
