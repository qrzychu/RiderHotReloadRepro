using Shared;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => new Class1
{
    Prop1 = 5
});

app.Run();