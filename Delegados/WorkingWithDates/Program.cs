using System;

namespace WorkingWithDates
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now.Date;

            var x = date.ToString("dd/MM/yyyy");

            Console.WriteLine(date);
        }
    }
}
