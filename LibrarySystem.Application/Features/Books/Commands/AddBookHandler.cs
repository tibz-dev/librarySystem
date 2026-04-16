using AutoMapper;
using LibrarySystem.Application.Interfaces;
using LibrarySystem.Domain.Entities;
using MediatR;

namespace LibrarySystem.Application.Features.Books.Commands
{
    public class AddBookHandler : IRequestHandler<AddBookCommand, Unit>
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
}
