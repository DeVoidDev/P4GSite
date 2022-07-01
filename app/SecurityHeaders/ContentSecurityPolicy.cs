using System.Text;
using P4GSite.SecurityHeaders.ContentSecurityPolicyDirectives;

namespace P4GSite.SecurityHeaders;

public class ContentSecurityPolicy
{
    private readonly Dictionary<string, IDirective> _directiveMap = new();
    private T GetDirective<T>(string id, Func<T> func) where T : IDirective
    {
        if (!_directiveMap.ContainsKey(id))
        {
            _directiveMap[id] = func();
        }

        return (T) _directiveMap[id];
    }

    public DefaultSrcDirective GetDefaultSrcDirective() => GetDirective("default-src", () => new DefaultSrcDirective());

    public ScriptSrcDirective GetScriptSrcDirective() => GetDirective("script-src", () => new ScriptSrcDirective());

    public TrustedTypesDirective GetTrustedTypesDirective() =>
        GetDirective("require-trusted-types-for", () => new TrustedTypesDirective());

    public override string ToString()
    {
        var builder = new StringBuilder();
        foreach (var (id, directive) in _directiveMap)
        {
            builder.Append($"{id} {directive};");
        }
        return builder.ToString();
    }

    public ContentSecurityPolicy()
    {
        
    }
}
