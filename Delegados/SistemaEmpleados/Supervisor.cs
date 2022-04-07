using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmpleados
{
    class Supervisor : Usuario
    {
        public static string Input { get; set; }

        public Supervisor(string username, string password, DateTime date) : base(username, password, date, true)
        {

        }

        public void ValidarHoras(List<Empleado> empleados)
        {
            Predicate<Empleado> predicateById = new Predicate<Empleado>(Empleado.getById);

            Console.WriteLine("Selecciona el ID del empleado que desea validar horas:");
            ReporteEmpleados(empleados);
            Input = Console.ReadLine();
            var empleado = BuscarEmpleado(Input, "", empleados);
            var indice = empleados.FindIndex(predicateById);
            empleados.ElementAt(indice).HorasValidadas = true;
            Console.WriteLine($"Se han validado las horas del empleado {empleado.Username}");
            
        }

        public Empleado AgregarEmpleado(string username, string password, DateTime date)
        {
            return new Empleado(username, password, date);
        }

        public void EliminarEmpleado(string username, List<Empleado> empleados, string id = "0")
        {
            Empleado empleado;
            if(id == "0")
                empleado = BuscarEmpleado("0", username, empleados);
            else
                empleado = BuscarEmpleado(id, "", empleados);
            if(empleado != null)
            {
                empleados.Remove(empleado);
                Console.WriteLine($"Se ha eliminado el empleado {empleado.Username}");
            }
            else
                Console.WriteLine($"No se pudo eliminar el empleado");
        }

        private Empleado BuscarEmpleado(string id, string username, List<Empleado> empleados)
        {
            Predicate<Empleado> predicateByUsername = new Predicate<Empleado>(Empleado.Exists);

            Predicate<Empleado> predicateById = new Predicate<Empleado>(Empleado.getById);

            if(id == "0")
            {
                Input = username;
                return empleados.Find(predicateByUsername);
            }
            else
            {
                Input = id.ToString();
                return empleados.Find(predicateById);
            }
            
        }

        public void ReporteEmpleados(List<Empleado> empleados)
        {
            foreach(var empleado in empleados)
            {
                Console.WriteLine($"Id: {empleado.Id}\tUsername: {empleado.Username}\tFecha de Contratacion: {empleado.HiredDate}");
            }
        }

        public void ModificarEmpleado()
        {

        }
    }
}
