using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2.Logic
{
    public class BookService
    {
        private readonly IBookRepository _repository;

        public BookService(IBookRepository repository)
        {
            _repository = repository;
        }

        public List<Book> GetImportant()
        {
            return _repository.GetAll()
                .Where(b => b.Year < 2000)
                .ToList();
        }

        public void AddBook(string title, int year)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                return;
            }

            int nextId = _repository.GetAll().Count() + 1;

            _repository.Add(new Book
            {
                Id = nextId,
                Title = title,
                Year = year
            });
        }

        public Book? GetOldestBook()
        {
            var books = _repository.GetAll();

            if (books.Count == 0)
            {
                return null;
            }

            return books.OrderBy(b => b.Year).FirstOrDefault();
        }
    }
}
