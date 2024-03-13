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
    internal class BookController
    {
        private readonly IBookService _bookService;

        public BookController()
        {
            _bookService = new BookService();
        }


        public void GetAll()
        {
            foreach (var book in _bookService.GetAll())
            {
                Console.WriteLine(book.Author + "-" + book.BookName);
            }
        }


        public void SearchByAuthor()
        {
            var result = _bookService.SearchByAuthor(m => m.Author == "Nizami Gencevi");
            foreach (var book in result)
            {
                Console.WriteLine(book.Author + "-" + book.BookName);
            }
        }

        public void GetCount()
        {
            var response = _bookService.GetCount(m => m.Author == "Nizami Gencevi");
            Console.WriteLine(response);
        }
    }
}
