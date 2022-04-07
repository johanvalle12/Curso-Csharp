using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class CreditAccount : Account
    {
        public CreditAccount(string name, decimal initialBalance, int creditLimit) : base(name, initialBalance, -creditLimit)
        {

        }

        public void PerformEndMonthTransaction()
        {
            if(Balance < 0)
            {
                var interest = -Balance * 0.07m;
                Withdraw(interest, DateTime.Now, "Cargo de interes mensual");
            }
        }

        protected override Transaction CheckWithdrawalLimit(bool isOvercharged) => isOvercharged ? new Transaction(-20, DateTime.Now, "Cargo por sobregiro") : default;
    } 
}
