using Microsoft.AspNetCore.Mvc.RazorPages;
using BookLibrary.Core.Models;
using BookLibrary.Services.Interfaces;

namespace BookLibraryApp.Pages
{
    public class BooksModel : PageModel
    {
        private readonly IBookService _bookService;

        public BooksModel(IBookService bookService)
        {
            _bookService = bookService;
        }

        public List<Book> Books { get; set; } = new();
        public string? SearchGenre { get; set; }
        public string? SearchAuthor { get; set; }

        public void OnGet(string? genre, string? author)
        {
            SearchGenre = genre;
            SearchAuthor = author;

            if (!string.IsNullOrEmpty(genre))
            {
                Books = _bookService.GetBooksByGenre(genre).ToList();
            }
            else if (!string.IsNullOrEmpty(author))
            {
                Books = _bookService.GetBooksByAuthor(author).ToList();
            }
            else
            {
                Books = _bookService.GetAllBooks().ToList();
            }
        }
    }
}
