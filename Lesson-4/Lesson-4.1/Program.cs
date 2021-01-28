using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4._1
{
    class Program
    {
        static void GetFullName(string firstName, string lastName, string patronymic)
        {
            string[] parameters = { lastName, firstName, patronymic };
            //использую метод Concat для склеивания строк
                string str = String.Concat(parameters);
            Console.WriteLine(str);
        }
        static string GetFullNameByParams(params string[] values)
        {
            string concatString = "";
            for (int i = 0; i < values.Length; i++)
            {
                concatString += values[i];
            }
            return concatString;
        }

        static void Main(string[] args)
        {
            {
                //Задача 1:
                //способ первый (как понял задание)
                GetFullName("Александр", "Мещанинов", "Викторович");
                GetFullName("Федоров", "Максим", "Петрович");
                GetFullName("Диана", "Иванова", "Александровна");
                GetFullName("Александр", "Поляков", "Дмитриевич");

                Console.ReadKey();
            }
            {
                //способ второй (с вводом значений через консоль и использованием params)
                string[] values = new string [3];
                Console.WriteLine("Введите имя:");
                values[0] = Console.ReadLine();
                Console.WriteLine("Введите фамилию:");
                values[1] = Console.ReadLine();
                Console.WriteLine("Введите отчество:");
                values[2] = Console.ReadLine();

                string concatString = GetFullNameByParams(values[1], values[0], values[2]);
                Console.WriteLine(concatString);
                
                Console.ReadKey();
            }
            
        }
    }
}
