using Delegate_Hometask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Hometask.Services.Interfaces
{
    internal interface IBookService
    {
        List<Book> GetAll();

        List<Book> SearchByAuthor(Predicate<Book> text);

        int GetCount(Predicate<Book> text);

    }
}
