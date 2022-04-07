using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class GiftCardAccount : Account
    {

        public GiftCardAccount(string name, decimal initialBalance) : base(name, initialBalance)
        {

        }

        public void PrintHistory()
        {
            decimal balance = 0;
            Console.WriteLine($"Date\t\tAmount\tBalance\tDescription");
            foreach(var transaction in TransactionList)
            {
                balance += transaction.Amount;
                Console.WriteLine($"{transaction.Date.ToShortDateString()}\t{transaction.Amount}\t{balance}\t{transaction.Description}");
            }
        }

        
    }
}
