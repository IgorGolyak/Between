using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int r = Convert.ToInt32(Console.ReadLine());
            int a = r / 10;
            int b = r % 100;
            int c = r / 10 & 10;
            Console.WriteLine(a = b);

            if ((a + b) % 3 == 0)
            {
                Console.WriteLine("Polindrom");
            }
            else
            {
                Console.WriteLine("Ne Polindrom");
            }

            if (a == b)
            {
                Console.WriteLine("No Deletsa 3");
            }
            else
            {
                Console.WriteLine("Deletsa 3");
            }
            
            Console.ReadKey();


            
           

        }
    }
}
