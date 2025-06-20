using Microservices.Demo.Policies.Service.Application.UseCases.Policy.Queries.GetAllPolicies;
using Microservices.Demo.Policies.Service.Framework;
using Microservices.Infrastructure.Logger;
using Microservices.SharedKernel.Application.UseCases.Interfaces;
using Steeltoe.Extensions.Configuration.ConfigServer;

var builder = WebApplication.CreateBuilder(args);

//builder.AddConfigServer(); //Disble for local development, use AddConfigServer(false) to disable Config Server
//builder.Host.AddSerilogLogstash();
builder.Services.AddHostServices(builder.Configuration);

//builder.Services.AddScoped<IQueryUseCase<GetAllPoliciesQuery, GetAllPoliciesResult>, GetAllPoliciesUseCase>();


var app = builder.Build();

await app.UseHostSetupAsync();

app.Run();