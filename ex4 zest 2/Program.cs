using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_zest_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b;
                string text;
                Console.Write("Enter the value of the dividend (a): ");
                text = Console.ReadLine();
                Int32.TryParse(text, out a);
                Console.Write("Enter the value of the divisor (b): ");
                text = Console.ReadLine();
                Int32.TryParse(text, out b);
                Console.WriteLine("Division result: {0}", a / b);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You shall not divide by 0!");
            }
            Console.ReadKey();
        }
    }
}
