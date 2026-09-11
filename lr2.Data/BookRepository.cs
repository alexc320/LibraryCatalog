using lr2.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2.Data 
{

    public class BookRepository : IBookRepository
    {
        private readonly List<Book> _books = new()
        {
            new Book { Id = 1, Title = "Война и мир", Year = 1869 },
            new Book { Id = 2, Title = "Преступление и наказание", Year = 1866 },
            new Book { Id = 3, Title = "Мастер и Маргарита", Year = 2006 }
        };

        public List<Book> GetAll()
        {
            return _books;
        }

        public void Add(Book book)
        {
            _books.Add(book);
        }
    }
}
