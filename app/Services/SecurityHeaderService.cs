using System.Security.Cryptography;
using P4GSite.SecurityHeaders;
using P4GSite.Services.Interfaces;

namespace P4GSite.Services;

public class SecurityHeaderService : ISecurityHeaderService
{
    public ContentSecurityPolicy ContentSecurityPolicy { get; } = new();

    public string Nonce { get; } = Convert.ToBase64String(RandomNumberGenerator.GetBytes(16));
    public SecurityHeaderService()
    {
        {
            var defaultDirective = ContentSecurityPolicy.GetDefaultSrcDirective();
            defaultDirective.AddNone();
            var scriptDirective = ContentSecurityPolicy.GetScriptSrcDirective();
            scriptDirective.AddNonce(Nonce);
            var trustedTypesDirective = ContentSecurityPolicy.GetTrustedTypesDirective();
            trustedTypesDirective.IncludeScripts = true;
        }
    }
}
