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
    internal class BookService : IBookService
    {
        public List<Book> GetAll()
        {
            return AppDbContextBook.books;
        }

        public int GetCount(Predicate<Book> text)
        {
            int count = 0;

            foreach (var book in AppDbContextBook.books)
            {
                if (text(book))
                {
                    count++;
                }
            }
            return count;
        }

        public List<Book> SearchByAuthor(Predicate<Book> text)
        {
            List<Book> list = new();

            foreach (var book in AppDbContextBook.books)
            {
                if (text(book))
                {
                    list.Add(book);
                }
            }
            return list;
        }
    }
}
