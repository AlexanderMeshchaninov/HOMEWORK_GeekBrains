using System;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace Lesson_7_addon_
{
    class Program
    {
        static void Main(string[] args)
        {
            CatalogWriter catalogWriter = new CatalogWriter
                (
                @"C:\Users\Александр\source\repos\Lesson-7(addon)\Lesson-7(addon)\bin\Debug\netcoreapp3.1\FILES_CATALOG\InputFiles\",
                @"C:\Users\Александр\source\repos\Lesson-7(addon)\Lesson-7(addon)\bin\Debug\netcoreapp3.1\FILES_CATALOG\TempFiles\",
                @"C:\Users\Александр\source\repos\Lesson-7(addon)\Lesson-7(addon)\bin\Debug\netcoreapp3.1\FILES_CATALOG\ReportFiles\"
                );
            Console.WriteLine("Для прочтения файлов нажмите <ENTER>");
            Console.ReadKey();
            catalogWriter.ReadCatalog();
            Console.ReadKey();
        }
    }
}
