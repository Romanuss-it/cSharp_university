using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//варіант №3
namespace lab03
{
    class Program
    {
        static void Main()
        {

            // №1
             Console.Write("s = ");
             double s = double.Parse(Console.ReadLine());
             Console.Write("p = ");
             double n = double.Parse(Console.ReadLine());
             double p = (Math.Pow(s, 3) + Math.Pow(n, 3)) / 2;
             Console.WriteLine(p);


            //№2
            Console.Write("M-> ");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.Write("N-> ");
            int N = Convert.ToInt32(Console.ReadLine());
            if (M % N == 0) Console.WriteLine("M на N без остачі не ділиться ");
            else Console.WriteLine(M % N);
            Console.ReadLine();
        }
    }
}
