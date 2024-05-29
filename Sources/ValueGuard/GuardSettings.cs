namespace ValueGuard;

public sealed record GuardSettings
{
    #if NET5_0_OR_GREATER
    public bool ShowParameterValueInException { get; init; } = false;
    #else
    public bool ShowParameterValueInException { get; set; } = false;
    #endif
}