using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Lab06
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\text.txt"; //путь файла
            FileStream MainF = new FileStream(path, FileMode.Open, FileAccess.Read); //создаю файл в потоке, открываю его и читаю
            StreamReader reader = new StreamReader(MainF, Encoding.UTF8); // прочитываю файл в кодировке Юникод
            Console.WriteLine("Заданная строка \n" + reader.ReadToEnd());
            string[] lines = File.ReadAllLines(path, Encoding.UTF8); // разбиваю строки в файле еа массив строк
            string minline = lines.OrderBy(x => x.Length).First(); //Сортирую сортирую элементы в массиве по возрастанию(от самой 
            //маленькой длины до самой большой
            Console.WriteLine();
            Console.WriteLine("Самая маленькая строка '{0}' с длиной {1}", minline, minline.Length);
            reader.Close();
            Console.ReadKey();
            //File.Delete(path);
        }
    }
}