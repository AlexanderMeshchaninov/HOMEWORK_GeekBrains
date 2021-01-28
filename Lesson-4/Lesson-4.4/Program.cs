using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4._4
{
    class Program
    {
        static long FibonachiNumbers(int number)
        {
            
            if (number == 0 || number == 1)
            {
                return number;
            }

            return FibonachiNumbers(number - 1) + FibonachiNumbers(number - 2);
        }

        static void Main(string[] args)
        {
            //(*)Задача 4:
            {
                //вариант первый
                //можно задать число (длинну цикла) и вывести всю последовательность чисел с 0 до указанного значения
                Console.WriteLine("Задайте длинну последовательности 'чисел Фибоначчи': ");
                int number = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i <= number; i++)
                {
                    Console.WriteLine("-" + FibonachiNumbers(i));
                }
                Console.ReadKey();
                Console.Clear();
            }
            {
                //вариант второй
                //сразу получить результат: число Фибоначчи
                Console.WriteLine("Введите число, чтобы вычислить число Фибоначчи: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.Write("Число Фибоначчи: " + FibonachiNumbers(number));

                Console.ReadKey();
            }
        }
    }
}
