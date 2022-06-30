namespace P4GSite.SecurityHeaders.ContentSecurityPolicyDirectives;

public abstract class SrcDirective : IDirective
{
    private readonly List<string> _list = new();

    public void AddNone()
    {
        _list.Add("'none'");
    }

    public override string ToString()
    {
        return string.Join(' ', _list);
    }
}
