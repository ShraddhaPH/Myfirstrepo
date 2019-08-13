using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Arith
    {
        public static void Main()
        {
            int n1;
            int n2;
            Console.WriteLine("enter n1");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter n2");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine(n1 + "+" + n2 + "=" + (n1 + n2));
            Console.WriteLine(n1 + "-" + n2 + "=" + (n1 - n2));
            Console.WriteLine(n1 + "*" + n2 + "=" + (n1 * n2));
            Console.WriteLine(n1 + "/" + n2 + "=" + (n1 / n2));
        }
    }
}
