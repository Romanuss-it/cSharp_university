using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04_03
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.Write("x = ");
            double.TryParse(Console.ReadLine(), out x);
            Console.Write("y = ");
            double.TryParse(Console.ReadLine(), out y);
            if ((x < 0 || y > 23)) Console.WriteLine("Так");
            else if (x < -23 || x > 0) Console.WriteLine("Нi");
            else Console.WriteLine("На кордоні");
            Console.ReadLine();
        }
    }
}