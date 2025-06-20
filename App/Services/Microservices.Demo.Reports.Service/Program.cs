using Microservices.Demo.Reports.Service.Application.Interfaces;
using Microservices.Demo.Reports.Service.Application.Services;
using Microservices.Demo.Reports.Service.Infrastructure.Clients;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IReportService, ReportService>();
builder.Services.AddScoped<IPolicyClient, PolicyClient>();
builder.Services.AddScoped<IProductClient, ProductClient>();


builder.Services.AddHttpClient<IPolicyClient, PolicyClient>(client =>
    client.BaseAddress = new Uri("http://localhost:5182")); // Cambia a host real


//builder.Services.AddHttpClient("Policies", client =>
//{
//    client.BaseAddress = new Uri("http://localhost:5182"); // policies.service
//});

//builder.Services.AddHttpClient("Products", client =>
//{
//    client.BaseAddress = new Uri("http://localhost:5002"); // products.service
//});


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
