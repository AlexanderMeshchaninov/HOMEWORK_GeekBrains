using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //Задача 3:
                //вариант первый

                Console.WriteLine("Введите строку и нажмите ENTER для вывода вашей реверсивной строки");
                string userStr = Console.ReadLine();
                char[] charArr = userStr.ToCharArray();
                //используется метод Reverse
                Array.Reverse(charArr);
                string reverseStr = new string(charArr);
                Console.WriteLine($"Реверсивная строка: {reverseStr}");

                Console.ReadKey();
            }
            {
                //вариант второй
                string reverseStr = string.Empty;
                Console.WriteLine("Введите строку и нажмите ENTER для вывода вашей реверсивной строки");
                string userStr = Console.ReadLine();
                //обратный цикл
                for (int i = userStr.Length-1; i >= 0; i--)
                {
                    reverseStr += userStr[i];
                }
                Console.WriteLine($"Реверсивная строка: {reverseStr}");
                
                Console.ReadKey();
            }
        }
    }
}
