using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1:
            //Вариант первый
            if (string.IsNullOrEmpty(Properties.Settings.Default.UserName) && 
                Properties.Settings.Default.UserAge == 0 &&
                string.IsNullOrEmpty(Properties.Settings.Default.Career))
            {
                Console.WriteLine("Введите имя");
                Properties.Settings.Default.UserName = Console.ReadLine();
                Properties.Settings.Default.Save();
                Console.WriteLine("Введите возраст");
                Properties.Settings.Default.UserAge = int.Parse(Console.ReadLine());
                Properties.Settings.Default.Save();
                Console.WriteLine("Введите род деятельности");
                Properties.Settings.Default.Career = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            string greetings = Properties.Settings.Default.Greeting;
            string userName = Properties.Settings.Default.UserName;
            int userAge = Properties.Settings.Default.UserAge;
            string career = Properties.Settings.Default.Career;

            Console.WriteLine($"Выводим информацию записанную в настройках приложения: \n\n{greetings}\nИмя: {userName}\nВозраст: {userAge}\nРод деятельности: {career}");

            Console.ReadKey();
        }
    }
}
