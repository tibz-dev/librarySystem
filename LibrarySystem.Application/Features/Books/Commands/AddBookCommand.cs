using MediatR;
using LibrarySystem.Application.DTOs;

public record AddBookCommand(CreateBookDto Dto) : IRequest;