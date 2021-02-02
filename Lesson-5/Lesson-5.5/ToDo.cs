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
    public class ToDo
    {
        public string Title { get; set; } //поля

        public bool IsDone { get; set; } //поля

        public ToDo(string title, bool isDone) //конструктор
        {
            Title = title;

            IsDone = isDone;
        }
        public ToDo() //конструктор
        {
            
        }
    }
}
