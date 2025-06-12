using System;
using Microsoft.EntityFrameworkCore;
using ToDoList.Data;
using DotNetEnv;

DotNetEnv.Env.Load();

var builder = WebApplication.CreateBuilder(args);
var connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING");

// Kiểm tra xem chuỗi kết nối có tồn tại không
if (string.IsNullOrEmpty(connectionString))
{
    throw new InvalidOperationException("CONNECTION_STRING environment variable is not set.");
}

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddDbContext<ApplicationDBContext>(options =>
{
    options.UseNpgsql(connectionString); // Sử dụng trực tiếp connectionString
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();