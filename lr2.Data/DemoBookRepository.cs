using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lr2.Logic;

namespace lr2.Data
{
    public class DemoBookRepository : IBookRepository
    {
        public List<Book> GetAll()
        {
            return new List<Book>
            {
                new Book {Id = 100, Title = "Демонстрационная запись", Year = 1991}
            };
        }
    }
}
