using Delegate_Hometask.Models;
using Delegate_Hometask.Services;
using Delegate_Hometask.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Hometask.Controllers
{
    internal class PersonController
    {
        private readonly IPersonService _personService;

        public PersonController()
        {
            _personService = new PersonService();
        }


        public void GetAll()
        {
            foreach (var person in _personService.GetAll())
            {
                Console.WriteLine(person.Name + "-" + person.Surname + "-" + person.Address + "-" + person.Salary);
            }
        }


        public void SearchBySalary()
        {
            var result = _personService.SearchBySalary(m => m.Salary > 1000);
            foreach (var person in result)
            {
                Console.WriteLine(person.Name + "-" + person.Surname + "-" + person.Address + "-" + person.Salary);
            }
        }
    }
}
