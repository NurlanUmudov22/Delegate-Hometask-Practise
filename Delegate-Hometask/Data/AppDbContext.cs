using Delegate_Hometask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Hometask.Data
{
    internal class AppDbContext
    {
        public static List<Person> persons;

        static AppDbContext()
        {
            persons = new List<Person>
            {
                new Person
                {
                    Id = 1,
                    Name = "Samir",
                    Surname = "Talibov",
                    Address = "Yasamal",
                    Salary = 1200
                },
                new Person
                {
                    Id = 2,
                    Name = "Elnur",
                    Surname = "Agayev",
                    Address = "Ehmedli",
                    Salary = 2200
                },
                new Person
                {
                    Id = 3,
                    Name = "Nergiz",
                    Surname = "Talibzade",
                    Address = "Bine",
                    Salary = 900
                },
                new Person
                {
                    Id = 4,
                    Name = "Akif",
                    Surname = "Zeynalov",
                    Address = "Elmler",
                    Salary = 1800
                },
                new Person
                {
                    Id = 5,
                    Name = "Vuqar",
                    Surname = "Eyyubov",
                    Address = "Gunesli",
                    Salary = 800
                },
            };
        }
    }
}
