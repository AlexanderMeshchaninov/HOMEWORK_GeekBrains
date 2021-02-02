using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //Задача 2:
                //вариант первый

                //двумерный массив
                string[,] telBookArray = new string[5, 2];
                //имя                                   //тел/e-mail
                //столбцы[5];                           //строки[2]
                telBookArray[0, 0] = "Александра:\t";   telBookArray[0, 1] = "+7 (916) 526-62-34";
                telBookArray[1, 0] = "Петр:\t\t";       telBookArray[1, 1] = "+7 (917) 420-61-15";
                telBookArray[2, 0] = "Виктор:\t\t";     telBookArray[2, 1] = "+7 (926) 500-20-04";
                telBookArray[3, 0] = "Эдуард:\t\t";     telBookArray[3, 1] = "eduard_256@mail.ru";
                telBookArray[4, 0] = "Галина:\t\t";     telBookArray[4, 1] = "galina_321@mail.ru";

                for (int i = 0; i < telBookArray.GetLength(0); i++)
                {
                    for (int j = 0; j < telBookArray.GetLength(1); j++)
                    {
                        Console.Write(telBookArray[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
            {
                //вариант второй
                //двумерный массив

                string[,] telBookArray = new string [5, 2]
                { 
                    { "Александра:\t", "+7 (916) 526-62-34"},
                    { "Петр:\t\t","+7 (917) 420-61-15"}, 
                    { "Виктор:\t\t","+7 (926) 500-20-04"}, 
                    { "Эдуард:\t\t","eduard_256@mail.ru"}, 
                    { "Галина:\t\t","galina_321@mail.ru"} 
                };

                for (int i = 0; i < telBookArray.GetLength(0); i++)
                {
                    for (int j = 0; j < telBookArray.GetLength(1); j++)
                    {
                        Console.Write(telBookArray[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
            }

        }
    }
}
