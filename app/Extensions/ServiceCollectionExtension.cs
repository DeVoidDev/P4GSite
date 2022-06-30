using P4GSite.Middleware;
using P4GSite.Services;
using P4GSite.Services.Interfaces;

namespace P4GSite.Extensions;

public static class ServiceCollectionExtension
{
    public static void AddSecurityHeaders(this IServiceCollection services)
    {
        services.AddScoped<ISecurityHeaderService, SecurityHeaderService>();
    }

    public static void UseSecurityHeaders(this WebApplication app)
    {
        app.UseMiddleware<SecurityHeaderMiddleware>();
    }
}