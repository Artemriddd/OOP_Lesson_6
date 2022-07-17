using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lesson_6
{
    class Rectangle : Point
    {
        private int _sizeA;
        private int _sizeB;

        public int SizeA
        {
            get
            {
                return _sizeA;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Размер должен быть больше 0");
                }
                else
                {
                    _sizeA = value;
                }
            }
        }
        public int SizeB
        {
            get
            {
                return _sizeB;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Размер должен быть больше 0");
                }
                else
                {
                    _sizeB = value;
                }
            }
        }
        /// <summary>
        /// Плодащь прямоугольника
        /// </summary>
        /// <returns></returns>
        public int RectangleArea()
        {
            return SizeA * SizeB;
        }
        /// <summary>
        /// Новый метод вывода на экран для прямоугольника
        /// </summary>
        public new void Status()
        {
            Console.WriteLine($"Видимый: {IsVisible}, Цвет: {color}, Координата X: {X}, Координата Y: {Y}, Длина: {SizeA}, Ширина: {SizeB}, Площадь {RectangleArea()}");
        }
        /// <summary>
        /// Рисуем прямоугольник
        /// </summary>
        public new void Print()
        {

            int x = X;
            int y = Y;
            if (IsVisible == true)
            {
                Console.Clear();
                ChangeColor(color);
                for (int a = 1; a<SizeA; a++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write("*");
                    x++;
                }
                for (int a = 1; a < SizeB; a++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write("*");
                    y++;
                }
                for (int a = 1; a < SizeA; a++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write("*");
                    x--;
                }
                for (int a = 1; a < SizeB; a++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write("*");
                    y--;
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
