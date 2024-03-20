using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using RecipeAPI.Extensions;
using RecipeAPI.Repository.Context;
using RecipeAPI.Repository.Interfaces;
using RecipeAPI.Repository.Repos;
using RecipeAPI.Services.Interfaces;
using RecipeAPI.Services.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<ICategoryRepo, CategoryRepo>();
builder.Services.AddScoped<IRatingRepo, RatingRepo>();
builder.Services.AddScoped<IRecipeRepo, RecipeRepo>();
builder.Services.AddScoped<IUserRepo, UserRepo>();

builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IRatingService, RatingService>();
builder.Services.AddScoped<IRecipeService, RecipeService>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<RecipeDBContext>();

var app = builder.Build();
//Enables one to throw exceptions in services etc to return appropriate status codes. 
app.ConfigureExceptionHandler();
app.UseRouting();

app.UseEndpoints(endpoints => endpoints.MapControllers());
app.UseSwagger();
app.UseSwaggerUI();

app.Run();
