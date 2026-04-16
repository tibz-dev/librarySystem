using MediatR;
using LibrarySystem.Application.DTOs;

namespace LibrarySystem.Application.Features.Books.Commands;

public record AddBookCommand(CreateBookDto Dto) : IRequest<Unit>;