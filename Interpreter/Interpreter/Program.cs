using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var interpreter = new InterpreterOfRomanNumericSystem();

            string input = null;

            Console.Write("Enter number in roman system...");
            while (!string.IsNullOrEmpty(input = Console.ReadLine()))
            {
                try
                {
                    int value = interpreter.Interpret(input);
                    Console.WriteLine($"Value: {value}");
                }
                catch (ArgumentException e)
                {
                    Console.Error.WriteLine(e.Message);
                }

                Console.Write("Enter next number... ");
               
            }

           
           
        }
    }
}
