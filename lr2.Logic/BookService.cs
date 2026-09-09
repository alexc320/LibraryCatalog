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
    }
}
