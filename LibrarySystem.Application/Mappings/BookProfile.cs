using AutoMapper;
using LibrarySystem.Domain.Entities;
using LibrarySystem.Application.DTOs;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LibrarySystem.Application.Mappings;

public class BookProfile : Profile
{
    public BookProfile()
    {
        CreateMap<Book, BookResponseDto>().ForMember(dest => dest.Status,opt => opt.MapFrom(src => src.IsBorrowed ? "Borrowed" : "Available"));
    }
}