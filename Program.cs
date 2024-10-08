using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using DioProjetoAPIEntityFramework.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<OrganizadorContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao")));

builder.Services.AddControllers().AddJsonOptions(options =>
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));

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

//se der o erro de caminho -> export PATH="$PATH:$HOME/.dotnet/tools"

/*Para instalar o pacote do sql -> wget -qO- https://packages.microsoft.com/keys/microsoft.asc | sudo apt-key add -
*sudo add-apt-repository "$(wget -qO- https://packages.microsoft.com/config/ubuntu/22.04/mssql-server-2022.list)"
*sudo apt-get update
*/

//Para instalar o sql -> sudo apt-get install -y mssql-server

//Para configurar o sql -> sudo /opt/mssql/bin/mssql-conf setup
