using P4GSite.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.UseUnixSocket();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();