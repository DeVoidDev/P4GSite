using P4GSite.SecurityHeaders;
using P4GSite.Services.Interfaces;

namespace P4GSite.Services;

public class SecurityHeaderService : ISecurityHeaderService
{
    public FrameOption FrameOption { get; set; } = FrameOption.Deny;
}