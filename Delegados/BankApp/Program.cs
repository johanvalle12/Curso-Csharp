using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var account = new Account("Johan", 1000, 0);
            //Console.WriteLine($"Se creo cuenta con numero {account.Number} con un saldo de ${account.Balance} por el usuario {account.Owner}");

            //var giftCard = new GiftCardAccount("Johan", 1000);
            //giftCard.Deposit(50, DateTime.Now.AddDays(-3), "Para una recarga");
            //giftCard.Deposit(20, DateTime.Now.AddDays(-2), "Para otra una recarga");
            //giftCard.Deposit(100, DateTime.Now.AddDays(-1), "Para el mandado");
            //giftCard.Withdraw(80, DateTime.Now, "Comida");
            //giftCard.PrintHistory();
            //Console.WriteLine(giftCard.GetAccountHistory());

            //var creditAccount = new CreditAccount("Johan", 0, 1000);
            //creditAccount.Withdraw(200, DateTime.Now.AddDays(-3), "Comida");
            //creditAccount.Withdraw(500, DateTime.Now.AddDays(-2), "Ropa");
            //creditAccount.Deposit(600, DateTime.Now.AddDays(-1), "Pago tarjeta de credito");
            //creditAccount.PerformEndMonthTransaction();
            //Console.WriteLine(creditAccount.GetAccountHistory());

            var inversionAccount = new Inversion("Johan", 0);
            inversionAccount.Deposit(200, DateTime.Now.AddDays(-3), "Deposito a Cuenta de Inversion 1");
            inversionAccount.Deposit(500, DateTime.Now.AddDays(-2), "Deposito a Cuenta de Inversion 2");
            inversionAccount.Deposit(600, DateTime.Now.AddDays(-1), "Deposito a Cuenta de Inversion 3");
            inversionAccount.ReditosMensuales();
            Console.WriteLine(inversionAccount.GetAccountHistory());
        }
    }
}
