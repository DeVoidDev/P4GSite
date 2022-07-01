namespace P4GSite.SecurityHeaders.ContentSecurityPolicyDirectives;

public abstract class SourceDirective : IDirective
{
    private readonly List<string> _list = new();

    public void AddHost(string host, int port, string? scheme = null)
    {
        _list.Add($"{(scheme != null ? $"{scheme}://" : string.Empty)}{host}:{port}");
    }

    public void AddScheme(string scheme)
    {
        _list.Add($"{scheme}:");
    }

    public void AddSelf()
    {
        _list.Add("'self'");
    }

    [Obsolete("Eval is unsafe.")]
    public void AddEval()
    {
        _list.Add("'unsafe-eval'");
    }

    [Obsolete("Hashed scripts are unsafe.")]
    public void AddHashes()
    {
        _list.Add("'unsafe-hashes'");
    }

    [Obsolete("Inline scripts are unsafe.")]
    public void AddInline()
    {
        _list.Add("'unsafe-inline'");
    }

    public void AddNone()
    {
        _list.Add("'none'");
    }

    public void AddStrictDynamic()
    {
        _list.Add("'strict-dynamic'");
    }


    public override string ToString()
    {
        return string.Join(' ', _list);
    }
}
