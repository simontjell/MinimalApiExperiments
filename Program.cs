using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Http;

var builder = WebApplication.CreateBuilder(args);

// Dependency injection
builder.Services.AddScoped<IHelloService, HelloService>();
builder.Services.AddScoped<IGreetingEndpoint, GreetingEndpoint>();
builder.Services.AddScoped<IDateTimeProvider, DateTimeProvider>();
builder.Services.AddScoped<ITimeEndpoint, TimeEndpoint>();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Description = "Docs for my API", Version = "v1" });
});

var app = builder.Build();

// Middleware
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
});

// API
app.MapPost("/hello", (IGreetingEndpoint endpoint, HttpContext httpContext, Person person) => endpoint.Greet(httpContext, person));
app.MapGet("/time", (ITimeEndpoint timeEndpoint) => timeEndpoint.GetTime());

app.Run();

 
