using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_5._5_NetCore_
{
    public class ToDo
    {
        public string Title { get; set; } //поля

        public bool IsDone { get; set; } //поля
        public ToDo()
        { 
        }
        public ToDo(string title, bool isDone) //конструктор
        {
            Title = title;

            IsDone = isDone;
        }
    }
}
