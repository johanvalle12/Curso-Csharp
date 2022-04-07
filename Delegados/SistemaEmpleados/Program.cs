using System;
using System.Collections.Generic;

namespace SistemaEmpleados
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> empleados = new List<Empleado>()
            {
                new Empleado("empleado1", "password1", DateTime.Now),
                new Empleado("empleado2", "password2", DateTime.Now.AddDays(-365)),
                new Empleado("empleado3", "password3", DateTime.Now),
                new Empleado("empleado4", "password4", DateTime.Now.AddDays(-365)),
                new Empleado("empleado5", "password5", DateTime.Now),
                new Empleado("empleado6", "password6", DateTime.Now),
                new Empleado("empleado7", "password7", DateTime.Now.AddDays(-365)),
                new Empleado("empleado8", "password8", DateTime.Now),
                new Empleado("empleado9", "password9", DateTime.Now.AddDays(-365)),
                new Empleado("empleado10", "password10", DateTime.Now)
            };

            List<Supervisor> supervisores = new List<Supervisor>()
            {
                new Supervisor("supervisor1", "password1", DateTime.Now),
                new Supervisor("supervisor1", "password2", DateTime.Now.AddDays(-365)
            };

            Console.WriteLine("Ingrese su usuario:");
            string Username = Console.ReadLine();
            Console.WriteLine("Ingrese su contraseña:");
            string Password = Console.ReadLine();
            bool isEmpleado = false;
            bool isSupervisor = false;
            foreach(var empleado in empleados)
            {
                if (empleado.VerificarCredenciales(Username, Password))
                    isEmpleado = true;
            }
            foreach (var supervisor in supervisores)
            {
                if (supervisor.VerificarCredenciales(Username, Password))
                    isSupervisor = true;
            }

            if (isEmpleado)
                MostrarMenuEmpleados();
            else
                MostrarMenuSupervisores();

        }
        public static void MostrarMenuEmpleados()
        {
            Console.WriteLine("Bienvenido");
        }

        public static void MostrarMenuSupervisores()
        {

        }
    }
}
