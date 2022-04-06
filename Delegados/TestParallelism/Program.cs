using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace TestParallelism
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Tienes 15 segundos para responder unas preguntas, ¿Estas listo? Si (s) No (n)");
            while (Console.ReadLine() != "s")
            {
                Console.Clear();
                Console.WriteLine("¿Y ahora? Si (s) No (n)");
            }
            await Parallelism.Proceso();
        }
    }

    public class Parallelism
    {
        public static async Task Proceso()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var task1 = Tiempo(); // await Process1();
            var task2 = Preguntas(); // await Process2();

            var task3 = await Task.WhenAny(task1, task2);

            stopwatch.Stop();
            if (task3 == task2)
                Console.WriteLine($"Tiempo transcurrido: {stopwatch.ElapsedMilliseconds / 1000m} segundos.");
        }

        public static async Task Tiempo()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(15000);
                Console.WriteLine("Se termino el tiempo.");
            });
        }

        public static async Task Preguntas()
        {
            var respuestasCorrectas = 0;
            await Task.Run(() =>
            {
                Console.WriteLine($"¿A cuantos bits equivale un byte?:\na) 8 Bits.\nb) 4 Bits.\nc) 1 Bit.");
                respuestasCorrectas += (Console.ReadLine() == "a") ? 1 : 0;
                Console.WriteLine($"¿Cuantos dias tiene un año?:\na) 300 Dias.\nb) 366 Dias.\nc) 365 Dias.");
                respuestasCorrectas += (Console.ReadLine() == "c") ? 1 : 0;
                Console.WriteLine($"¿Cual es el tercer planeta del sistema solar?:\na) Marte.\nb) La Tierra.\nc) Venus.");
                respuestasCorrectas += (Console.ReadLine() == "b") ? 1 : 0;
                Console.WriteLine($"El resultado del examen es {respuestasCorrectas / 3m * 100}");
            });
        }
    }
}
