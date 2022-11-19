using Microsoft.EntityFrameworkCore;
using RepositoryPatternHW.DataLayer.Abstracts;
using RepositoryPatternHW.DataLayer.Concretes;
using RepositoryPatternHW.DataLayer.Context;
using RepositoryPatternHW.ServiceLayer.Abstracts;
using RepositoryPatternHW.ServiceLayer.Concretes;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddTransient<IAnimationService, AnimationService>();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
