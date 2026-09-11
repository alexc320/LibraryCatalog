using System;
using System.Text;
using lr2.Data;
using lr2.Logic;

string jsonPath = Path.Combine(AppContext.BaseDirectory, "books.json");
string xmlPath = Path.Combine(AppContext.BaseDirectory, "books.xml");

string kind = args.Length > 0 ? args[0] : "json";

IBookRepository repository;
switch (kind)
{
    case "xml":
        repository = new XmlBookRepository(xmlPath);
        break;
    case "memory":
        repository = new BookRepository();
        break;
    default:
        repository = new JsonBookRepository(jsonPath);
        break;
}

Console.WriteLine($"Хранилище: {kind}");

var service = new BookService(repository);

Console.Write("Название новой книги: ");
string title = Console.ReadLine() ?? "";

int year;
while (true)
{
    Console.Write("Год издания: ");
    string? input = Console.ReadLine();
    if (int.TryParse(input, out year) && year > 0)
    {
        break;
    }
    Console.WriteLine("Введите корректную дату издания");
}

service.AddBook(title, year);
Console.WriteLine("Отобранные записи:");
foreach (var book in service.GetImportant())
{
    Console.WriteLine($"{book.Id}: {book.Title}");
}

var oldestBook = service.GetOldestBook();
if (oldestBook != null)
{
    Console.WriteLine($"Самая старая книга: {oldestBook.Title} ({oldestBook.Year} год)");
}
else
{
    Console.WriteLine("Книги в каталоге отсутствуют");
}


//namespace LibraryCatalog
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = Encoding.UTF8;

//            Console.WriteLine("Проект: LibraryCatalog");
//            Console.WriteLine("Выполнил: Крутов Алексей Алексеевич");
//            Console.WriteLine();

//            Console.WriteLine("=== КАТАЛОГ КНИГ БИБЛИОТЕКИ ===");
//            Console.WriteLine();

//            Console.WriteLine("1. Война и мир");
//            Console.WriteLine("   Автор: Л.Н. Толстой");
//            Console.WriteLine("   Год: 1869");
//            Console.WriteLine();

//            Console.WriteLine("2. Преступление и наказание");
//            Console.WriteLine("   Автор: Ф.М. Достоевский");
//            Console.WriteLine("   Год: 1866");
//            Console.WriteLine();

//            Console.WriteLine("3. Мастер и Маргарита");
//            Console.WriteLine("   Автор: М.А. Булгаков");
//            Console.WriteLine("   Год: 1967");
//            Console.WriteLine();

//            Console.WriteLine("4. Евгений Онегин");
//            Console.WriteLine("   Автор: А.С. Пушкин");
//            Console.WriteLine("   Год: 1833");
//            Console.WriteLine();

//            Console.WriteLine("===============================");

//            int totalBooks = 4;
//            Console.WriteLine($"Всего книг в каталоге: {totalBooks}");

//            Console.ReadKey(); 
//        }
//    }
//}