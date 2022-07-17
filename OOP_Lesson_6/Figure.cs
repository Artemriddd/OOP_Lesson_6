using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lesson_6
{
    public enum Color
    {
        Red,
        Yellow,
        Green,
        Blue,
        Gray,
        White
    }
    public class Figure
    {
        private Color _color;
        private bool _isVisible;
        protected int _x;
        protected int _y;

        public bool IsVisible
        {
            get
            {
                return _isVisible;
            }
            set
            {
                _isVisible = value;
            }
        }
        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Координата должна быть больше 0");
                }
                else
                {
                    _x = value;
                }
            }
        }
        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Координата должна быть больше 0");
                }
                else
                {
                    _y = value;
                }
            }
        }
        public Color color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        /// <summary>
        /// Передвижение по горизонтали
        /// </summary>
        /// <param name="x"></param>
        public void MoveX(int x)
        {
            if(X+x<0)
            {
                throw new Exception("Выход за границу поля");
            }
            else
            {
                X += x;
            }
           
        }
        /// <summary>
        /// Передвижение по вертикали
        /// </summary>
        /// <param name="y"></param>
        public void MoveY(int y)
        {
            if (Y + y < 0)
            {
                throw new Exception("Выход за границу поля");
            }
            else
            {
                Y += y;
            }
        }
        /// <summary>
        /// Изменение цвета
        /// </summary>
        /// <param name="color1"></param>
        public void ChangeColor(Color color1)
        {
            switch (color1)
            {
                case Color.Red:
                    color = color1;
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Color.Blue:
                    color = color1;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case Color.Gray:
                    color = color1;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case Color.Green:
                    color = color1;
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case Color.White:
                    color = color1;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case Color.Yellow:
                    color = color1;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
            }
        }
        /// <summary>
        /// Видимый или нет
        /// </summary>
        /// <returns></returns>
        public bool Visible()
        {
            return IsVisible;
        }
        /// <summary>
        /// Метод вывода на экран информации об объекте
        /// </summary>
        public void Status()
        {
            Console.WriteLine($"Видимый: {IsVisible}, Цвет: {color}, Координата X: {X}, Координата Y: {Y}.");
        }
    }

}
