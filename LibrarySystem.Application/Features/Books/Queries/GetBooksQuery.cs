using MediatR;
using LibrarySystem.Application.DTOs;

public record GetBooksQuery() : IRequest<List<BookResponseDto>>;