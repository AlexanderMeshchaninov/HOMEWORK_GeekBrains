using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_5._4
{
    class Program
    {
        /// <summary>
        /// Метод для создания директории
        /// </summary>
        /// <param name="createDir">Директория для записи</param>
        static void CreateDirections(string createDir)
        {
            createDir = createDir; //название создаваемой директории

            Directory.CreateDirectory(createDir); //создает нужные директории с вложенностями

            Console.WriteLine($"Указанная директория {createDir}\nСтатус :{ Directory.Exists(createDir)}"); //проверка есть ли такая дериктория с вложенностями True / False
        }
        /// <summary>
        /// Метод для записи файла
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        /// <param name="createDir">Директория для записи</param>
        static void InputFileToDir(string fileName, string createDir)
        {
            string noteText = $"В этот файл записана директория где он создан: {createDir}"; //текст по умолчанию, который записывается в файл txt

            fileName = fileName; //имя файла

            string notePath = Path.Combine(createDir, fileName); //прописываем путь к файлу

            File.WriteAllText(notePath, noteText); //создаем файл с текстом по умолчанию, записываем текст по умолчанию в файл

            Console.WriteLine($"Файл {fileName}\nСтатус: {File.Exists(notePath)}"); //проверка есть ли такой файл в директории True / False
        }
        /// <summary>
        /// Метод сохраняет дерево каталогов и файлов по заданному пути в текстовый файл
        /// </summary>
        static void SaveAllDirsAndFilesToSaveFile(string createDir)
        {
            string saveFileName = "SAVEFILE.txt"; //название файла который содержит в себе всю информаю о директориях и вложенных файлах

            string saveFileDir = @"C:\MyExampleDir"; //директория для создания файла

            string saveFilePath = Path.Combine(saveFileDir, saveFileName);

            string[] entries = Directory.GetFileSystemEntries(createDir, "*", SearchOption.AllDirectories);

            File.AppendAllLines(saveFilePath, entries); //добавляет строки в указанный файл.

            Console.WriteLine($"Файл со всем перечнем каталогов и файлов сохранен.\nСтатус: { File.Exists(saveFilePath)}");
        }
        /// <summary>
        /// Записывает информацию о директориях
        /// </summary>
        /// <param name="startDir">директория</param>
        /// <param name="i">итератор</param>
        /// <returns></returns>
        static string [] SaveAllDirsInfoRecursionaly(string startDir, int i = 0)
        {
            string[] directories = Directory.GetDirectories(startDir, "*", SearchOption.AllDirectories);

            //Терминальное условие
            if (i >= directories.Length)
            {
                Console.WriteLine($"Файл со всем перечнем каталогов сохранен.");
                return null;
            }

            SaveAllDirsInfoRecursionaly(@"C:\MyExampleDir\Notes\Texts\", i + 1);
            return directories;
        }
        /// <summary>
        /// Записывает всю информацию о файлах
        /// </summary>
        /// <param name="startDir">директория</param>
        /// <param name="i">итератор</param>
        /// <returns></returns>
        static string[] SaveAllFilesInfoRecursionaly(string startDir, int i = 0)
        {
            string[] files = Directory.GetFiles(startDir, "*.*", SearchOption.AllDirectories);

            //Терминальное условие
            if (i >= files.Length)
            {
                Console.WriteLine($"Файл со всем перечнем файлов сохранен.");
                return null;
            }

            SaveAllFilesInfoRecursionaly(@"C:\MyExampleDir\Notes\Texts\", i + 1);
            return files;
        }
        static void Main(string[] args)
        {
            {
                //(*)Задача 4:
                //способ первый (без рекурсии)

                //Методы создания директорий и записи файлов
                //CreateDirections(@"C:\MyExampleDir\Notes\Texts");
                //InputFileToDir("Note3.txt", @"C:\MyExampleDir\Notes\Texts");

                //Метод сохраняющий всю информацию о директориях и файлах в один SAVEFILE.txt
                //SaveAllDirsAndFilesToSaveFile(@"C:\MyExampleDir\"); //пишем изначально созданную директорию, чтобы записать файл со всей информацией

                //Console.ReadKey();
            }
            {
                //способ второй (с рекурсией)
                string saveFilePath = Path.Combine(@"C:\MyExampleDir\", "SAVEFILE_RECURSION.txt"); //путь для записи файла
                File.AppendAllLines(saveFilePath, SaveAllDirsInfoRecursionaly(@"C:\MyExampleDir\")); //записывает дерево директорий в файл
                File.AppendAllLines(saveFilePath, SaveAllFilesInfoRecursionaly(@"C:\MyExampleDir\")); //записывает информацию о всех файлах в директориях

                Console.ReadKey();
            }


            
        }
    }
}
