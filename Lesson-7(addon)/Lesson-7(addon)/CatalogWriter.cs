using System;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Timers;

namespace Lesson_7_addon_
{
    /// <summary>
    /// Класс для работы с каталогами.
    /// Читает файлы из каталога, делает метку о прочтении с проставлением времени, создает на данный день файл-отчет и перемещает прочтенные файлы в директорию TempFiles
    /// </summary>
    public class CatalogWriter
    {
        private string InputFilesPath { get; set; }
        private string TempFilesPath { get; set; }
        private string ReportFilesPath { get; set; }
        public CatalogWriter(string inputFilesPath, string tempFilesPath, string reportFilesPath)
        {
            InputFilesPath = inputFilesPath;
            TempFilesPath = tempFilesPath;
            ReportFilesPath = reportFilesPath;
        }
        /// <summary>
        /// Метод удаляющий файлы из директории TempFiles через 10 дней
        /// </summary>
        public void CheckFilesToDelete(int deleteEveryDays)
        {
            try
            {
                DateTime deleteDay = DateTime.Now.AddDays(-deleteEveryDays);
                DirectoryInfo directoryInfo = new DirectoryInfo(TempFilesPath);
                FileInfo[] fileToDeleteInfo = directoryInfo.GetFiles();
                for (int i = 0; i < fileToDeleteInfo.Length; i++)
                {
                    if (fileToDeleteInfo.Length == 0)
                    {
                        throw new ArgumentNullException();
                    }
                    else if (fileToDeleteInfo[i].LastWriteTime < deleteDay)
                    {
                        File.Delete(fileToDeleteInfo[i].FullName);
                    }
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine($"Файлов для удаления в директории:\n{TempFilesPath} нет!");
                return;
                Console.ReadLine();
            }

        }
        /// <summary>
        /// Второстепенный метод, который создает отчет о прочитанных файлах и сохраняет его в директорию ReportFiles
        /// </summary>
        /// <param name="readInputFiles">Массив прочитанных файлов для написания отчета</param>
        private void WriteReport(string [] readInputFiles)
        {
            string time = DateTime.Now.ToString("HH:mm:ss");
            string date = DateTime.Now.ToString("dd/MM/yyyy");

            string reportFileName = $"ReportFile_{date}.txt";
            string reportFileText = $"\nЭТОТ ФАЙЛ ПРОЧИТАН В: {time}";
            string reportFilePath = Path.Combine(ReportFilesPath, reportFileName);

            for (int i = 0; i < readInputFiles.Length; i++)
            {
                readInputFiles[i] += reportFileText;
            }

            File.AppendAllLines(reportFilePath, readInputFiles);
            Console.WriteLine($"Отчет создан: {reportFileName}");
        }
        /// <summary>
        /// Второстепенный метод, который перемещает прочтенные файлы в диреторию TempFiles
        /// </summary>
        /// <param name="InputFilesPath"></param>
        private void MoveReadyFiles(string InputFilesPath)
        {
            string [] filesToMoveTemp = Directory.GetFiles(InputFilesPath);

            for (int i = 0; i < filesToMoveTemp.Length; i++)
            {
                string getOnlyFileName = Path.GetFileName(filesToMoveTemp[i]);
                string concatString = TempFilesPath + getOnlyFileName;
                File.Move(filesToMoveTemp[i], concatString);
                Console.WriteLine($"Прочтенные файлы: \n{filesToMoveTemp[i]} перемещены");
            }
        }
        /// <summary>
        /// Главный метод класса: читает список файлов, затем сохраняет отчет и перемещает прочтенные файлы в директорию TempFiles
        /// </summary>
        public void ReadCatalog()
        {
            //ловит момент когда в директории InputFiles нет файлов и выбрасывает ошибку (честно говоря, точно не смог подобрать класс ошибки).
            try
            {
                string[] inputFilesArray = Directory.GetFiles(InputFilesPath);
                if (inputFilesArray.Length == 0)
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    for (int i = 0; i < inputFilesArray.Length; i++)
                    {
                        string[] readInputFiles = File.ReadAllLines(inputFilesArray[i]);
                        Console.WriteLine($"Файлы прочитаны:\n{inputFilesArray[i]}");
                        WriteReport(readInputFiles);
                    }
                    MoveReadyFiles(InputFilesPath);
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine($"Файлов для прочтения в директории:\n{InputFilesPath} нет!");
                return;
                Console.ReadLine();
            }
        }
    }
}
