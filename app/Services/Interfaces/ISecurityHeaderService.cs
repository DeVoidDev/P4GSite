using P4GSite.SecurityHeaders;

namespace P4GSite.Services.Interfaces;

public interface ISecurityHeaderService
{
    public ContentSecurityPolicy ContentSecurityPolicy { get; }
    public string Nonce { get; }
}
