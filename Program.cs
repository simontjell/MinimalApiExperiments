using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Http;
using MinApiSample;


var builder = WebApplication.CreateBuilder(args);

// Dependency injection
builder.Services.AddSingleton<HelloService>();
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
app.MapPost("/hello", (HttpContext c, HelloService s, Person p) => Endpoints.Greet(c, s, p));
app.MapGet("/time", () => new Time(TimeOnly.FromDateTime(DateTime.Now)));

app.Run();

 
