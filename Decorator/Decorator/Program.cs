using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Coffy();

            var coffyWithLemone = new BeverageWithLemone(beverage);
            var coffyWithLemoneAndSuger = new BeverageWithSuger(coffyWithLemone);
            var coffyWithLemoneAndSugerAndCinnamone=new BeverageeWithCinnamon(coffyWithLemoneAndSuger);
            Console.WriteLine($"{coffyWithLemoneAndSugerAndCinnamone.ToString()}\nPrice:{coffyWithLemoneAndSugerAndCinnamone.Price}\n");

        }
    }
}

