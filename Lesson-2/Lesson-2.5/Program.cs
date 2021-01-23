using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2._5
{
    class Program
    {
        public enum Months
        {
            Январь   = 1,
            Февраль  = 2,
            Март     = 3,
            Апрель   = 4,
            Май      = 5,
            Июнь     = 6,
            Июль     = 7,
            Август   = 8,
            Сентябрь = 9,
            Октябрь  = 10,
            Ноябрь   = 11,

            Декабрь  = 12,//з
        }
        static void Main(string[] args)
        {
            //Задача № 5(*):
            //блок ввода средней температуры
            Console.WriteLine("Введите минимальную температуру за сутки:");
            sbyte minTemperature = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("Введите максимальную температуру за сутки:");
            sbyte maxTemperature = Convert.ToSByte(Console.ReadLine());
            sbyte midTemperature = (sbyte)((minTemperature + maxTemperature) / 2);
            //блок ввода текущего месяца
            Console.WriteLine("Введите номер текущего месяца");
            sbyte userAnswer = Convert.ToSByte(Console.ReadLine());
            Months months = (Months)Enum.Parse(typeof(Months), Convert.ToString(userAnswer));
            //вариант первый
            {
                if ((midTemperature > 0 && months == Months.Декабрь) || (midTemperature > 0 && months == Months.Январь) || (midTemperature > 0 && months == Months.Февраль))
                {
                    Console.WriteLine($"На дворе: {months}, {midTemperature} C \u00B0, наступила 'Дождливая зима'");
                }
                else
                {
                    Console.WriteLine($"На дворе: {months}, {midTemperature} C \u00B0");
                }
            }
            //вариант второй
            {
                if (midTemperature > 0)
                {
                    switch (months)
                    {
                        case Months.Декабрь:
                        case Months.Январь:
                        case Months.Февраль:
                            Console.WriteLine($"На дворе: {months}, {midTemperature} C \u00B0, наступила 'Дождливая зима'");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine($"На дворе: {months}, {midTemperature} C \u00B0");
                }
            }
            Console.ReadKey();
        }
    }
}
