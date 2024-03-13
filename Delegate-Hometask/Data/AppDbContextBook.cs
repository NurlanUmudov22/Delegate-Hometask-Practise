using Delegate_Hometask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Hometask.Data
{
    internal class AppDbContextBook
    {
        public static List<Book> books;

        static AppDbContextBook()
        {
            books = new List<Book>
            {
                new Book
                {
                    Id = 1,
                    Author = "Nizami Gencevi",
                    BookName = "Xemse"
                },
                new Book
                {
                    Id = 2,
                    Author = "Xeqani",
                    BookName = "Bayatilar"
                },
                new Book
                {
                    Id = 3,
                    Author = "Nizami Gencevi",
                    BookName = "Yeddi Gozel"
                },
                new Book
                {
                    Id = 4,
                    Author = "Resul Rza",
                    BookName = "Seirler"
                },
            };
        }
    }
}
