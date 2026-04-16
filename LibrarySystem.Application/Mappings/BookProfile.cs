using AutoMapper;
using LibrarySystem.Application.DTOs;
using LibrarySystem.Domain.Entities;

namespace LibrarySystem.Application.Mappings;

public class BookProfile : Profile
{
    public BookProfile()
    {
        CreateMap<CreateBookDto, Book>();
        CreateMap<Book, BookResponseDto>();
    }
}