using System;
using System.Text;
using lr2.Logic;

var service = new BookService();

Console.WriteLine("Отобранные записи");

foreach (var book in service.GetImportant())
{
    Console.WriteLine($"{book.Id}: {book.Title}");
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