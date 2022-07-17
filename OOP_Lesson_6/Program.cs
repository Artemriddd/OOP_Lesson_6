using System;

namespace OOP_Lesson_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(); // Тест для точки
            point.color = Color.Red;
            point.IsVisible = true;
            point.X = 0;
            point.Y = 0;
            point.Status();
            point.Print();


            Circle circle = new Circle();  // Тест для круга
            circle.color = Color.Yellow;
            circle.IsVisible = true;
            circle.R = 10;
            circle.X = 10;
            circle.Y = 10;
            circle.Status();
            circle.Print(); // Рисуем
            circle.MoveX(5); // Пробуем сдвинуть
            circle.MoveY(5);
            circle.R = 4;
            circle.Print(); // Рисуем

            Rectangle rectangle = new Rectangle();  // Тест для прямоугольника
            rectangle.IsVisible = true;
            rectangle.color = Color.Green;
            rectangle.X = 0;
            rectangle.Y = 0;
            rectangle.SizeA = 3;  // Размеры сторон
            rectangle.SizeB = 3;
            rectangle.Status();
            rectangle.MoveX(5);  // Пробуем сдвинуть
            rectangle.MoveY(5);
            rectangle.Status();  // Проверяем, что координаты изменились
            rectangle.Print();  // Рисуем
            rectangle.MoveX(15);   // Пробуем сдвинуть еще раз
            rectangle.MoveY(15);  
            rectangle.ChangeColor(Color.Blue);  // Пробуем менять цвет
            rectangle.Print();   // Рисуем с новым цветом и в новом месте
            Console.ReadKey(true);

        }
    }
}
