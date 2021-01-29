using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2._2
{
    class Program
    {
        [Flags]
        public enum Months
        {
            Январь = 1,
            Февраль = 2,
            Март = 3,
            Апрель = 4,
            Май = 5,
            Июнь = 6,
            Июль = 7,
            Август = 8,
            Сентябрь = 9,
            Октябрь = 10,
            Ноябрь = 11,
            Декабрь = 12,
        }
        static void Main(string[] args)
        {
            //Задача № 2:
            //Способ первый
            {
                Console.WriteLine("Введите номер текущего месяца:");
                int userAnswer = Convert.ToInt32(Console.ReadLine());

                if (userAnswer == 1)
                {
                    Console.WriteLine($"Текущий месяц: {Months.Январь}");
                }
                else if (userAnswer == 2)
                {
                    Console.WriteLine($"Текущий месяц: {Months.Февраль}");
                }
                else if (userAnswer == 3)
                {
                    Console.WriteLine($"Текущий месяц: {Months.Март}");
                }
                else if (userAnswer == 4)
                {
                    Console.WriteLine($"Текущий месяц: {Months.Апрель}");
                }
                else if (userAnswer == 5)
                {
                    Console.WriteLine($"Текущий месяц: {Months.Май}");
                }
                else if (userAnswer == 6)
                {
                    Console.WriteLine($"Текущий месяц: {Months.Июнь}");
                }
                else if (userAnswer == 7)
                {
                    Console.WriteLine($"Текущий месяц: {Months.Июль}");
                }
                else if (userAnswer == 8)
                {
                    Console.WriteLine($"Текущий месяц: {Months.Август}");
                }
                else if (userAnswer == 9)
                {
                    Console.WriteLine($"Текущий месяц: {Months.Сентябрь}");
                }
                else if (userAnswer == 10)
                {
                    Console.WriteLine($"Текущий месяц: {Months.Октябрь}");
                }
                else if (userAnswer == 11)
                {
                    Console.WriteLine($"Текущий месяц: {Months.Ноябрь}");
                }
                else if (userAnswer == 12)
                {
                    Console.WriteLine($"Текущий месяц: {Months.Декабрь}");
                }
                else
                {
                    Console.WriteLine("Введите число текущего месяца!");
                }
            }
            //Способ второй
            {
                Console.WriteLine("Введите номер текущего месяца:");
                int userAnswer = Convert.ToInt32(Console.ReadLine());
                switch (userAnswer)
                {
                    case 1:
                        Console.WriteLine($"Текущий месяц: {Months.Январь}");
                        break;
                    case 2:
                        Console.WriteLine($"Текущий месяц: {Months.Февраль}");
                        break;
                    case 3:
                        Console.WriteLine($"Текущий месяц: {Months.Март}");
                        break;
                    case 4:
                        Console.WriteLine($"Текущий месяц: {Months.Апрель}");
                        break;
                    case 5:
                        Console.WriteLine($"Текущий месяц: {Months.Май}");
                        break;
                    case 6:
                        Console.WriteLine($"Текущий месяц: {Months.Июнь}");
                        break;
                    case 7:
                        Console.WriteLine($"Текущий месяц: {Months.Июль}");
                        break;
                    case 8:
                        Console.WriteLine($"Текущий месяц: {Months.Август}");
                        break;
                    case 9:
                        Console.WriteLine($"Текущий месяц: {Months.Сентябрь}");
                        break;
                    case 10:
                        Console.WriteLine($"Текущий месяц: {Months.Октябрь}");
                        break;
                    case 11:
                        Console.WriteLine($"Текущий месяц: {Months.Ноябрь}");
                        break;
                    case 12:
                        Console.WriteLine($"Текущий месяц: {Months.Декабрь}");
                        break;
                    default:
                        Console.WriteLine("Введите число текущего месяца!");
                        break;
                }
            }
            //Способ третий
            {
                //Начало программы
                Console.WriteLine("Введите номер текущего месяца:");
                //Бесконечный цикл пока не будут выполнены условия
                while (true)
                {
                    //сначала конвертирую ответ пользователя в (Int32), чтобы использовать условие if
                    int userAnswer = Convert.ToInt32(Console.ReadLine());
                    //условие: ввод цифр от 1 до 12
                    if (userAnswer > 0 && userAnswer < 13)
                    {
                        //используется конвертация Enum.Parse(), чтобы задействовать нужный месяц в enum по значению
                        //дальше конвертируется в строковое значение (userAnswer) т.к. тип Int использовать в Enum.Parse не получается
                        Months result = (Months)Enum.Parse(typeof(Months), Convert.ToString(userAnswer));
                        Console.WriteLine($"Текущий месяц: {result}");
                        //если условие выполнено правильно, разрываем цикл
                        break;
                    }
                    //если пользователь ввел число вне диапазона, то цикл повторяется пока не будет выполнено условие (ввести число от 1 до 12)
                    else
                    {
                        Console.WriteLine("Введите номер текущего месяца!");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
