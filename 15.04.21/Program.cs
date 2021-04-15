using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._04._21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int r = Convert.ToInt32(Console.ReadLine());
            int a = r / 10;
            int b = r % 10;
            Console.WriteLine(a + b);
            if ((a + b) % 2 == 0)
            {
                Console.WriteLine("Четкое");
            }
            else
            {
                Console.WriteLine("Не Четкое");
            }
            Console.ReadKey();


        }
    }
}
