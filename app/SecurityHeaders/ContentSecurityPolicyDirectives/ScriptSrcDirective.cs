namespace P4GSite.SecurityHeaders.ContentSecurityPolicyDirectives;

public class ScriptSrcDirective : SrcDirective
{
    public void AddNonce(string nonce)
    {
        List.Add($"'nonce-{nonce}'");
    }
}
