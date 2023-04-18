using APIEstatisticasStacks.Business;
using APIEstatisticasStacks.Business.Interfaces;
using APIEstatisticasStacks.Extensions;
using APIEstatisticasStacks.Repository;
using APIEstatisticasStacks.Repository.Interfaces;
using APIEstatisticasStacks.Repositorysitory;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApiDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("local")));
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddScoped<IEstatisticasBusiness, EstatisticasBusiness>();
builder.Services.AddScoped<IEstatisticaRepository, EstatisticasRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware(typeof(ManipuladorExcecoesConfig));

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();