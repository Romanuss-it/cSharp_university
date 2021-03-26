using System;

namespace Lab05
{
    class Program
    {
            static void Main(string[] args)
            {
                //Построить таблицу значений функции y=f(x) для x Пµ [a,b] с шагом h.
                double a = -0.35;
                double b = 0.35;
                double h = 0.05;

                double[] arr = y(a, b, h);
            }


            //Для решения задачи описать метод, вычисляющий значение функции.
            // у={x^3-0.1 если |x|<=0.1; 0.2x-0.1 если 0.1<x<=0.2; x^3+0.1 если |x|>0.2
            static double[] y(double a, double b, double h)
            {
                double x = a;
                //количество шагов
                int count = Convert.ToInt32(Math.Round((b - a) / h, 0)) + 1;
                double[] arr = new double[count + 1];
                for (int i = 0; i < count; i++)
                {
                    if (Math.Abs(x) <= 0.1)
                        arr[i] = Сalculation(x, -0.1); //x * x * x - 0.1;
                    else if ((Math.Abs(x) < 0.1) && (Math.Abs(x) <= 0.2))
                        arr[i] = Сalculation(0.2, x, -0.1); //0.2 * x - 0.1;
                    else if (Math.Abs(x) > 0.2)
                        arr[i] = Сalculation(x, +0.1); //x * x * x + 0.1;
                    Console.WriteLine("Значение x={0}, значение y={1}", x, arr[i]);
                    x = x + h;
                }
                x = a;
                //Запишем в файл
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter("calc.csv"))
                {
                    foreach (var item in arr)
                    {
                        sw.WriteLine(string.Format("{0};{1}", x, item));
                        x = x + h;
                    }
                }
                return arr;
            }

            static double Сalculation(double x, double c)
            {
                return x * x * x + c;
            }

            static double Сalculation(double a, double x, double c)
            {
                return a * x - c;
            }
    }
}
