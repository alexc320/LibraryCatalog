using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lr2.Data;

namespace lr2.Logic
{
    public class BookService
    {
        private readonly BookRepository _repository = new();

        public List<Book> GetImportant()
        {
            return _repository.GetAll()
                .Where(b => b.Year < 2000)
                .ToList();
        }
    }
}
