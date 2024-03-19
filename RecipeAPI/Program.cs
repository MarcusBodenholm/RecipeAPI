using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using RecipeAPI.Repository.Context;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<RecipeDBContext>(
    options => options.UseSqlServer(@"Server=(localdb)\\mssqllocaldb;Database=RecipeDB;Trusted_Connection=True;")
    );

app.UseRouting();

app.UseEndpoints(endpoints => endpoints.MapControllers());
app.UseSwagger();
app.UseSwaggerUI();

app.Run();
