using MediatR;
using AutoMapper;
using LibrarySystem.Application.Interfaces;
using LibrarySystem.Application.DTOs;

public class GetBooksHandler : IRequestHandler<GetBooksQuery, List<BookResponseDto>>
{
    private readonly IBookRepository _repository;
    private readonly IMapper _mapper;

    public GetBooksHandler(IBookRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<BookResponseDto>> Handle(GetBooksQuery request, CancellationToken cancellationToken)
    {
        var books = await _repository.GetAllAsync();
        return _mapper.Map<List<BookResponseDto>>(books);
    }
}