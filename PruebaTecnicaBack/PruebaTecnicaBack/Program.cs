using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PruebaTecnicaBack.Models;
using PruebaTecnicaBack.Repository.Implementacion;
using PruebaTecnicaBack.Repository.Interfaz;
using PruebaTecnicaBack.Utilidades;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<PruebatecnicaContext>(opt =>
    opt.UseMySql(builder.Configuration.GetConnectionString("CadenaMySQL"),ServerVersion.Parse("8.0.34-mysql")));

builder.Services.AddScoped<IContractRepository, ContractRepository>();
builder.Services.AddAutoMapper(typeof(AutomapperProfile));

builder.Services.AddCors(opt =>
{
    opt.AddPolicy("AllowAll",
        b => b.AllowAnyHeader()
        .AllowAnyMethod()
        .AllowAnyOrigin());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();
