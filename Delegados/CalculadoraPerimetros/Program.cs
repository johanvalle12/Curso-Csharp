using System;

namespace CalculadoraPerimetros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($" Figura a calcular area y perimetro:\n 1.- Cuadrado.\n 2.- Rectangulo.\n 3.- Triangulo.\n 4.- Circulo.");
            var option = Console.ReadLine();
            GeometricCalculator.Operate(option);
            GeometricFunctionCalculator.FunctionOperate(option);
        }
    }

    public class GeometricCalculator
    {
        public delegate double Operator(double x, double y);

        public static void Operate(string option)
        {
            switch (option)
            {
                case "1":
                    {
                        Console.Clear();
                        Console.WriteLine($"Ingresa el valor de un lado.");
                        var inputX = Console.ReadLine();
                        if (Double.TryParse(inputX, out double num))
                        {
                            Operator cuadradoA = new Operator((x, y) => x * x);
                            Operator cuadradoP = new Operator((x, y) => x * 4);
                            Console.WriteLine($"El perimetro es igual a {cuadradoP(num, 0)} y el area es igual a {cuadradoA(num,0)} ");
                        }
                        else
                            Console.WriteLine($"Ingrese un numero valido.");
                        break;
                    }
                case "2":
                    {
                        Console.Clear();
                        Console.WriteLine($"Ingresa la base.");
                        var inputX = Console.ReadLine();
                        Console.WriteLine($"Ingresa la altura.");
                        var inputY = Console.ReadLine();
                        if (Double.TryParse(inputX, out double num) && Double.TryParse(inputY, out double num2))
                        {
                            Operator rectanguloP = new Operator((x, y) => x * 2 + y * 2);
                            Operator rectanguloA = new Operator((x, y) => x * y);
                            Console.WriteLine($"El perimetro es igual a {rectanguloP(num, num2)} y el area es igual a {rectanguloA(num, num2)} ");
                        }
                        else
                            Console.WriteLine($"Ingrese numeros validos.");
                        break;
                    }
                case "3":
                    {
                        Console.Clear();
                        Console.WriteLine($"Ingresa la base.");
                        var inputX = Console.ReadLine();
                        Console.WriteLine($"Ingresa la altura.");
                        var inputY = Console.ReadLine();
                        if (Double.TryParse(inputX, out double num) && Double.TryParse(inputY, out double num2))
                        {
                            Operator trianguloP = new Operator((x, y) => x * 3);
                            Operator trianguloA = new Operator((x, y) => x * y / 2);
                            Console.WriteLine($"El perimetro es igual a {trianguloP(num, num2)} y el area es igual a {trianguloA(num, num2)} ");
                        }
                        else
                            Console.WriteLine($"Ingrese numeros validos.");
                        break;
                    }
                case "4":
                    {
                        Console.Clear();
                        Console.WriteLine($"Ingresa el radio.");
                        var inputX = Console.ReadLine();
                        if (Double.TryParse(inputX, out double num))
                        {
                            Operator circuloP = new Operator((x, y) => 2 * Math.PI * x);
                            Operator circuloA = new Operator((x, y) => Math.PI * x * x);
                            Console.WriteLine($"El perimetro es igual a {circuloP(num, 0)} y el area es igual a {circuloA(num, 0)} ");
                        }
                        else
                            Console.WriteLine($"Ingrese numeros validos.");
                        break;
                    }
            }
        }
    }

    public class GeometricFunctionCalculator
    {
        public static void FunctionOperate(string option)
        {
            switch (option)
            {
                case "1":
                    {
                        Console.WriteLine($"Ingresa el valor de un lado.");
                        var inputX = Console.ReadLine();
                        if (Double.TryParse(inputX, out double num))
                        {
                            Func<double, double, double> cuadradoA = (x, y) => x * x;
                            Func<double, double, double> cuadradoP = (x, y) => x * 4;
                            Console.WriteLine($"El perimetro es igual a {cuadradoP(num, 0)} y el area es igual a {cuadradoA(num, 0)} ");
                        }
                        else
                            Console.WriteLine($"Ingrese un numero valido.");
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine($"Ingresa la base.");
                        var inputX = Console.ReadLine();
                        Console.WriteLine($"Ingresa la altura.");
                        var inputY = Console.ReadLine();
                        if (Double.TryParse(inputX, out double num) && Double.TryParse(inputY, out double num2))
                        {
                            Func<double, double, double> rectanguloA = (x, y) => x * y;
                            Func<double, double, double> rectanguloP = (x, y) => x * 2 + y * 2;
                            Console.WriteLine($"El perimetro es igual a {rectanguloP(num, num2)} y el area es igual a {rectanguloA(num, num2)} ");
                        }
                        else
                            Console.WriteLine($"Ingrese numeros validos.");
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine($"Ingresa la base.");
                        var inputX = Console.ReadLine();
                        Console.WriteLine($"Ingresa la altura.");
                        var inputY = Console.ReadLine();
                        if (Double.TryParse(inputX, out double num) && Double.TryParse(inputY, out double num2))
                        {
                            Func<double, double, double> trianguloP = (x, y) => x * 3;
                            Func<double, double, double> trianguloA = (x, y) => x * y / 2;
                            Console.WriteLine($"El perimetro es igual a {trianguloP(num, num2)} y el area es igual a {trianguloA(num, num2)} ");
                        }
                        else
                            Console.WriteLine($"Ingrese numeros validos.");
                        break;
                    }
                case "4":
                    {
                        Console.WriteLine($"Ingresa el radio.");
                        var inputX = Console.ReadLine();
                        if (Double.TryParse(inputX, out double num))
                        {
                            Func<double, double, double> circuloP = (x, y) => 2 * Math.PI * x;
                            Func<double, double, double> circuloA = (x, y) => Math.PI * x * x;
                            Console.WriteLine($"El perimetro es igual a {circuloP(num, 0)} y el area es igual a {circuloA(num, 0)} ");
                        }
                        else
                            Console.WriteLine($"Ingrese numeros validos.");
                        break;
                    }
            }
        }
    }
}
