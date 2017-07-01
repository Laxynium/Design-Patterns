using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var square=new Square()
            {
                LeftTopPoint = new Point<float>(30,40),
                LengthOfSide = 40F
            };
            var squereAdapter=new SquareAdapter(square);
            var triangle = new Triangle(new Point<float>(4F, 3F), 10);

            Client.PrintDataAboutPolygon(triangle);
            Client.PrintDataAboutPolygon(squereAdapter);

        }
    }
    class Client
    {
        public static void PrintDataAboutPolygon(IRegularPolygon polygon)
        {
            Console.WriteLine($"{polygon.Name()} properties:\n{polygon.Parameters()}\n" +
                              $"Area: {polygon.CalculateArea()}\nCircuit: {polygon.CalculateCircuit()}");
        }
    }
}
