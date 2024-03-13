using Delegate_Hometask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Hometask.Services.Interfaces
{
    internal interface IPersonService
    {
        List<Person> GetAll();
        List<Person> SearchBySalary(Predicate<Person> num);


    }
}
