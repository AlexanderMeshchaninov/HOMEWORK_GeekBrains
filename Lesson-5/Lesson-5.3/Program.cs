using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_5._3
{
    class Program
    {
        static void BinaryFile(byte [] writeByteNumbers)
        {
            string fileName = "ByteNumbers.bin";
            Console.WriteLine($"Бинарный файл с именем {fileName} coхранен");
            File.WriteAllBytes(fileName, writeByteNumbers);
        }
        static byte [] WriteByteNumbers()
        {
            Console.WriteLine("Введите несколько чисел через пробел (каждое число не более 255): ");
            string userNumbers = Console.ReadLine();
            string[] splittedNumbers = userNumbers.Split(' ');
            byte[] userNumbersByteArray = new byte [splittedNumbers.Length];

            for (int i = 0; i < splittedNumbers.Length; i++)
            {
                userNumbersByteArray[i] += Convert.ToByte(splittedNumbers[i]);
            }
            return userNumbersByteArray;
        }
        static void Main(string[] args)
        {
            //Задача 3:
            BinaryFile(WriteByteNumbers());

            Console.ReadKey();
        }
    }
}