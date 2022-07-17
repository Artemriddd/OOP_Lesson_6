using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lesson_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем счет мужа
            Check checkOne = new Check();
            checkOne.balance = 100;
            checkOne.number = 1;
            checkOne.type = Type.Husband;

            // Выводим на экран данные о счете мужа
            PrintType(checkOne.type);
            Console.WriteLine($"Баланс = {checkOne.balance} рублей");
            Console.WriteLine($"Номер счета: {checkOne.number}\n");

            // Создаем счет жены
            Check checkTwo = new Check();
            checkTwo.balance = 200;
            checkTwo.number = 2;
            checkTwo.type = Type.Wife;

            // Выводим на экран данные о счете жены
            PrintType(checkTwo.type);
            Console.WriteLine($"Баланс = {checkTwo.balance} рублей");
            Console.WriteLine($"Номер счета: {checkTwo.number}\n");

            // Создаем счет жены
            Check checkThree = new Check();
            checkThree.balance = 2200;
            checkThree.number = 3;
            checkThree.type = Type.Wife;

            // Выводим на экран данные о счете жены
            PrintType(checkThree.type);
            Console.WriteLine($"Баланс = {checkThree.balance} рублей");
            Console.WriteLine($"Номер счета: {checkThree.number}\n");

            Console.WriteLine(checkOne == checkTwo); // Ожидаем false
            Console.WriteLine(checkThree == checkTwo); // Ожидаем true
            Console.WriteLine(checkTwo.Equals(checkThree)); // Ожидаем true
            Console.WriteLine(checkOne.GetHashCode() == checkThree.GetHashCode());  // Ожидаем false
            Console.WriteLine(checkTwo.GetHashCode() == checkThree.GetHashCode());  // Ожидаем true

            // Все работает корректно!

        }
        // Перенес метод в Main согласно вашему Code Review
        public static void PrintType(Type type)
        {
            switch (type)
            {
                case Type.Husband:
                    Console.WriteLine("Счет мужа");
                    break;
                case Type.Wife:
                    Console.WriteLine("Счет жены");
                    break;
            }
        }

    }
}
