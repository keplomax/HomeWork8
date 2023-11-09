using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_Lab_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // упр 9.1 
            Console.WriteLine("УПР 9.1 Добавить в банковский счет конструкторы");
            decimal bal_1, bal_2, sum;
            bool ch1;
            do
            {
                Console.WriteLine("Введите баланс 1-го аккаунта");
                ch1 = decimal.TryParse(Console.ReadLine(), out bal_1);
            }
            while (!ch1);
            do
            {
                Console.WriteLine("Введите баланс 2-го аккаунта");
                ch1 = decimal.TryParse(Console.ReadLine(), out bal_2);
            }
            while (!ch1);
            Bank bank1 = new Bank(bal_1, Type_Akk.Balance);
            Bank bank2 = new Bank(bal_2);
            Bank bank3 = new Bank(Type_Akk.Balance);
            // упр 9.2 
            Console.WriteLine("УПР 9.2 Создание нового класса для хранения всех операций");
            do
            {
                Console.WriteLine("Введите сумму которую вы хотите внести.");
                ch1 = decimal.TryParse(Console.ReadLine(), out sum);
            }
            while (!ch1);
            bank1.Transfer(bank1, sum);
            // УПР 9.3
            bank1.Dispose(sum);

        }
    }
}
