using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lesson_6
{
    class Circle : Point
    {


        private int _r;
        public new int X
        {
            get
            {
                return _x;
            }
            set
            {
                if (value <= 0 || value < R)
                {
                    throw new Exception("Изначальная точка должна быть больше 0 и больше радиуса");
                }
                else
                {
                    _x = value;
                }
            }
        }
        public new int Y
        {
            get
            {
                return _y;
            }
            set
            {
                if (value <= 0 || value < R)
                {
                    throw new Exception("Изначальная точка должна быть больше 0 и больше радиуса");
                }
                else
                {
                    _y = value;
                }
            }
        }
        public int R
        {
            get
            {
                return _r;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Радиус должен быть больше 0");
                }
                else
                {
                    _r = value;
                }

            }
        }
        /// <summary>
        /// Вычисляет радиус
        /// </summary>
        /// <returns></returns>
        public double CircleArea()
        {
            return Math.PI * R * R;
        }
        /// <summary>
        /// Новый метод вывода на экран для окружности
        /// </summary>
        public new void Status()
        {
            Console.WriteLine($"Видимый: {IsVisible}, Цвет: {color}, Координата X: {X}, Координата Y: {Y}, Площадь {Math.Round(CircleArea(), 1)}");
        }
        /// <summary>
        /// Рисуем круг(ромб)
        /// </summary>
        public new void Print()
        {
            int x = X;
            int y = Y;
            int r = R;
            if (IsVisible == true)
            {
                Console.Clear();
                ChangeColor(color);
                for (int a = 0; a < r; a++)
                {
                    Console.SetCursorPosition(x+a, y+r);
                    Console.Write("*");
                    y--;
                 }
                y = Y;
                x = X;
                for (int a = 0; a < r; a++)
                {
                    Console.SetCursorPosition(x+r, y-a);
                    Console.Write("*");
                    x--;
                }
                y = Y;
                x = X;
                for (int a = 0; a < r; a++)
                {
                    Console.SetCursorPosition(x - a, y - r);
                    Console.Write("*");
                    y++;
                }
                y = Y;
                x = X;
                for (int a = 0; a < r; a++)
                {
                    Console.SetCursorPosition(x - r, y + a);
                    Console.Write("*");
                    x++;
                }
            }
            else
            {
                Console.WriteLine("Деталь невидима");
            }
            Console.ResetColor();
        }
    }
}
