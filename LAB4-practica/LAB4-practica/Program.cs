using Application.Interfaces;
using Application.Services;
using Domain.Interface;
using Infrastructure;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlite(
builder.Configuration["ConnectionStrings:DBConnectionString"]));

builder.Services.AddScoped<ApplicationContext>();
builder.Services.AddScoped<IFunctionServices, FunctionServices>();
builder.Services.AddScoped<IFunctionRepository, FunctionRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
