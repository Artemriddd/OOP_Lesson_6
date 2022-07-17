using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lesson_6
{
    public enum Type { Wife, Husband };
    public class Check
    {
        private int _number;
        private decimal _balance;
        private Type _type;

        public int number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
            }
        }
        public decimal balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }
        public Type type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }

        public void AddMoney(decimal money)
        {
            Console.WriteLine($"Пополнение баланса на {money} рублей\n");
            balance += money;
        }
        public void LostMoney(decimal money)
        {
            if (balance - money >= 0)
            {
                Console.WriteLine($"Покупка на {money} рублей");
                balance -= money;
            }
            else
            {
                Console.WriteLine($"Покупка на {money} рублей");
                Console.WriteLine("Недостаточно средств");
            }
        }
        public void TransferMoney(Check check, decimal money)
        {
            if (check.balance - money >= 0)
            {
                Console.WriteLine($"Перевод от {check.type} на {money} рублей");
                check.balance -= money;
                AddMoney(money);
            }
            else
            {
                Console.WriteLine($"Перевод на {money} рублей");
                Console.WriteLine("Недостаточно средств");
            }
        }
        /// <summary>
        /// Переопределил метод ==
        /// </summary>
        /// <param name="check1"></param>
        /// <param name="check2"></param>
        /// <returns></returns>
        public static bool operator ==(Check check1, Check check2)
        {
            return (check1.type == check2.type);
        }
        /// <summary>
        /// Переопределил метод !=
        /// </summary>
        /// <param name="check1"></param>
        /// <param name="check2"></param>
        /// <returns></returns>
        public static bool operator !=(Check check1, Check check2)
        {
            return (check1.type != check2.type);
        }
        /// <summary>
        /// Переопределил метод Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is Check check)
            {
                return type.Equals(check.type);
            }
            return false;
        }
        /// <summary>
        /// Переопределил метод GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return type.GetHashCode();
        }

    }
}

