using MediatR;
using AutoMapper;
using LibrarySystem.Application.Interfaces;
using LibrarySystem.Domain.Entities;

public class AddBookHandler : IRequestHandler<AddBookCommand>
{
    private readonly IBookRepository _repository;
    private readonly IMapper _mapper;

    public AddBookHandler(IBookRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(AddBookCommand request, CancellationToken cancellationToken)
    {
        var book = _mapper.Map<Book>(request.Dto);
        book.Id = Guid.NewGuid();
        book.IsBorrowed = false;

        await _repository.AddAsync(book);

        return Unit.Value;
    }
}