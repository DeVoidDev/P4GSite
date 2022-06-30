using P4GSite.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.ConfigureKestrel(option => option.AddServerHeader = false);
builder.AddUnixSocket();
builder.Services.AddRazorPages();
builder.Services.AddSecurityHeaders();
var app = builder.Build();

app.UseSecurityHeaders();
app.UseHttpsRedirection();
app.UseHsts();
app.MapControllers();

app.Run();