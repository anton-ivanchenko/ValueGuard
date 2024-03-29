using System.Diagnostics.CodeAnalysis;
using ValueGuard.Exceptions;

namespace ValueGuard;

public readonly struct GuardValue<T>
{
    public GuardValue(string parameterName, T value)
    {
        Value = value;
        ParameterName = parameterName;
    }

    public string ParameterName { get; }

    public T Value { get; }

    [DoesNotReturn]
    public void ThrowException(string message)
    {
        throw GuardException.Create(ParameterName, Value, message);
    }
}