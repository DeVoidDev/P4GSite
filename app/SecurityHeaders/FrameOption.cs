namespace P4GSite.SecurityHeaders;

public class FrameOption
{
    private readonly string _name;

    private FrameOption(string name)
    {
        _name = name;
    }

    public static FrameOption Deny { get; } = new("DENY");
    public static FrameOption Allow { get; } = new("ALLOW");
    public static FrameOption SameOrigin { get; } = new("SAMEORIGIN");

    public new string ToString()
    {
        return _name;
    }
}