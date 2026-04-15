using LibrarySystem.Application.DTOs;
using LibrarySystem.Application.Interfaces;
using LibrarySystem.Domain.Entities;

namespace LibrarySystem.Application.Services;

public class BookService
{
    private readonly IBookRepository _bookRepository;

    public BookService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public async Task<List<Book>> GetAllBooksAsync()
    {
        return await _bookRepository.GetAllAsync();
    }

    public async Task AddBookAsync(CreateBookDto dto)
    {
        var book = new Book
        {
            Id = Guid.NewGuid(),
            Title = dto.Title,
            Author = dto.Author,
            IsBorrowed = false
        };

        await _bookRepository.AddAsync(book);
    }
}