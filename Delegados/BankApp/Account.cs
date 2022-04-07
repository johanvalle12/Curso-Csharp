using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class Account
    {
        public string Owner { get; set; }
        public string Number { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var transaction in TransactionList)
                {
                    balance += transaction.Amount;
                }
                return balance;
            }
        }
        protected readonly int _minimumBalance;
        private static int AccountNumberSeed = 123456789;
        public List<Transaction> TransactionList = new List<Transaction>();

        public Account(string name, decimal initialBalance) : this(name, initialBalance, 0){}

        public Account(string name, decimal initialBalance, int minimumBalance)
        {
            Owner = name;
            _minimumBalance = minimumBalance;

            Number = AccountNumberSeed.ToString();
            AccountNumberSeed++;

            if (initialBalance > 0)
                Deposit(initialBalance, DateTime.Now, "Balance Inicial");
        }

        public void Deposit(decimal amount, DateTime date, string description)
        {
            if (amount <= 0)
                Console.WriteLine("El deposito debe ser mayor a cero.");
            else
            {
                var deposit = new Transaction(amount, date, description);
                TransactionList.Add(deposit);
            }
        }

        public virtual void Withdraw(decimal amount, DateTime date, string description)
        {
            if (amount <= 0)
                Console.WriteLine("El monto a retirar debe ser mayor a cero.");
            else
            {
                var transaction = CheckWithdrawalLimit(Balance - amount < _minimumBalance);
                var withdrawal = new Transaction(-amount, date, description);
                TransactionList.Add(withdrawal);

                if(transaction != null)
                    TransactionList.Add(transaction);
            }
        }

        public string GetAccountHistory()
        {
            decimal balance = 0;
            var report = new StringBuilder();
            report.AppendLine("Date\t\tAmount\tBalance\tDescription");
            foreach (var transaction in TransactionList)
            {
                balance += transaction.Amount;
                report.AppendLine($"{transaction.Date.ToShortDateString()}\t{transaction.Amount}\t{balance}\t{transaction.Description}");
            }
            return report.ToString();
        }

        protected virtual Transaction CheckWithdrawalLimit(bool isOverCharge)
        {
            if (isOverCharge)
                throw new InvalidOperationException("No tienes fondos suficientes");
            else
            {
                return default;
            }
        }
    }
}
