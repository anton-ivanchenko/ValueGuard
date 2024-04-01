using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace ValueGuard;

public static class Guard
{
    public static void Null<T>(T? value, [CallerArgumentExpression(nameof(value))] string? parameterName = null)
        where T : struct
    {
        if (!value.HasValue)
            return;

        parameterName ??= nameof(value);

        throw GuardException.Create(parameterName, value, "Value must be null");
    }

    public static void Null<T>(T? value, [CallerArgumentExpression(nameof(value))] string? parameterName = null)
        where T : class
    {
        if (value is null)
            return;

        parameterName ??= nameof(value);

        throw GuardException.Create(parameterName, value, "Value must be null");
    }

    public static GuardValue<T> NotNull<T>([NotNull] T? value, [CallerArgumentExpression(nameof(value))] string? parameterName = null)
        where T : struct
    {
        parameterName ??= nameof(value);

        if (!value.HasValue)
        {
            throw GuardException.Create(parameterName, "Value cannot be null");
        }

        return new GuardValue<T>(parameterName, value.Value);
    }

    public static GuardValue<T> NotNull<T>([NotNull] T? value, [CallerArgumentExpression(nameof(value))] string? parameterName = null)
        where T : class
    {
        parameterName ??= nameof(value);

        if (value is null)
        {
            throw GuardException.Create(parameterName, "Value cannot be null");
        }

        return new GuardValue<T>(parameterName, value);
    }

    public static GuardValue<T> Value<T>(T value, [CallerArgumentExpression(nameof(value))] string? parameterName = null)
    {
        parameterName ??= nameof(value);
        return new GuardValue<T>(parameterName, value);
    }
}