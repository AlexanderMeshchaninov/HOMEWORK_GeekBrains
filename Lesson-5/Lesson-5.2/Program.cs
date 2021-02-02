using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_5._2
{
    class Program
    {
        static string WriteText()
        {
            Console.WriteLine("Введите текст: ");
            string userString = Console.ReadLine();
            return userString;
        }
        static void TextFile(string userString, string timeToAdd)
        {
            string fileName = "startup.txt";
            Console.WriteLine($"Файл с именем {fileName} coхранен");
            File.WriteAllText(fileName, userString);
            File.AppendAllText(fileName, timeToAdd);
        }
        static string AddDateAndTime()
        {
            string timeToAdd = DateTime.Now.ToString("\nТекущее время: HH:mm:ss");
            return timeToAdd;
        }
        static void Main(string[] args)
        {
            //Задача 2:
            TextFile(WriteText(), AddDateAndTime());

            Console.ReadKey();
        }
    }
}
