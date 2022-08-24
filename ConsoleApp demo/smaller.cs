using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_demo
{
    internal class smaller
    {
        public static void Main()
        {
            int a;
            int b;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine(b + "b is smaller");
            }
            else if (a < b)
            {
                Console.WriteLine(a + "a is smaller");
            }
            else
            {
                Console.WriteLine("both are equal");
            }
        }
    }
}
