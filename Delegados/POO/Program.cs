using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //var polygon = new Polygon(20, 50);
            var square = new Square(20);
            var rectangle = new Rectangle(10, 20);
            var triangle = new Triangle(15, 20);
            

            Console.WriteLine(polygon.GetArea());
            Console.WriteLine($"Square area: {square.GetArea()}");
            Console.WriteLine($"Triangle area: {triangle.GetArea()}");
            Console.WriteLine($"Rectangle area: {rectangle.GetArea()}");

        }
    }

    // Modificadores de acceso
    // public cualquiera tiene acceso a ese recurso, ya sea un método o un atributo.
    // private unicamente se pueden acceder a estos metodos o atributos desde o dentro de la misma clase. No son hereditarios
    // protected Solamente la clase o clases que heredan de esta misma, pueden acceder a ellos.

    // Metodos
    // virtual La clase padre declara y define el método y las clases que hereden pueden hacer un override de dicho método o utilizarlo sin hacer override.
    // abstract Solamente se declara el método en la clase padre y las clases que heredan deben definir lo que hara dicho método mediante un override

    class Polygon
    {
        public decimal Base { get; set; }
        public decimal Height { get; set; }

        //public Polygon() { }

        //public Polygon(decimal heightDim, decimal baseDim)
        //{
        //    Base = baseDim;
        //    Height = heightDim;
        //}

    
        public virtual decimal GetArea()
        {
            return Base * Height;
        }
    }

    class Square : Polygon
    {
        public Square(decimal heightDim)
        {
            Base = heightDim;
            Height = heightDim;
        }
    }

    class Rectangle : Polygon
    {
        public Rectangle(decimal heightDim, decimal baseDim)
        {
            Base = baseDim;
            Height = heightDim;
        }
    }

    class Triangle : Polygon
    {
        public Triangle(decimal heightDim, decimal baseDim)
        {
            Base = baseDim;
            Height = heightDim;
        }

        public override decimal GetArea()
        {
            return Base * Height / 2m;
        }
    }
}
