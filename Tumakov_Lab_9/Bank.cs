using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_Lab_9
{
    public enum Type_Akk
    {
        Balance,
        SberKniga
    }
    internal class Bank
    {
        private static int id_counts = 0;
        private int id;
        private decimal balance;
        private Type_Akk _type;
        public void Id()
        {
            id_counts++;
            id = id_counts;
        }
        
        public Bank(decimal balance, Type_Akk _type)
        {
            Id();
            this.balance = balance;
            this._type = _type;
        }
        public Bank(decimal balance)
        {
            Id();
            this.balance = balance;
        }
        public Bank(Type_Akk _type)
        {
            Id();
            this._type = _type;
        }
        public void Transfer(Bank bank1, decimal sum)
        {
            if (balance < sum)
            {
                Console.WriteLine("No money");
            }
            else
            {
                BankTransaction transaction = new BankTransaction(sum);
                balance -= sum;
                bank1.balance += sum;
                
            }
        }
        public void Dispose(decimal sum)
        {
            BankTransaction transaction = new BankTransaction(sum);
            File.WriteAllText("Operations.txt", transaction.Print());
            GC.SuppressFinalize(transaction);
        }
    }
}
