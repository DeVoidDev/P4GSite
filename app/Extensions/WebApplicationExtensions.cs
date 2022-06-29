namespace P4GSite.Extensions;

public static class WebApplicationExtensions
{
    public static void UseUnixSocket(this WebApplicationBuilder builder)
    {
        string unixSocket;
        if((unixSocket = builder.Configuration["Kestrel:UnixSocket"]) == null) return;
        builder.WebHost.ConfigureKestrel(options => options.ListenUnixSocket(unixSocket));
    }
}