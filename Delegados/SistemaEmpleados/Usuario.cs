using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmpleados
{
    class Usuario
    {
        public int Id { get; set; }
        public string Username { get; set; }
        protected string Password { get; set; }
        public DateTime HiredDate { get; set; }
        protected bool isAdmin { get; set; }

        private static int IdSeed = 1;

        public Usuario(string username, string password, DateTime hiredDate, bool admin)
        {
            Id = IdSeed;
            IdSeed++;
            Username = username;
            Password = password;
            HiredDate = hiredDate;
            isAdmin = admin;
        }

        public bool VerificarCredenciales(string username, string password)
        {
            return (Username == username && Password == password) ? true : false;
        }

        public bool VerificarAniversario(DateTime date)
        {
            return (HiredDate.Month == date.Month && HiredDate.Day == date.Day && (date.Year - HiredDate.Year) > 0) ? true : false;
        }
    }
}
