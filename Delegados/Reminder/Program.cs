using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Reminder
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string name;
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese el nombre del evento:");
                name = Console.ReadLine();
            } while (name == "");
            Event.Name = name;
            bool flag;
            string date;
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese la fecha actual: (MM/DD/YYYY)");
                date = Console.ReadLine();
                flag = DateValidator(date);
            } while (!flag);
            Event.CurrentDate = Convert.ToDateTime(date);
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese la fecha del evento: (MM/DD/YYYY)");
                date = Console.ReadLine();
                flag = DateValidator(date);
            } while (!flag);
            Event.EventDate = Convert.ToDateTime(date);
            string dias;
            do
            {
                Console.Clear();
                Console.WriteLine("Cuantos dias antes desea que se le recuerde el evento:");
                dias = Console.ReadLine();
            } while (!NumberValidator(dias));
            Event.Reminder = Int32.Parse(dias);
            if (Event.EventDate >= Event.CurrentDate)
            {
                await Asynchronus.WaitForIt();
            }
            else
                Console.WriteLine("La fecha del evento es menor a la fecha actual.");
        }

        public static bool DateValidator(string date)
        {
            Regex regex = new Regex(@"^(0?[1-9]|1[1-2])/(3[0-1]|[1-2][0-9]|0?[1-9])/[\d]{4}$");
            return regex.IsMatch(date);
        }
        public static bool NumberValidator(string number)
        {
            Regex regex = new Regex(@"^[\d]+$");
            return regex.IsMatch(number);
        }
    }

    class Event
    {
        public static string Name { get; set; }
        public static DateTime EventDate { get; set; }
        public static DateTime CurrentDate { get; set; }
        public static int Reminder { get; set; }
    }

    public class Asynchronus
    {
        public static async Task WaitForIt()
        {
            while (Event.EventDate > Event.CurrentDate)
            {
                await Task.Delay(1000);
                if ((Event.EventDate - Event.CurrentDate).Days <= Event.Reminder)
                {
                    Console.Clear();
                    Console.WriteLine($"Faltan {(Event.EventDate - Event.CurrentDate).Days} dias para el evento '{Event.Name}'");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(Event.CurrentDate);
                }
                Event.CurrentDate = Event.CurrentDate.AddDays(1);
            }
            await Task.Delay(1000);
            Console.Clear();
            Console.WriteLine($"El evento '{Event.Name}' es hoy!!");
        }
    }
}
