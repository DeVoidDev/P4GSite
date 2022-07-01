namespace P4GSite.SecurityHeaders.ContentSecurityPolicyDirectives;

public class TrustedTypesDirective : IDirective
{
    public bool IncludeScripts { get; set; }
    public override string ToString()
    {
        return IncludeScripts ? "'script'" : "";
    }
}
