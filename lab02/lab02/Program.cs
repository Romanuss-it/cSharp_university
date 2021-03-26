using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    class Program
    {
        static void Main()
        {
           //suma
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a + b);

            // suma i ri
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine(c + d);
            Console.WriteLine(c - d);

            //summa 3
            int q= int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine(q + w + e);
            
            
            //diysni 
            double r = double.Parse(Console.ReadLine());
            double t = double.Parse(Console.ReadLine());
            Console.WriteLine(r + t);
            Console.WriteLine(r - t);
            

            //dill
            double y = double.Parse(Console.ReadLine());
            double u = double.Parse(Console.ReadLine());
            Console.WriteLine(y / u);

            //summ 3
            double i = double.Parse(Console.ReadLine());
            double o = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            Console.WriteLine(i + o + p);
            Console.ReadLine();

        }
    }
}