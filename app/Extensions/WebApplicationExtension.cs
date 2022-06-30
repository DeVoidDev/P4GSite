namespace P4GSite.Extensions;

public static class WebApplicationExtension
{
    public static void AddUnixSocket(this WebApplicationBuilder builder)
    {
        string unixSocket;
        if ((unixSocket = builder.Configuration["Kestrel:UnixSocket"]) == null) return;
        builder.WebHost.ConfigureKestrel(options => options.ListenUnixSocket(unixSocket));
    }
}