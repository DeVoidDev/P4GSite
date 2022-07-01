using P4GSite.Services.Interfaces;

namespace P4GSite.Middleware;

public class SecurityHeaderMiddleware
{
    private readonly RequestDelegate _next;

    public SecurityHeaderMiddleware(RequestDelegate next)
    {
        _next = next ?? throw new ArgumentNullException(nameof(next));
    }

    public Task Invoke(HttpContext context, ISecurityHeaderService securityHeaderService)
    {
        context.Response.OnStarting(() => Task.CompletedTask);
        return _next(context);
    }
}
