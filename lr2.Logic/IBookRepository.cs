using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2.Logic
{
    public interface IBookRepository
    {
        List<Book> GetAll();
        void Add(Book book);
    }
}
