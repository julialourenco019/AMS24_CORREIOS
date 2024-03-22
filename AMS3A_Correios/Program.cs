using AMS3A_Correios.Integracao;
using AMS3A_Correios.Integracao.Interfaces;
using AMS3A_Correios.Integracao.Refit;
using Refit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IViaCepIntegracao , ViaCepIntegracao>();
//injeção de dependencia
builder.Services.AddRefitClient<IViaCepIntegracaoRefit>().ConfigureHttpClient( c =>
{
     c.BaseAddress = new Uri("https://viacep.com.br");
}
);

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
