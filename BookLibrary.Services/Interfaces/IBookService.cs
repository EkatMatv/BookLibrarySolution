using BookLibrary.Core.Models;

namespace BookLibrary.Services.Interfaces
{
    public interface IBookService
    {
        IEnumerable<Book> GetAllBooks();
        Book? GetBookById(int id);
        IEnumerable<Book> GetBooksByGenre(string genre);
        IEnumerable<Book> GetBooksByAuthor(string author);
        IEnumerable<Book> GetBooksByYear(int year);
        void AddBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(int id);
    }
}