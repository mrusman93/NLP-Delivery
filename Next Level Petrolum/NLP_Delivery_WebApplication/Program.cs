using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NLP.Dal;
using NLP.Domain.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Adding Authentication
builder.Services.AddAuthentication()
    .AddBearerToken(IdentityConstants.BearerScheme);

//Adding Authorization
builder.Services.AddAuthorizationBuilder();

builder.Services.AddIdentityCore<Users>()
    .AddEntityFrameworkStores<AppDataContext>()
    .AddApiEndpoints();

builder.Services.AddDbContext<AppDataContext>(options => options.UseSqlServer(
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

app.MapIdentityApi<Users>();

app.UseAuthorization();

app.MapControllers();

app.Run();
