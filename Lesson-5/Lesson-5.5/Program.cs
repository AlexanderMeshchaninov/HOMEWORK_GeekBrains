using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace Lesson_5._5
{
    class Program
    {
        static void SerializeJson(ToDo[] toDoArray)
        {
            //сериализация массива (настройка структурной записи, а не построчно)
            string json = JsonSerializer.Serialize(toDoArray, new JsonSerializerOptions() {WriteIndented = true});
            File.WriteAllText("tasks.json", json);
            Console.WriteLine("Сериализация прошла успешно!");
            Console.ReadKey();
        }
        static void DeserializeJson()
        {
            //десериализация массива
            string json = File.ReadAllText("tasks.json");
            
        }
        static void PrintToDoArray(ToDo[] toDoArray)
        {
            for (int i = 0; i <= toDoArray.Length; i++)
            {
                Console.WriteLine($"Список задач: {i} - {toDoArray[i]}");
            }
        
        }
        static void Main(string[] args)
        {
            //(*)Задача 5:
            //объекты задач
            //ToDo monday = new ToDo("Помыть автомобиль", true);
            //ToDo tuesday = new ToDo("Пойти за покупками", false);
            //ToDo wednesday = new ToDo("Погулять с собакой", true);
            //ToDo thursday = new ToDo("Позвонить родителям", false);
            //ToDo friday = new ToDo("Сделать домашнее задание по С-sharp", true);
            //ToDo saturday = new ToDo("Лечь спать пораньше", false);
            //ToDo sunday = new ToDo("Почитать про рекурсию", true);

            //создание массива объектов
            var toDoArray = new ToDo[7];
            //toDoArray[0] = monday;
            //toDoArray[1] = tuesday;
            //toDoArray[2] = wednesday;
            //toDoArray[3] = thursday;
            //toDoArray[4] = friday;
            //toDoArray[5] = saturday;
            //toDoArray[6] = sunday;

            //SerializeJson(toDoArray);

            var json = File.ReadAllText("tasks.json");
            toDoArray = JsonSerializer.Deserialize<ToDo[]>(json);

            


            Console.ReadKey();
        }
    }
}
