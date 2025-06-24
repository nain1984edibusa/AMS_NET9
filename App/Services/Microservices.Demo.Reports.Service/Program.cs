using Microservices.Demo.Reports.Service.Application.Interfaces;
using Microservices.Demo.Reports.Service.Application.Services;
using Microservices.Demo.Reports.Service.Infrastructure.Clients;
using Steeltoe.Discovery.Client;

var builder = WebApplication.CreateBuilder(args);


// Agregar Eureka Discovery Client
builder.Services.AddDiscoveryClient(builder.Configuration);

builder.Services.AddScoped<IReportService, ReportService>();
builder.Services.AddScoped<IPolicyClient, PolicyClient>();
builder.Services.AddScoped<IProductClient, ProductClient>();


builder.Services.AddHttpClient<IPolicyClient, PolicyClient>(client =>
    client.BaseAddress = new Uri("http://localhost:5182")); // Cambia a host real

builder.Services.AddHttpClient<IProductClient, ProductClient>(client =>
    client.BaseAddress = new Uri("http://localhost:5176")); // Cambia a host real

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
