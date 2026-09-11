using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Encodings.Web;
using lr2.Logic;

namespace lr2.Data
{
    public class JsonBookRepository : IBookRepository
    {
        private readonly string _path;

        private readonly JsonSerializerOptions _options = new()
        {
            WriteIndented = true,
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };

        public JsonBookRepository (string path)
        {
            _path = path;
        }

        public List<Book> GetAll()
        {
            if (!File.Exists(_path))
            {
                return new List<Book>();
            }

            string text = File.ReadAllText(_path);

            try
            {
                return JsonSerializer.Deserialize<List<Book>>(text) ?? new List<Book>();
            }
            catch (JsonException)
            {
                return new List<Book>();
            }
        }

        public void Add (Book book)
        {
            List<Book> books = GetAll();
            books.Add(book);

            string text = JsonSerializer.Serialize(books, _options);
            File.WriteAllText(_path, text);
        }
    }
}
