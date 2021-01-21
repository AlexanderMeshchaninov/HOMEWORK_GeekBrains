using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача № 1:
            //использовал тип sbyte т.к. он, на мой вгляд, более оптимален для памяти в данной задаче
            Console.WriteLine("Введите минимальную температуру за сутки:");
            sbyte minTemperature = Convert.ToSByte(Console.ReadLine());

            Console.WriteLine("Введите максимальную температуру за сутки:");
            sbyte maxTemperature = Convert.ToSByte(Console.ReadLine());

            //сделал явное приведение к типу sbyte т.к. цифра 2 являлась типом int32
            sbyte result = (sbyte)((minTemperature + maxTemperature) / 2);

            //здесь указан символ градуса цельсия (\u00B0)
            //результат будет округляться
            Console.WriteLine($"Cреднесуточная температура: {result} C\u00B0");

            Console.ReadKey();
        }
    }
}
