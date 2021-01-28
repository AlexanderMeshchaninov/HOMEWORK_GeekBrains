using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4._3
{
    enum Seasons
    {
        Winter = 1,
        Spring = 2,
        Summer = 3,
        Autumn = 4,
    }
    class Program
    {
        static int GetNumberToReturnParam(int monthNumber, out int result)
        {
            int res = 0;

            switch (monthNumber)
            {
                case 1:
                case 2:
                case 12:
                    res = (int)Seasons.Winter;
                    break;

                case 3:
                case 4:
                case 5:
                    res = (int)Seasons.Spring;
                    break;

                case 6:
                case 7:
                case 8:
                    res = (int)Seasons.Summer;
                    break;

                case 9:
                case 10:
                case 11:
                    res = (int)Seasons.Autumn;
                    break;

                default:
                    Console.WriteLine("Ошибка: введите число от 1 до 12");
                    break;
            }
            return result = res;
        }
        static void GetParamsToReturnSeason(int result)
        {
            Seasons winter = Seasons.Winter;
            Seasons spring = Seasons.Spring;
            Seasons summer = Seasons.Summer;
            Seasons autumn = Seasons.Autumn;
            switch (result)
            {
                case 1:
                    Console.WriteLine(winter.ToString());
                    break;
                case 2:
                    Console.WriteLine(spring.ToString());
                    break;
                case 3:
                    Console.WriteLine(summer.ToString());
                    break;
                case 4:
                    Console.WriteLine(autumn.ToString());
                    break;
            }
        }

        static void Main(string[] args)
        {
            //Задача 3:
            Console.WriteLine("Напишите порядковый номер месяца - от 1 до 12: ");
            int monthNumber = Convert.ToInt32(Console.ReadLine());

            GetNumberToReturnParam(monthNumber, out int result);
            //Результат
            GetParamsToReturnSeason(result);

            Console.ReadKey();
        }
    }
}
