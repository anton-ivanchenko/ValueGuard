using System.Diagnostics.CodeAnalysis;

namespace ValueGuard;

public readonly struct GuardValue<T>(string parameterName, T value)
{
    public string ParameterName { get; } = parameterName;

    public T Value { get; } = value;

    [DoesNotReturn]
    public void ThrowException(string message)
        => throw GuardException.Create(ParameterName, Value, message);
}