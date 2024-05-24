namespace ValueGuard;

public sealed record GuardSettings
{
    public bool ShowParameterValueInException { get; init; } = false;
}