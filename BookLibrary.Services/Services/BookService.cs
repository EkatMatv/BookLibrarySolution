using BookLibrary.Core.Models;
using BookLibrary.Core.Interfaces;
using BookLibrary.Services.Interfaces;

namespace BookLibrary.Services.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _bookRepository.GetAll();
        }

        public Book? GetBookById(int id)
        {
            return _bookRepository.GetById(id);
        }

        public IEnumerable<Book> GetBooksByGenre(string genre)
        {
            return _bookRepository.GetByGenre(genre);
        }

        public IEnumerable<Book> GetBooksByAuthor(string author)
        {
            return _bookRepository.GetByAuthor(author);
        }

        public IEnumerable<Book> GetBooksByYear(int year)
        {
            return _bookRepository.GetByYear(year);
        }

        public void AddBook(Book book)
        {
            _bookRepository.Add(book);
        }

        public void UpdateBook(Book book)
        {
            _bookRepository.Update(book);
        }

        public void DeleteBook(int id)
        {
            _bookRepository.Delete(id);
        }
    }
}