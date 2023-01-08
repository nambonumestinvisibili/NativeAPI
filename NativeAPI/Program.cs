using Native.API;
using Native.API.Exceptions;
using Native.Services;
using Native.Domain;
using Native.Repositories;
using Native.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.ConfigureDbContext(builder.Configuration.GetConnectionString("NativeDbConntection")!);
builder.Services.ConfigureRepositoryManager();
builder.Services.ConfigureNativeServices();
builder.Services.ConfigureControllers();

builder.Services.AddAutoMapper(
    typeof(Native.Domain.Extensions),
    typeof(Native.Repositories.Extensions),
    typeof(Native.Service.Extensions),
    typeof(Native.API.Extensions));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.ConfigureExceptionHandler();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
