using System.Text;
using P4GSite.SecurityHeaders.ContentSecurityPolicyDirectives;

namespace P4GSite.SecurityHeaders;

public class ContentSecurityPolicy
{
    private readonly Dictionary<string, IDirective> _directiveMap = new();

    public DefaultSrcDirective GetDefaultSrcDirective()
    {
        const string id = "default-src";
        if (!_directiveMap.ContainsKey(id))
        {
            _directiveMap[id] = new DefaultSrcDirective();
        }

        return (DefaultSrcDirective) _directiveMap[id];
    }

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
