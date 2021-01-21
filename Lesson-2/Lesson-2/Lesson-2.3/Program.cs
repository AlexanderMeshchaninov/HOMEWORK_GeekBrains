using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача № 3:
            //cпособ первый
            {
                Console.WriteLine("Введите число для проверки четно/нечетно:");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                //если остаток от деления на 2 = 0, то четное
                if (userNumber % 2 == 0)
                {
                    Console.WriteLine("Вы ввели четное число");
                }
                else
                {
                    Console.WriteLine("Вы ввели нечетное число");
                }
            }
            //способ второй
            {
                Console.WriteLine("Введите число для проверки четно/нечетно:");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                //у нечетного числа младший бит = 1, если побитово умножить четное число будет 0
                if ((userNumber & 1) == 0)
                {
                    Console.WriteLine("Вы ввели четное число");
                }
                else
                {
                    Console.WriteLine("Вы ввели нечетное число");
                }
            }
            Console.ReadKey();
        }
    }
}
