using System;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //DomainValidation("https://www.something.com");
            //phoneNumberValidation("+52 (646) 137 67 75");
            passwordValidation("ej3mPlo!#");
        }

        static void DomainValidation(string domain)
        {
            Regex regex = new Regex(@"^https?://(www.)?([\w]+)((\.[A-Za-z]{2,3})+)$");
            Console.WriteLine(regex.IsMatch(domain));
        }

        static void phoneNumberValidation(string phoneNumber)
        {
            Regex regex = new Regex(@"^\+[\d]{2}\s\([\d]{3}\)\s[\d]{3}\s[\d]{2}\s[\d]{2}$");
            Console.WriteLine(regex.IsMatch(phoneNumber));
        }
        static void passwordValidation(string password)
        {
            // Debe contener minimo 8 caracteres
            // Al menos una mayuscula
            // Al menos una minuscula
            // Al menos un numero
            // Al menos un caracter especial * ? ! @
            // No debe tener espacios
            Regex regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\@\!\?\*])\S{8,}$");
            Console.WriteLine(regex.IsMatch(password));
        }
    }
}
