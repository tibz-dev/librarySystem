using LibrarySystem.Domain.Entities;

namespace LibrarySystem.Application.Interfaces;

public interface IBookRepository
{
    Task<List<Book>> GetAllAsync();
    Task AddAsync(Book book);
    Task BorrowBooksAsync(Guid id);
}