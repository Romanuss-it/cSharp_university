using System;

namespace Lab09
{
    class Program
    {
        public static void Main()
        {
            string str = "adxxxkll;adayyyyxxxa;d'cx'xwdywey";//искомая строка
            int x = 0, y = 0;
            char[] s = str.ToCharArray();

            foreach (char ch in s)
            {
                if (ch == 'x') x++;
                if (ch == 'y') y++;
            }
            System.Console.WriteLine("Количество вхождений символа\"x\" в строку: {0}", x);
            System.Console.WriteLine("Количество вхождений символа\"y\" в строку: {0}", y);

        }
    }
}
