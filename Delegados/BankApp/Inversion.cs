using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Inversion : Account
    {
        public Inversion(string name, decimal initialBalance) : base(name, initialBalance)
        {

        }
        public void ReditosMensuales()
        {
            if (Balance > 500)
            {
                var reditos = Balance * 0.05m;
                Deposit(reditos, DateTime.Now, "Reditos Mensuales");
            }
        }
    }
}
