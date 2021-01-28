using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4._2
{
    class Program
    {
        static int GetUserStringToSumNumbers(string userAnswer, out int result)
        {
            int sum = 0;
            //тут строка введенная пользователем разделяется по пробелам, а числа попадают в массив для перебора через цикл
            string [] numbers = userAnswer.Split(new char[] {' '});

            for (int i = 0; i < numbers.Length; i++)
            {
                //элементы массива "парсятся" в интовое значение и суммируются в переменную sum
                sum += int.Parse(numbers[i].ToString());
            }

            return result = sum;
        }
        static void Main(string[] args)
        {
            //Задача 2:
            {
                //Ввод чисел через консоль
                Console.WriteLine("Введите числа через пробелы: \n Далее нажмите ENTER для того, чтобы получить сумму чисел");
                string userAnswer = Console.ReadLine();
                //метод принимающий строку и отдающий (out) результат суммирования чисел в консоль
                GetUserStringToSumNumbers(userAnswer, out int result);

                Console.WriteLine($"Результат сложения чисел: { result }");
                Console.ReadKey();
            }
        }
    }
}
