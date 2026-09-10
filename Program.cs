using Microsoft.EntityFrameworkCore;
using CodeFirst_EFCore.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

//Registrera DbContext
builder.Services.AddDbContext<NBADbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


