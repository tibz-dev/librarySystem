using LibrarySystem.Application.Interfaces;
using LibrarySystem.Domain.Entities;
using System.Linq;

namespace LibrarySystem.Infrastructure.Repositories;

public class BookRepository : IBookRepository
{
    private static readonly List<Book> Books = new();

    public Task<List<Book>> GetAllAsync()
    {
        return Task.FromResult(Books);
    }

    public Task AddAsync(Book book)
    {
        Books.Add(book);
        return Task.CompletedTask;
    }

    public Task BorrowBookAsync(Guid id)
    {
        var book = Books.FirstOrDefault(b => b.Id == id);

        if (book == null)
            throw new Exception("Book not found");

        if (book.IsBorrowed)
            throw new Exception("Book is already borrowed");

        book.IsBorrowed = true;

        return Task.CompletedTask;
    }
}