using System;

namespace Lab08
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r1 = new Random();
            int n1 = -1, n2 = -1;
            int a;
            a = (int)Console.Read();
            while ((n1 <= 0) || (n2 <= 0))
            {
                if (n1 <= 0)
                {
                    Console.Write("Введите первую размерность двумерного массива: ");
                    int.TryParse(Console.ReadLine(), out n1);
                }
                if (n2 <= 0)
                {
                    Console.Write("Введите вторую размерность двумерного массива: ");
                    int.TryParse(Console.ReadLine(), out n2);
                }
            }
            int[,] a2 = new int[n1, n2];
            for (int i = 0; i < a2.GetLength(0); i++)
            {
                for (int j = 0; j < a2.GetLength(1); j++)
                {
                    a2[i, j] = r1.Next(-10, 5);
                    Console.Write("{0}\t", a2[i, j]);
                }
                Console.Write("\n");
            }
            for (int i = 0; i < a2.GetLength(0); i++)
            {
                for (int j = 0; j < a2.GetLength(1); j++)
                {
                    if ((a2[i, j] < 0) && (a2[i, j] % 'q'!= 0))
                        a2[i, j] = Math.Abs(a2[i, j]);
                    Console.Write("{0}\t", a2[i, j]);
                }
                Console.Write("\n");
            }
        }
    }
}
