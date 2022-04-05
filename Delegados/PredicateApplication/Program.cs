using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($" Select an option:\n 1.- Search by Id.\n 2.- Search by First Name.\n 3.- Search by Last Name.\n 4.- Search by Birthday.\n 5.- Search by Hired Date.\n 6.- Search by Active.");
            var option = Console.ReadLine();
            Console.WriteLine($"Input: ");
            var input = Console.ReadLine();
            Searcher(option, input);
        }

        static void Searcher(string option, string input)
        {
            User.Input = input;

            Predicate<Employee> predicateById = new Predicate<Employee>(Employee.getById);
            Predicate<Employee> predicateByFirstName = new Predicate<Employee>(Employee.getByFirstName);
            Predicate<Employee> predicateByLastName = new Predicate<Employee>(Employee.getByLastName);
            Predicate<Employee> predicateByBirthday = new Predicate<Employee>(Employee.getByBirthday);
            Predicate<Employee> predicateByHiredDate = new Predicate<Employee>(Employee.getByHiredDate);
            Predicate<Employee> predicateByActive = new Predicate<Employee>(Employee.getByActive);

            List<Employee> people = new List<Employee>()
            {
                new Employee() {Id = 1, FirstName = "Johan", LastName = "Valle", Birthday = new DateTime(1998,3,12), HiredDate = new DateTime(2022,4,1), Active = true },
                new Employee() {Id = 2, FirstName = "Juan", LastName = "Perez", Birthday = new DateTime(1995,4,21), HiredDate = new DateTime(2022,1,14), Active = true },
                new Employee() {Id = 3, FirstName = "Iridian", LastName = "Castrejon", Birthday = new DateTime(1999,1,07), HiredDate = new DateTime(2022,4,1), Active = true },
                new Employee() {Id = 4, FirstName = "Rocio", LastName = "Flores", Birthday = new DateTime(1998,4,24), HiredDate = new DateTime(2021,12,10), Active = false },
                new Employee() {Id = 5, FirstName = "Manuel", LastName = "Martinez", Birthday = new DateTime(1996,5,21), HiredDate = new DateTime(2022,1,10), Active = false },
                new Employee() {Id = 6, FirstName = "Eduardo", LastName = "Prieto", Birthday = new DateTime(1998,3,14), HiredDate = new DateTime(2022,2,18), Active = true },
                new Employee() {Id = 7, FirstName = "Fabian", LastName = "Gandarilla", Birthday = new DateTime(1997,1,30), HiredDate = new DateTime(2022,3,12), Active = true },
                new Employee() {Id = 8, FirstName = "Luis", LastName = "Morales", Birthday = new DateTime(1997,2,03), HiredDate = new DateTime(2022,3,14), Active = true },
                new Employee() {Id = 9, FirstName = "Manuel", LastName = "Vargas", Birthday = new DateTime(1997,9,30), HiredDate = new DateTime(2021,6,10), Active = false },
                new Employee() {Id = 10, FirstName = "Mariel", LastName = "Juarez", Birthday = new DateTime(1998,5,15), HiredDate = new DateTime(2021,7,10), Active = true },
                new Employee() {Id = 11, FirstName = "Enrique", LastName = "Diaz", Birthday = new DateTime(1998,8,18), HiredDate = new DateTime(2021,8,19), Active = true },
                new Employee() {Id = 12, FirstName = "Sandra", LastName = "Betancourt", Birthday = new DateTime(1998,8,28), HiredDate = new DateTime(2021,9,20), Active = false },
                new Employee() {Id = 13, FirstName = "Yuritzi", LastName = "Morales", Birthday = new DateTime(1998,7,12), HiredDate = new DateTime(2021,10,26), Active = true },
                new Employee() {Id = 14, FirstName = "Angelica", LastName = "Salgado", Birthday = new DateTime(1998,4,11), HiredDate = new DateTime(2021,11,24), Active = true },
                new Employee() {Id = 15, FirstName = "Ana", LastName = "Tamayo", Birthday = new DateTime(1997,9,30), HiredDate = new DateTime(2021,12,05), Active = false },
                new Employee() {Id = 16, FirstName = "Ashley", LastName = "Cardenas", Birthday = new DateTime(1999,7,10), HiredDate = new DateTime(2021,6,26), Active = true },
                new Employee() {Id = 17, FirstName = "Ariana", LastName = "Obeso", Birthday = new DateTime(1996,10,03), HiredDate = new DateTime(2022,7,29), Active = false },
                new Employee() {Id = 18, FirstName = "Osvaldo", LastName = "Cardenas", Birthday = new DateTime(1998,3,12), HiredDate = new DateTime(2022,8,31), Active = true },
                new Employee() {Id = 19, FirstName = "Roberto", LastName = "Garcia", Birthday = new DateTime(1996,11,22), HiredDate = new DateTime(2022,9,01), Active = false },
                new Employee() {Id = 20, FirstName = "Martin", LastName = "Valle", Birthday = new DateTime(1965,2,13), HiredDate = new DateTime(2022,10,18), Active = true },
            };

            switch (option)
            {
                // Filtrado por Id
                case "1":
                {
                    var result = people.FindAll(predicateById);
                    if (result.Any())
                    {
                        Console.WriteLine("We found this employee.");
                        foreach (var item in result)
                        {
                            var active = (item.Active) ? "Yes" : "No";
                            Console.WriteLine($"ID: {item.Id} -- Name: {item.FirstName} {item.LastName} -- Birthday: {item.Birthday} -- HiredDate: {item.HiredDate} -- Active: {active}");
                        }
                    }
                    else
                        Console.WriteLine($"We didn't find an employee with Id {input}");
                    break;
                }
                // Filtrado por FirstName
                case "2":
                {
                    var result = people.FindAll(predicateByFirstName);
                    if (result.Any())
                    {
                        Console.WriteLine("We found these employees.");
                        foreach (var item in result)
                        {
                            var active = (item.Active) ? "Yes" : "No";
                            Console.WriteLine($"ID: {item.Id} -- Name: {item.FirstName} {item.LastName} -- Birthday: {item.Birthday} -- HiredDate: {item.HiredDate} -- Active: {active}");
                        }
                    }
                    else
                        Console.WriteLine($"We didn't find any employee with First Name {input}");
                    break;
                }
                // Filtrado por LastName
                case "3":
                {
                    var result = people.FindAll(predicateByLastName);
                    if (result.Any())
                    {
                        Console.WriteLine("We found these employees.");
                        foreach (var item in result)
                        {
                            var active = (item.Active) ? "Yes" : "No";
                            Console.WriteLine($"ID: {item.Id} -- Name: {item.FirstName} {item.LastName} -- Birthday: {item.Birthday} -- HiredDate: {item.HiredDate} -- Active: {active}");
                        }
                    }
                    else
                        Console.WriteLine($"We didn't find any employee with Last Name {input}");
                    break;
                }
                // Filtrado por Birthday
                case "4":
                {
                    var result = people.FindAll(predicateByBirthday);
                    if (result.Any())
                    {
                        Console.WriteLine("We found these employees.");
                        foreach (var item in result)
                        {
                            var active = (item.Active) ? "Yes" : "No";
                            Console.WriteLine($"ID: {item.Id} -- Name: {item.FirstName} {item.LastName} -- Birthday: {item.Birthday} -- HiredDate: {item.HiredDate} -- Active: {active}");
                        }
                    }
                    else
                        Console.WriteLine($"We didn't find any employee with Birthday {input}");
                    break;
                }
                // Filtrado por HiredDate
                case "5":
                {
                    var result = people.FindAll(predicateByHiredDate);
                    if (result.Any())
                    {
                        Console.WriteLine("We found these employees.");
                        foreach (var item in result)
                        {
                            var active = (item.Active) ? "Yes" : "No";
                            Console.WriteLine($"ID: {item.Id} -- Name: {item.FirstName} {item.LastName} -- Birthday: {item.Birthday} -- HiredDate: {item.HiredDate} -- Active: {active}");
                        }
                    }
                    else
                        Console.WriteLine($"We didn't find any employee with Hired Date {input}");
                    break;
                }
                // Filtrado por Active
                case "6":
                {
                    var result = people.FindAll(predicateByActive);
                    if (result.Any())
                    {
                        Console.WriteLine("We found these employees.");
                        foreach (var item in result)
                        {
                            var active = (item.Active) ? "Yes" : "No";
                            Console.WriteLine($"ID: {item.Id} -- Name: {item.FirstName} {item.LastName} -- Birthday: {item.Birthday} -- HiredDate: {item.HiredDate} -- Active: {active}");
                        }
                    }
                    else
                        Console.WriteLine($"We didn't find any employee with Active {input}");
                    break;
                }
            }
        }

        class Employee
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime Birthday { get; set; }
            public DateTime HiredDate { get; set; }
            public bool Active { get; set; }

            public static bool Exists(Employee employee)
            {
                return employee.FirstName.Equals(User.Input);
            }
            public static bool getById(Employee employee)
            {
                var isNumber = Int32.TryParse(User.Input, out int id);

                if (isNumber)
                    return employee.Id.Equals(id);
                else
                    return false;
            }

            public static bool getByFirstName(Employee employee)
            {
                return employee.FirstName.Equals(User.Input);
            }

            public static bool getByLastName(Employee employee)
            {
                return employee.LastName.Equals(User.Input);
            }

            public static bool getByBirthday(Employee employee)
            {
                
                if(User.Input.Contains('-'))
                {
                    var fechas = User.Input.Split('-').ToList();
                    var isDate1 = DateTime.TryParse(fechas[0], out DateTime birthdayStart);
                    var isDate2 = DateTime.TryParse(fechas[1], out DateTime birthdayEnd);
                    if (isDate1 && isDate2)
                        return (employee.Birthday >= birthdayStart && employee.Birthday <= birthdayEnd) ? true : false;
                    else
                        return false;
                }
                else
                {
                    var isDate = DateTime.TryParse(User.Input, out DateTime birthday);
                    if (isDate)
                    {
                        //Console.WriteLine($"Birthday input: {birthday} ---- Person's Birthday: {person.Birthday}");
                        return (employee.Birthday.Year == birthday.Year && employee.Birthday.Month == birthday.Month) ? true : false;
                    }
                    else
                        return false;
                }
            }
            public static bool getByHiredDate(Employee employee)
            {
                if (User.Input.Contains('-'))
                {
                    var fechas = User.Input.Split('-').ToList();
                    var isDate1 = DateTime.TryParse(fechas[0], out DateTime hiredDateStart);
                    var isDate2 = DateTime.TryParse(fechas[1], out DateTime hiredDateEnd);
                    if (isDate1 && isDate2)
                        return (employee.HiredDate >= hiredDateStart && employee.HiredDate <= hiredDateEnd) ? true : false;
                    else
                        return false;
                }
                else
                {
                    var isDate = DateTime.TryParse(User.Input, out DateTime hiredDate);
                    if (isDate)
                    {
                        //Console.WriteLine($"Birthday input: {birthday} ---- Person's Birthday: {person.Birthday}");
                        return (employee.HiredDate.Year == hiredDate.Year && employee.HiredDate.Month == hiredDate.Month) ? true : false;
                    }
                    else
                        return false;
                }
            }

            public static bool getByActive(Employee employee)
            {
                var active = (User.Input == "Yes") ? true : false;
                return employee.Active.Equals(active);
            }
        }
        class User
        {
            public static string Input { get; set; }
        }
    }
}
