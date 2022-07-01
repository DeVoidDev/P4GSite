using System.Security.Cryptography;
using P4GSite.SecurityHeaders;
using P4GSite.Services.Interfaces;

namespace P4GSite.Services;

public class SecurityHeaderService : ISecurityHeaderService
{
    public SecurityHeaderService()
    {
        {
            var connectDirective = ContentSecurityPolicy.GetDefaultDirective();
            connectDirective.AddNone();
        }
    }

    public ContentSecurityPolicy ContentSecurityPolicy { get; } = new();

    public string Nonce { get; } = Convert.ToBase64String(RandomNumberGenerator.GetBytes(16));
}