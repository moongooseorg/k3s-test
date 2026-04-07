using Bogus;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var faker = new Faker();
app.MapGet("/hello", () => new { message = "Hello, World!", timestamp = DateTime.UtcNow, funFact = faker.Hacker.Phrase() });

app.Run();
