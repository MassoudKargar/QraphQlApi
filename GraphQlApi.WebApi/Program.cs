using System.Collections.Immutable;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello Massoud");

app.Run();
