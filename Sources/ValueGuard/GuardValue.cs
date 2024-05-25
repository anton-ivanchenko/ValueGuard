using System.Diagnostics.CodeAnalysis;

namespace ValueGuard;

public readonly struct GuardValue<T>
{
    public GuardValue(string parameterName, T value)
    {
        ParameterName = parameterName;
        Value = value;
    }

    public string ParameterName { get; }

    public T Value { get; }

    [DoesNotReturn]
    public void ThrowException(string message)
    {
        throw GuardException.Create(ParameterName, Value, message);
    }
}