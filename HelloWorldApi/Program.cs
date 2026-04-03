var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/hello", () => new { message = "Hello, World 2!", timestamp = DateTime.UtcNow });

app.Run();
