using P4GSite.SecurityHeaders;
using P4GSite.Services.Interfaces;

namespace P4GSite.Services;

public class SecurityHeaderService : ISecurityHeaderService
{
    public ContentSecurityPolicy ContentSecurityPolicy { get; } = new();

    public SecurityHeaderService()
    {
        {
            var defaultDirective = ContentSecurityPolicy.GetDefaultSrcDirective();
            defaultDirective.AddNone();
        }
    }
}
