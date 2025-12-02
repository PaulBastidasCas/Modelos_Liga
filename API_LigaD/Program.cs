using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using API_LigaD.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<API_LigaDContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("API_LigaDContext") ?? throw new InvalidOperationException("Connection string 'API_LigaDContext' not found.")));

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
