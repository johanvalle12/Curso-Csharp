using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmpleados
{
    class Empleado : Usuario
    {
        public int HorasLaboradas { get; set; }
        public string Descripcion { get; set; }
        public bool HorasValidadas { get; set; }
        public Empleado(string username, string password, DateTime date) : base(username, password, date, false)
        {

        }

        public void RegistrarHoras(int horas, string descripcion)
        {
            HorasLaboradas = horas;
            Descripcion = descripcion;
            HorasValidadas = false;
        }

        public static bool Exists(Empleado empleado)
        {
            return empleado.Username.Equals(Supervisor.Input);
        }

        public static bool getById(Empleado empleado)
        {
            var isNumber = Int32.TryParse(Supervisor.Input, out int id);

            if (isNumber)
                return empleado.Id.Equals(id);
            else
                return false;
        }
    }
}
