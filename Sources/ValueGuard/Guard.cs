using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace ValueGuard;

public static class Guard
{
    public static GuardSettings Settings { get; set; } = new();

    public static void IsNull<T>(T? value, [CallerArgumentExpression(nameof(value))] string? parameterName = null)
        where T : struct
    {
        if (!value.HasValue)
            return;

        parameterName ??= nameof(value);

        throw GuardException.Create(parameterName, value, "Value must be null");
    }

    public static void IsNull<T>(T? value, [CallerArgumentExpression(nameof(value))] string? parameterName = null)
        where T : class
    {
        if (value is null)
            return;

        parameterName ??= nameof(value);

        throw GuardException.Create(parameterName, value, "Value must be null");
    }

    public static GuardContext<T> NotNull<T>(
        [NotNull] T? value,
        [CallerArgumentExpression(nameof(value))] string? parameterName = null)
        where T : struct
    {
        parameterName ??= nameof(value);

        if (!value.HasValue)
        {
            throw GuardException.Create(parameterName, value, "Value cannot be null");
        }

        return new(parameterName, value.Value);
    }

    public static GuardContext<T> NotNull<T>(
        [NotNull] T? value,
        [CallerArgumentExpression(nameof(value))] string? parameterName = null)
        where T : class
    {
        parameterName ??= nameof(value);

        if (value is null)
        {
            throw GuardException.Create(parameterName, value, "Value cannot be null");
        }

        return new(parameterName, value);
    }

    public static GuardContext<T> Value<T>(T value, [CallerArgumentExpression(nameof(value))] string? parameterName = null)
        where T : notnull
    {
        parameterName ??= nameof(value);
        return new(parameterName, value);
    }
}