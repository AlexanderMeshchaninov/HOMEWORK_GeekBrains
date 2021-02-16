using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Lesson_8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var greetings = ConfigurationManager.AppSettings["Greeting"];
            var userName = ConfigurationManager.AppSettings["UserName"];
            var userAge = ConfigurationManager.AppSettings["UserAge"];
            var career = ConfigurationManager.AppSettings["Career"];

            Console.WriteLine();
            Console.WriteLine($"Выводим информацию записанную в настройках приложения: \n\n{greetings}\nИмя: {userName}\nВозраст: {userAge}\nРод деятельности: {career}");

            Console.ReadKey();
        }
    }
}
