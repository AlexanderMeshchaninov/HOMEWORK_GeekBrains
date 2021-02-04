using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lesson_6
{
    class TaskManager
    {
        static void Tasklist()
        {
            try
            {
                Process[] tasklist = Process.GetProcesses();
                //вывод в консоль
                Console.Clear();
                Console.WriteLine(String.Format("{0, -36} {1, 26} {2, 46}", "[Имя] процесса", "[ID] процесса", "[Virtual Memory in bytes]"));
                Console.WriteLine(String.Format("{0, -36} {1, 26} {2, 46}", "==============", "=============", "============="));

                for (int i = 0; i < tasklist.Length; i++)
                {
                    Console.WriteLine(String.Format("{0, -36} {1, 26} {2, 46}", $"{tasklist[i].ProcessName}", $"{tasklist[i].Id}", $"{tasklist[i].VirtualMemorySize64}"));
                }
                Console.WriteLine("Для продолжения нажмите <ENTER>");
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Что-то пошло не так...");
            }

        }
        static void ToKillProcessByName()
        {
            try
            {
                Console.WriteLine("Введите ИМЯ процесса для завершения");
                string processName = Console.ReadLine();
                Process[] toGetProcessByName = Process.GetProcessesByName(processName);
                toGetProcessByName[0].Kill();
                Console.WriteLine($"Процесс {toGetProcessByName[0]} завершен.");
                Console.WriteLine("Для продолжения нажмите <ENTER>");
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Что-то пошло не так...");
            }
        }
        static void ToKillProcessById()
        {
            try
            {
                Console.WriteLine("Введите ID процесса для завершения");
                int processId = int.Parse(Console.ReadLine());
                Process toGetProcessById = Process.GetProcessById(processId);
                toGetProcessById.Kill();
                Console.WriteLine($"Процесс {toGetProcessById} завершен.");
                Console.WriteLine("Для продолжения нажмите <ENTER>");
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Что-то пошло не так...");
            }
        }
        static void Main(string[] args)
        {
            //Задача 1:
            Console.WriteLine("Утилита <TaskManager> показывает список всех процессов запущенных на этом компьютере");
            Console.ReadKey();
            Tasklist();
            bool IsWork = true;
            while (IsWork)
            {
                Console.WriteLine($"Меню:\n[killbyname] - остановить процесс по имени;\n[killbyid] - остановить процесс по имени;\n[exit] - завершение программы");
                switch (Console.ReadLine())
                {
                    case "killbyname":
                        Tasklist();
                        ToKillProcessByName();
                        break;
                    case "killbyid":
                        Tasklist();
                        ToKillProcessById();
                        break;
                    case "exit":
                        Console.WriteLine("Для завершения работы программы нажмите ENTER");
                        Console.ReadKey();
                        IsWork = false;
                        break;
                }
            }

        }
    }
}
