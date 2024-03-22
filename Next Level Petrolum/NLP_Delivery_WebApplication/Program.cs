using Microsoft.EntityFrameworkCore;
using NLP.Dal;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Connection String
//var cs = builder.Configuration.GetConnectionString("Default");

//DBContext 
//builder.Services.AddDbContext<DataContext>(options => { options.UseSqlServer("cs"); });


builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("Default")));

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddControllers(options => options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline (Middleware).

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
