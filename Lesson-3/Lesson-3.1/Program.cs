using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1:
            {
                //вариант первый
                int[,] array2D = new int[5, 5];
                array2D[0, 0] = 1;
                array2D[1, 1] = 1;
                array2D[2, 2] = 1;
                array2D[3, 3] = 1;
                array2D[4, 4] = 1;
                for (int i = 0; i < array2D.GetLength(0); i++)
                {
                    for (int j = 0; j < array2D.GetLength(1); j++)
                    {
                        Console.Write("{0,3}", array2D[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            {
                //вариант второй
                int[,] array2D = new int[10, 10];
                for (int i = 0; i < array2D.GetLength(0); i++)
                {
                    array2D[i, i] = 1;
                    for (int j = 0; j < array2D.GetLength(1); j++)
                    {
                        array2D[j, j] = 1;
                        Console.Write("{0,3}", array2D[i, j]);
                    }
                    Console.WriteLine();
                }

            }
            Console.ReadKey();
        }
    }
}
