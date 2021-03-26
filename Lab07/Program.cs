using System;

namespace Lab07
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 0;
            double y, h = 0;
            while (b < a)
            {
                Console.Write("Введите нижнюю границу: ");
                int.TryParse(Console.ReadLine(), out a);
                Console.Write("Введите верхнюю границу (должна быть больше нижней): ");
                int.TryParse(Console.ReadLine(), out b);
                if (b < a)
                {
                    Console.WriteLine("Ошибка! Верхняя граница должна быть больше нижней!");
                }
            }
            while (h == 0)
            {
                Console.Write("Введите шаг (должен быть больше 0): ");
                double.TryParse(Console.ReadLine(), out h);
                if (h == 0)
                {
                    Console.WriteLine("Ошибка! Шаг должен быть больше 0!");
                }
            }
            Console.WriteLine("Таблица значений функции y=корень(5-x^3) на отрезке [{0},{1}] с интервалом {2}", a, b, h);
            for (double x = a; x <= b; x += h)
            {
                y = Math.Sqrt(5 - Math.Pow(x, 3));
                Console.WriteLine("x={0}\t| {1}", x, double.IsNaN(y) ? "Функция не определена в этой точке" : "y=" + y.ToString());
            }
            Console.ReadLine();
        }
    }
}
