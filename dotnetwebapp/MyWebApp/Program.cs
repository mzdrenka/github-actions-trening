var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/secret", (string? password) => 
{
    if (password == "secret123") {
        return "Nice to see you!";
    }
    else {
        return "Access denied!";
    }
});
app.Run();
