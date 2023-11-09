using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_Lab_9
{
    internal class BankTransaction
    {
        readonly decimal sum;
        DateTime t_time
        {  get; set; }
        public BankTransaction(decimal sum)
        {
            t_time = DateTime.Now;
            this.sum = sum;
        }
        public string Print()
        {
            return $"В {t_time} была проведена операция на сумму: {sum}";
        }
    }
}
