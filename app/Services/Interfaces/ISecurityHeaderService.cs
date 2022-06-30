using P4GSite.SecurityHeaders;

namespace P4GSite.Services.Interfaces;

public interface ISecurityHeaderService
{
    FrameOption FrameOption { get; set; }
}