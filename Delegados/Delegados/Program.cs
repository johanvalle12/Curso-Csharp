using System;

namespace Delegados
{
    class Program
    {
        delegate void Del();
        static void Main(string[] args)
        {
            MainMethod();
        }
        public static void MainMethod()
        {
            Del del = new Del(Message.Show);
            del();

            Del del2 = new Del(Message2.Show);
            del2("GoodBye Show!");
        }
    }

    class Message
    {
        public static void Show()
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Message2
    {
        public static void Show(string message)
        {
            Console.WriteLine(message);
        }
    }
}
