using Delegate_Hometask.Data;
using Delegate_Hometask.Models;
using Delegate_Hometask.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Hometask.Services
{
    internal class PersonService : IPersonService
    {
        public List<Person> GetAll()
        {
            return AppDbContext.persons;
        }

        public List<Person> SearchBySalary(Predicate<Person> num)
        {
            List<Person> list = new();

            foreach (var  person in AppDbContext.persons)
            {
                if (num(person))
                {
                    list.Add(person);
                }
            }
            return list;
        }
    }
}
