using System;

namespace lab01

{ 
    class Program
    {
        
        
            static void Main(string[] args)
            {
                Console.Write("a = ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("{0}", 4 * Math.Sqrt(a));
                Console.ReadKey();
            }
        
    }
}