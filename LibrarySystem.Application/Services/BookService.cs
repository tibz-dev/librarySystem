using LibrarySystem.Application.DTOs;
using LibrarySystem.Application.Interfaces;
using LibrarySystem.Domain.Entities;
using AutoMapper;

namespace LibrarySystem.Application.Services;

public class BookService
{
    private readonly IBookRepository _bookRepository;
    private readonly IMapper _mapper;

    public BookService(IBookRepository bookRepository, IMapper mapper)
    {
        _bookRepository = bookRepository;
      
        _mapper = mapper;
    }

    public async Task<List<BookResponseDto>> GetAllBooksAsync()
    {
        var books = await _bookRepository.GetAllAsync();
        return _mapper.Map<List<BookResponseDto>>(books);
    }

    public async Task AddBookAsync(CreateBookDto dto)
    {
        var book = _mapper.Map<Book>(dto);

        book.Id = Guid.NewGuid();
        book.IsBorrowed = false;

        await _bookRepository.AddAsync(book);
    }

    public async Task BorrowBookAsync(Guid id)
    {
        await _bookRepository.BorrowBookAsync(id);
    }
}