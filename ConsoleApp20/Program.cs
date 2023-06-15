using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a x:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter a y:");
            int y = Convert.ToInt32(Console.ReadLine());
            int b = Math.Abs(y);
            int c = Math.Abs(x - y);
            Console.Write(Math.Sqrt(c * b));
        }
    }
}
