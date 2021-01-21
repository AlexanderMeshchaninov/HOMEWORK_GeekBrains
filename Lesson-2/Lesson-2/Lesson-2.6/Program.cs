using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2._6
{
    class Program
    {
        [Flags]
        enum WorkingWeek
        { 
            none        = 0b_0000_0000,//0
            Понедельник = 0b_0000_0001,//1
            Вторник     = 0b_0000_0010,//2
            Среда       = 0b_0000_0100,//4
            Четверг     = 0b_0000_1000,//8
            Пятница     = 0b_0001_0000,//16
            Суббота     = 0b_0010_0000,//32
            Воскресенье = 0b_0100_0000,//64
        }
        static void Main(string[] args)
        {
            //Задача № 6(*):
            //вариант первый
            {
                //маски работы офисов
                WorkingWeek officeOneMask =
                    WorkingWeek.Вторник |
                    WorkingWeek.Среда |
                    WorkingWeek.Четверг |
                    WorkingWeek.Пятница;
                WorkingWeek officeTwoMask =
                    WorkingWeek.Понедельник |
                    WorkingWeek.Вторник |
                    WorkingWeek.Среда |
                    WorkingWeek.Четверг |
                    WorkingWeek.Пятница |
                    WorkingWeek.Суббота |
                    WorkingWeek.Воскресенье;

                Console.WriteLine($"Офис1 работает: {officeOneMask}");
                Console.WriteLine($"Офис2 работает: {officeTwoMask}");
                //вариант второй
                //например узнать определенный день работы - вторник

                bool isWork = (officeOneMask & WorkingWeek.Вторник) == WorkingWeek.Вторник;
                if (isWork)
                {
                    Console.WriteLine("Офис работает!");
                }
                else
                {
                    Console.WriteLine("Офис неработает!");
                }
            }
            Console.ReadKey();
        }
    }
}
