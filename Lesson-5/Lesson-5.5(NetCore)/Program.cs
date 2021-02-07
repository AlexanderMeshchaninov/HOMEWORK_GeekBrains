using System;
using System.IO;
using System.Text.Json;

namespace Lesson_5._5_NetCore_
{
    class Program
    {
        static void Json_Serialize(ToDo[] toDoArray)
        {
            //сериализация массива (настройка структурной записи, а не построчно)
            var json = JsonSerializer.Serialize(toDoArray, new JsonSerializerOptions { WriteIndented = true });
            Console.WriteLine("Введите название файла для CОХРАНЕНИЯ: [<tasks.json>]");
            string jsonFileName = Console.ReadLine();
            File.WriteAllText(jsonFileName, json);
            Console.WriteLine("Сериализация прошла успешно!");
            Console.ReadKey();
        }
        static ToDo[] Json_Deserialize()
        {
            //десериализация массива
            Console.WriteLine("Введите название файла для ЗАГРУЗКИ: [<tasks.json>]");
            string jsonFileName = Console.ReadLine();
            string json = File.ReadAllText(jsonFileName);
            return JsonSerializer.Deserialize<ToDo[]>(json);
        }
        static void Print(ToDo[] toDoArray)
        {
            //вывод в консоль массива из десерилизованного файла
            for (int i = 0; i < toDoArray.Length; i++)
            {
                if (toDoArray[i].IsDone == true)
                {
                    Console.WriteLine($"{i+1}| {toDoArray[i].Title} | [X]");
                }
                else
                {
                    Console.WriteLine($"{i+1}| {toDoArray[i].Title} | {toDoArray[i].IsDone}");
                }
            }
        }
        static void SaveTasksInArray()
        {
            Console.WriteLine("Хотите внести новый список задач? [yes/no]");
            if (Console.ReadLine() == "yes")
            {
                string userTask = "";
                //массив задач объекта ToDo
                ToDo[] tasksArray = new ToDo[7];

                for (int i = 0; i < tasksArray.Length; i++)
                {
                    Console.WriteLine($"Введите {i + 1} задачу: ");
                    userTask = Convert.ToString(Console.ReadLine());

                    //конструктор ToDo присваивает параметры введенные с консоли (ввиде объекта) массиву tasksArray
                    ToDo tasks = new ToDo(userTask, false);
                    tasksArray[i] = tasks;
                }
                Console.WriteLine("Список задач внесен.\nСохранить список внесенных задач? [yes/no]");
                if (Console.ReadLine() == "yes")
                {
                    Json_Serialize(tasksArray);
                }
                else
                {
                    return;
                }
            }
        }
        static void LoadArray()
        {
            Console.WriteLine($"Загрузить (десерилизовать) список предыдущих задач на экран? [yes/no]");
            if (Console.ReadLine() == "yes")
            {
                ToDo[] newTasksArray = new ToDo[7];
                newTasksArray = Json_Deserialize();
                //выводит на экран новый десерилизованный массив
                Console.Clear();
                Print(newTasksArray);
                Console.WriteLine("Хотите отметить ваши выполненные задачи? [yes/no]");
                if (Console.ReadLine() == "yes")
                {
                    for (int i = 0; i < newTasksArray.Length; i++)
                    {
                        Console.WriteLine("Наберите порядковый номер задачи <сделано> - [X]");
                        try
                        {
                            int userTaskIsDoneNum = Convert.ToInt32(Console.ReadLine());
                            //когда выбрали номер он объект поменял значени на (выполнено)
                            newTasksArray[userTaskIsDoneNum - 1].IsDone = true;
                            Print(newTasksArray);
                        }
                        catch
                        {
                            Console.WriteLine("Вы хотите сохранить файл? [yes/no]");
                            if (Console.ReadLine() == "yes")
                            {
                                Json_Serialize(newTasksArray);
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                    return;
                }
                else
                {
                    return;
                }
            }
        }
        static void TasksApplication()
        {
            SaveTasksInArray();
            LoadArray();
        }
        static void Main(string[] args)
        {
            //(*)Задача 5:
            //приложение для ввода списка задач
            TasksApplication();

            Console.ReadKey();
        }
    }
}
