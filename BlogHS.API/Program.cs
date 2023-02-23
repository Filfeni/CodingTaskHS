using BlogHS.API.Extensions;
using BlogHS.API.Validators;
using BlogHS.Domain.Models.Entry;
using BlogHS.Infrastructure.Data;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add memory cache service.
builder.Services.AddMemoryCache();

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<EFContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddUnitOfWork();
builder.Services.AddRepositories();
builder.Services.AddBusinessServices();
builder.Services.AddAutoMapper(typeof(BlogHS.Domain.AutoMapperProfile).Assembly);
builder.Services.AddFluentValidation(conf =>
{
    conf.RegisterValidatorsFromAssembly(typeof(Program).Assembly);
    conf.AutomaticValidationEnabled = false;
});
builder.Services.AddScoped<IValidator<EntryDTO>, EntryDTOValidator>();
builder.Services.AddScoped<IValidator<BaseEntryDTO>, BaseEntryDTOValidator>();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowOrigin",
        builder => builder.WithOrigins("*")
                          .AllowAnyHeader()
                          .AllowAnyMethod());
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowOrigin");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
