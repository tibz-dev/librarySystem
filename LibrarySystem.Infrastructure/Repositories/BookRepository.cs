using LibrarySystem.Application.Interfaces;
using LibrarySystem.Domain.Entities;

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
}