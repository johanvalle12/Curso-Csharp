using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($" Selecciona una operacion:\n 1.- Suma.\n 2.- Resta.\n 3.- Division.\n 4.- Multiplicacion.\n 5.- Seno.\n 6.- Coseno.\n 7.- Exponencial.");
            var option = Console.ReadLine();
            DelegateCalculator.Operate(option);
            FunctionCalculator.FunctionOperate(option);
        }
    }

    public class DelegateCalculator
    {
        public delegate double SelfOperator(double x);
        public delegate double Operator(double x, double y);


        public static void Operate(string option)
        {
            switch (option)
            {
                case "1":
                    {
                        Console.Clear();
                        Console.WriteLine($"Ingresa el primer numero.");
                        var inputX = Console.ReadLine();
                        Console.WriteLine($"Ingresa el segundo numero.");
                        var inputY = Console.ReadLine();
                        if (Double.TryParse(inputX, out double num) && Double.TryParse(inputY, out double num2))
                        {
                            Operator addition = new Operator((x, y) => x + y);
                            Console.WriteLine($"La suma es igual a: {addition(num, num2)}");
                        }
                        else
                            Console.WriteLine($"Ingrese numeros validos.");
                        break;
                    }
                case "2":
                    {
                        Console.Clear();
                        Console.WriteLine($"Ingresa el primer numero.");
                        var inputX = Console.ReadLine();
                        Console.WriteLine($"Ingresa el segundo numero.");
                        var inputY = Console.ReadLine();
                        if (Double.TryParse(inputX, out double num) && Double.TryParse(inputY, out double num2))
                        {
                            Operator substraction = new Operator((x, y) => x - y);
                            Console.WriteLine($"La resta es igual a: {substraction(num, num2)}");
                        }
                        else
                            Console.WriteLine($"Ingrese numeros validos.");
                        break;
                    }
                case "3":
                    {
                        Console.Clear();
                        Console.WriteLine($"Ingresa el primer numero.");
                        var inputX = Console.ReadLine();
                        Console.WriteLine($"Ingresa el segundo numero.");
                        var inputY = Console.ReadLine();
                        if (Double.TryParse(inputX, out double num) && Double.TryParse(inputY, out double num2))
                        {
                            Operator division = new Operator((x, y) => x / y);
                            Console.WriteLine($"La division es igual a: {division(num, num2)}");
                        }
                        else
                            Console.WriteLine($"Ingrese numeros validos.");
                        break;
                    }
                case "4":
                    {
                        Console.Clear();
                        Console.WriteLine($"Ingresa el primer numero.");
                        var inputX = Console.ReadLine();
                        Console.WriteLine($"Ingresa el segundo numero.");
                        var inputY = Console.ReadLine();
                        if (Double.TryParse(inputX, out double num) && Double.TryParse(inputY, out double num2))
                        {
                            Operator multiplication = new Operator((x, y) => x * y);
                            Console.WriteLine($"La multiplicacion es igual a: {multiplication(num, num2)}");
                        }
                        else
                            Console.WriteLine($"Ingrese numeros validos.");
                        break;
                    }
                case "5":
                    {
                        Console.Clear();
                        Console.WriteLine($"Ingresa un numero.");
                        var inputX = Console.ReadLine();
                        if (Double.TryParse(inputX, out double num))
                        {
                            Operator seno = new Operator((x, y) => Math.Sin(x * Math.PI / 180));
                            Console.WriteLine($"El seno es igual a: {seno(num, 0)}");
                        }
                        else
                            Console.WriteLine($"Ingrese un numero valido.");
                        break;
                    }
                case "6":
                    {
                        Console.Clear();
                        Console.WriteLine($"Ingresa un numero.");
                        var inputX = Console.ReadLine();
                        if (Double.TryParse(inputX, out double num))
                        {
                            Operator coseno = new Operator((x, y) => Math.Cos(x * Math.PI / 180));
                            Console.WriteLine($"El coseno es igual a: {coseno(num, 0)}");
                        }
                        else
                            Console.WriteLine($"Ingrese un numero valido.");
                        break;
                    }
                case "7":
                    {
                        //Exp(x): Exponencial de x (e elevado a x)
                        //E, el número "e", con un valor de 2.71828...
                        Console.Clear();
                        Console.WriteLine($"Ingresa un numero.");
                        var inputX = Console.ReadLine();
                        if (Double.TryParse(inputX, out double num))
                        {
                            Operator exponencial = new Operator((x, y) => Math.Exp(x));
                            Console.WriteLine($"El exponencial es igual a: {exponencial(num, 0)}");
                        }
                        else
                            Console.WriteLine($"Ingrese un numero valido.");
                        break;
                    }
            }
            //SelfOperator square = new SelfOperator(x => x * x);
            //Console.WriteLine($"The first square operation result is: {square(num)}\nThe second square operation result is: {square(num2)}\n");
        }
    }

    public class FunctionCalculator
    {
        public static void FunctionOperate(string option)
        {
            switch (option)
            {
                case "1":
                    {
                        
                        Console.WriteLine($"Ingresa el primer numero.");
                        var inputX = Console.ReadLine();
                        Console.WriteLine($"Ingresa el segundo numero.");
                        var inputY = Console.ReadLine();
                        if (Double.TryParse(inputX, out double num) && Double.TryParse(inputY, out double num2))
                        {
                            Func<double, double, double> addition = (x, y) => x + y;
                            Console.WriteLine($"La suma es igual a: {addition(num, num2)}");
                        }
                        else
                            Console.WriteLine($"Ingrese numeros validos.");
                        break;
                    }
                case "2":
                    {
                        
                        Console.WriteLine($"Ingresa el primer numero.");
                        var inputX = Console.ReadLine();
                        Console.WriteLine($"Ingresa el segundo numero.");
                        var inputY = Console.ReadLine();
                        if (Double.TryParse(inputX, out double num) && Double.TryParse(inputY, out double num2))
                        {
                            Func<double, double, double> substraction = (x, y) => x - y;
                            Console.WriteLine($"La resta es igual a: {substraction(num, num2)}");
                        }
                        else
                            Console.WriteLine($"Ingrese numeros validos.");
                        break;
                    }
                case "3":
                    {
                        
                        Console.WriteLine($"Ingresa el primer numero.");
                        var inputX = Console.ReadLine();
                        Console.WriteLine($"Ingresa el segundo numero.");
                        var inputY = Console.ReadLine();
                        if (Double.TryParse(inputX, out double num) && Double.TryParse(inputY, out double num2))
                        {
                            Func<double, double, double> division = (x, y) => x / y;
                            Console.WriteLine($"La division es igual a: {division(num, num2)}");
                        }
                        else
                            Console.WriteLine($"Ingrese numeros validos.");
                        break;
                    }
                case "4":
                    {
                        
                        Console.WriteLine($"Ingresa el primer numero.");
                        var inputX = Console.ReadLine();
                        Console.WriteLine($"Ingresa el segundo numero.");
                        var inputY = Console.ReadLine();
                        if (Double.TryParse(inputX, out double num) && Double.TryParse(inputY, out double num2))
                        {
                            Func<double, double, double> multiplication = (x, y) => x * y;
                            Console.WriteLine($"La multiplicacion es igual a: {multiplication(num, num2)}");
                        }
                        else
                            Console.WriteLine($"Ingrese numeros validos.");
                        break;
                    }
                case "5":
                    {
                        
                        Console.WriteLine($"Ingresa un numero.");
                        var inputX = Console.ReadLine();
                        if (Double.TryParse(inputX, out double num))
                        {
                            Func<double, double, double> seno = (x, y) => Math.Sin(x * Math.PI / 180);
                            Console.WriteLine($"El seno es igual a: {seno(num, 0)}");
                        }
                        else
                            Console.WriteLine($"Ingrese un numero valido.");
                        break;
                    }
                case "6":
                    {
                        
                        Console.WriteLine($"Ingresa un numero.");
                        var inputX = Console.ReadLine();
                        if (Double.TryParse(inputX, out double num))
                        {
                            Func<double, double, double> coseno = (x, y) => Math.Cos(x * Math.PI / 180);
                            Console.WriteLine($"El coseno es igual a: {coseno(num, 0)}");
                        }
                        else
                            Console.WriteLine($"Ingrese un numero valido.");
                        break;
                    }
                case "7":
                    {
                        //Exp(x): Exponencial de x (e elevado a x)
                        //E, el número "e", con un valor de 2.71828...
                        
                        Console.WriteLine($"Ingresa un numero.");
                        var inputX = Console.ReadLine();
                        if (Double.TryParse(inputX, out double num))
                        {
                            Func<double, double, double> exponencial = (x, y) => Math.Exp(x);
                            Console.WriteLine($"El exponencial es igual a: {exponencial(num, 0)}");
                        }
                        else
                            Console.WriteLine($"Ingrese un numero valido.");
                        break;
                    }
            }
        }
    }

    public class ActionCalculator
    {
        public static void Lambda(double x, double y)
        {
            Action<double, double> addition = (x, y) =>
            {
                Console.WriteLine(x + y);
            };
            addition(x, y);
        }
    }
}
