using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lesson_6
{
    class Point:Figure
    {
        /// <summary>
        /// Рисует точку на экране
        /// </summary>
        public void Print()
        {
            if(IsVisible == true)
            {
                Console.Clear();
                Console.SetCursorPosition(X, Y);
                ChangeColor(color);
                Console.Write("*");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Деталь невидима");
            }
        }
    }
}
