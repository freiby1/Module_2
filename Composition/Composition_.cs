using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    class Author
    {
        public string Name { get; set; }
        public int BirthYear { get; set; }

        public Author(string name, int birthYear)
        {
            Name = name;
            BirthYear = birthYear;
        }

        public override string ToString()
        {
            return $"Автор: {Name}, Год рождения: {BirthYear}";
        }
    }

    class Book
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public Author Author { get; set; }

        public Book(string title, int year, Author author)
        {
            Title = title;
            Year = year;
            Author = author;
        }

        public override string ToString()
        {
            return $"Название книги: {Title}, Год выпуска: {Year}\n{Author}";
        }
    }

    class Composition_
    {
        static void Main(string[] args)
        {
            List<Author> authors = new List<Author>();
            List<Book> books = new List<Book>();

            while (true)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Добавить автора");
                Console.WriteLine("2. Добавить книгу");
                Console.WriteLine("3. Вывести информацию");
                Console.WriteLine("4. Выход");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Имя автора: ");
                        string name = Console.ReadLine();

                        Console.Write("Год рождения: ");
                        if (int.TryParse(Console.ReadLine(), out int birthYear))
                        {
                            Author author = new Author(name, birthYear);
                            authors.Add(author);
                            Console.WriteLine("Автор добавлен.");
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод года рождения. Попробуйте еще раз.");
                        }
                        break;

                    case 2:
                        Console.Write("Название книги: ");
                        string title = Console.ReadLine();

                        Console.Write("Год выпуска: ");
                        if (int.TryParse(Console.ReadLine(), out int year))
                        {
                            Console.Write("Имя автора: ");
                            string authorName = Console.ReadLine();
                            Author author = authors.Find(a => a.Name == authorName);
                            if (author == null)
                            {
                                Console.WriteLine("Автор с таким именем не найден.");
                            }
                            else
                            {
                                Book book = new Book(title, year, author);
                                books.Add(book);
                                Console.WriteLine("Книга добавлена.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод года выпуска. Попробуйте еще раз.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("\nИнформация об авторах:");
                        foreach (var author in authors)
                        {
                            Console.WriteLine(author);
                        }

                        Console.WriteLine("\nИнформация о книгах:");
                        foreach (var book in books)
                        {
                            Console.WriteLine(book);
                        }
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Некорректный выбор. Попробуйте еще раз.");
                        break;
                }
            }
        }
    }
}
