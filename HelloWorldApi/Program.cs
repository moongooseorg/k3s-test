var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/hello", () => new { message = "Hello, World 4!", timestamp = DateTime.UtcNow });

app.Run();
