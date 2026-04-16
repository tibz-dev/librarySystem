using Microsoft.AspNetCore.Mvc;
using LibrarySystem.Application.DTOs;
using LibrarySystem.Application.Services;
using LibrarySystem.Application.Features.Books.Commands;

using MediatR;

namespace LibrarySystem.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BooksController : ControllerBase
{
    private readonly BookService _bookService;
    private readonly IMediator _mediator;

    public BooksController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _mediator.Send(new GetBooksQuery());
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateBookDto dto)
    {
        await _mediator.Send(new AddBookCommand(dto));
        return Ok(new { message = "Book added successfully" });
    }

    [HttpPut("{id}/borrow")]
    public async Task<IActionResult> Borrow(Guid id)
    {
        try
        {
            await _bookService.BorrowBookAsync(id);
            return Ok(new { message = "Book borrowed successfully" });
        }
        catch (Exception ex)
        {
            return BadRequest(new { error = ex.Message });
        }
       
    }
}