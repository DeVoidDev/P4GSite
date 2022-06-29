using P4GSite.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.UseUnixSocket();
builder.Services.AddRazorPages();
var app = builder.Build();

app.UseHttpsRedirection();
app.UseHsts();
app.MapControllers();

app.Run();