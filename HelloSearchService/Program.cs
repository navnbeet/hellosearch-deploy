var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello from navneet first deployment");
app.MapGet("/health", () => Results.Ok("Healthy"));

app.Run();
