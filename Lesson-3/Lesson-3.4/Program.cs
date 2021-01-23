using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //(*)Задача 4:
                string [,] gameArr = new string[10, 10];
                //расположение кораблей
                gameArr[1, 1] = "X"; gameArr[7, 6] = "X";
                gameArr[1, 8] = "X"; gameArr[8, 4] = "X";
                gameArr[2, 8] = "X"; gameArr[9, 4] = "X";
                gameArr[3, 8] = "X"; gameArr[9, 6] = "X";
                gameArr[3, 5] = "X"; gameArr[9, 7] = "X";
                gameArr[3, 6] = "X"; gameArr[9, 8] = "X"; 
                gameArr[7, 2] = "X"; gameArr[5, 8] = "X";
                gameArr[6, 4] = "X"; gameArr[4, 1] = "X"; 
                gameArr[4, 3] = "X"; gameArr[4, 4] = "X";
                gameArr[7, 1] = "X"; gameArr[4, 2] = "X";
                for (int i = 0; i < gameArr.GetLength(0); i++)
                {
                    for (int j = 0; j < gameArr.GetLength(1); j++)
                    {
                        if (gameArr[i, j] != "X")
                        {
                            gameArr[i, j] = "O";
                        }

                        Console.Write("{0,3}", gameArr[i, j]);
                    }
                    Console.WriteLine();
                }

                Console.ReadKey();
            }
        }
    }
}
