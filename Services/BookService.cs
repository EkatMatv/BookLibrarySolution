using BookLibraryApp.Models;

namespace BookLibraryApp.Services
{
    public class BookService
    {
        private readonly List<Book> _books;

        public BookService()
        {
            _books = new List<Book>
            {
                new Book { Id = 1, Title = "Преступление и наказание", Author = "Фёдор Достоевский", Genre = "Роман", Publisher = "Русский вестник", Year = 1866 },
                new Book { Id = 2, Title = "Мастер и Маргарита", Author = "Михаил Булгаков", Genre = "Роман", Publisher = "Москва", Year = 1967 },
                new Book { Id = 3, Title = "Война и мир", Author = "Лев Толстой", Genre = "Роман-эпопея", Publisher = "Русский вестник", Year = 1869 },
                new Book { Id = 4, Title = "1984", Author = "Джордж Оруэлл", Genre = "Антиутопия", Publisher = "Secker & Warburg", Year = 1949 },
                new Book { Id = 5, Title = "Гарри Поттер и философский камень", Author = "Джоан Роулинг", Genre = "Фэнтези", Publisher = "Bloomsbury", Year = 1997 }
            };
        }

        public List<Book> GetAllBooks() => _books;
    }
}
