using Microsoft.AspNetCore.Mvc;
using LibrarySystem.Application.DTOs;
using LibrarySystem.Application.Services;

namespace LibrarySystem.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BooksController : ControllerBase
{
    private readonly BookService _bookService;

    public BooksController(BookService bookService)
    {
        _bookService = bookService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var books = await _bookService.GetAllBooksAsync();
        return Ok(books);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateBookDto dto)
    {
        await _bookService.AddBookAsync(dto);
        return Ok(new { message = "Book added successfully" });
    }

    [HttpPut("{id}/borrow")]
    public async Task<IActionResult> Borrow(Guid id)
    {
        await _bookService.BorrowBookAsync(id);
        return Ok(new { message = "Book borrowed successfully" });
    }
}