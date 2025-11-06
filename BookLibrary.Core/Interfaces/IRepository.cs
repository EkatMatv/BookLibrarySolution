using BookLibrary.Core.Models;

namespace BookLibrary.Core.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T? GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }

    public interface IBookRepository : IRepository<Book>
    {
        IEnumerable<Book> GetByGenre(string genre);
        IEnumerable<Book> GetByAuthor(string author);
        IEnumerable<Book> GetByYear(int year);
    }
}