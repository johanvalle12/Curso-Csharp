using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicatesWithClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Search by Birthday:");
            var input = Console.ReadLine();
            Searcher(input);


        }
        static void Searcher(string input)
        {
            User.Input = input;

            Predicate<Person> predicateByName = new Predicate<Person>(Person.Exists);

            Predicate<Person> predicateByAge = new Predicate<Person>(Person.getByAge);

            Predicate<Person> predicateByBirthday = new Predicate<Person>(Person.getByBirthday);

            List<Person> people = new List<Person>()
            {
                new Person() {Name = "Johan", Age = 24, Birthday = new DateTime(1998,3,12)},
                new Person() {Name = "Rene", Age = 31, Birthday = new DateTime(1991,4,1)},
                new Person() {Name = "Alejandra", Age = 27, Birthday = new DateTime(1995,1,18)}
            };

            if (people.Exists(predicateByName))
                Console.WriteLine("The user exists.");
            else
            {
                var result = people.FindAll(predicateByBirthday);
                if (result.Any())
                {
                    Console.WriteLine("We found these names.");
                    foreach (var item in result)
                    {
                        Console.WriteLine(item.Name);
                    }
                }
                else
                    Console.WriteLine("We did not found any name");
            }
        }
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public DateTime Birthday { get; set; }

            public static bool Exists(Person person)
            {
                return person.Name.Equals(User.Input);
            }

            public static bool getByAge(Person person)
            {
                var isNumber = Int32.TryParse(User.Input, out int age);

                if (isNumber)
                    return person.Age.Equals(age);
                else
                    return false;
            }
            public static bool getByBirthday(Person person)
            {
                var isDate = DateTime.TryParse(User.Input, out DateTime birthday);
                if (isDate)
                {
                    //Console.WriteLine($"Birthday input: {birthday} ---- Person's Birthday: {person.Birthday}");
                    return (person.Birthday.Year == birthday.Year && person.Birthday.Month == birthday.Month) ? true : false;
                }
                else
                    return false;

            }
        }

        class User
        {
            public static string Input { get; set; }
        }
    }
}
