using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Запрос имени
            Console.WriteLine("Как тебя зовут?");
            //Ввод имени в переменную
            string name = Console.ReadLine();
            //Вывод сообщения с именем и указанием текущей даты
            Console.WriteLine($"Привет, {name}! Cегодня: [{DateTime.Now}]");

            Console.ReadLine();
        }
    }
}
