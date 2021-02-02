using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_5._1
{
    class Program
    {
        static string WriteText()
        {
            Console.WriteLine("Введите текст: ");
            string userString = Console.ReadLine();
            return userString;
        }
        static void TextFile(string userString)
        {
            Console.WriteLine("Введите назнавание файла, чтобы сохранить текст в файл");
            string fileName = Console.ReadLine();
            Console.WriteLine($"Файл с именем {fileName} coхранен");
            File.WriteAllText(fileName, userString);
        }
        static void Main(string[] args)
        {
            //Задача 1:

            TextFile(WriteText());

            Console.ReadKey();
        }
    }
}
