using LibrarySystem.Application.Interfaces;
using LibrarySystem.Application.Services;
using LibrarySystem.Infrastructure.Repositories;
using LibrarySystem.Application.Mappings; //registering automapper
using FluentValidation;
using FluentValidation.AspNetCore;
using AutoMapper;
using LibrarySystem.Application.Mappings;


using MediatR;
using LibrarySystem.Application.Features.Books.Commands;

using LibrarySystem.Application.Validators; //registering validator




var builder = WebApplication.CreateBuilder(args);


builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssemblyContaining<AddBookHandler>();
});//registering mediatr

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<BookService>();

builder.Services.AddAutoMapper(typeof(BookProfile)); //registering automapper

builder.Services.AddControllers();
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddValidatorsFromAssemblyContaining<CreateBookValidator>();//registering validator


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();