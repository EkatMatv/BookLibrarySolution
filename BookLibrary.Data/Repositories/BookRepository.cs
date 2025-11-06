using BookLibrary.Core.Models;
using BookLibrary.Core.Interfaces;

namespace BookLibrary.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly List<Book> _books;
        private int _nextId = 1;

        public BookRepository()
        {
            _books = new List<Book>
            {
                new Book { Id = _nextId++, Title = "Преступление и наказание", Author = "Фёдор Достоевский", Genre = "Роман", Publisher = "Русский вестник", Year = 1866 },
                new Book { Id = _nextId++, Title = "Мастер и Маргарита", Author = "Михаил Булгаков", Genre = "Роман", Publisher = "Москва", Year = 1967 },
                new Book { Id = _nextId++, Title = "Война и мир", Author = "Лев Толстой", Genre = "Роман-эпопея", Publisher = "Русский вестник", Year = 1869 },
                new Book { Id = _nextId++, Title = "1984", Author = "Джордж Оруэлл", Genre = "Антиутопия", Publisher = "Secker & Warburg", Year = 1949 },
                new Book { Id = _nextId++, Title = "Гарри Поттер и философский камень", Author = "Джоан Роулинг", Genre = "Фэнтези", Publisher = "Bloomsbury", Year = 1997 },
                new Book { Id = _nextId++, Title = "Три товарища", Author = "Эрих Мария Ремарк", Genre = "Роман", Publisher = "Kiepenheuer & Witsch", Year = 1936 },
                new Book { Id = _nextId++, Title = "Маленький принц", Author = "Антуан де Сент-Экзюпери", Genre = "Философская сказка", Publisher = "Reynal & Hitchcock", Year = 1943 }
            };
        }

        public IEnumerable<Book> GetAll()
        {
            return _books;
        }

        public Book? GetById(int id)
        {
            return _books.FirstOrDefault(b => b.Id == id);
        }

        public void Add(Book book)
        {
            book.Id = _nextId++;
            _books.Add(book);
        }

        public void Update(Book book)
        {
            var existingBook = GetById(book.Id);
            if (existingBook != null)
            {
                existingBook.Title = book.Title;
                existingBook.Author = book.Author;
                existingBook.Genre = book.Genre;
                existingBook.Publisher = book.Publisher;
                existingBook.Year = book.Year;
            }
        }

        public void Delete(int id)
        {
            var book = GetById(id);
            if (book != null)
            {
                _books.Remove(book);
            }
        }

        public IEnumerable<Book> GetByGenre(string genre)
        {
            return _books.Where(b => b.Genre.Equals(genre, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<Book> GetByAuthor(string author)
        {
            return _books.Where(b => b.Author.Contains(author, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<Book> GetByYear(int year)
        {
            return _books.Where(b => b.Year == year);
        }
    }
}