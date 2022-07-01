namespace P4GSite.SecurityHeaders.ContentSecurityPolicyDirectives;

public abstract class SrcDirective : IDirective
{
    protected readonly List<string> List = new();

    public void AddNone()
    {
        List.Add("'none'");
    }

    public override string ToString()
    {
        return string.Join(' ', List);
    }
}
