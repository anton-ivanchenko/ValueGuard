using System.Text.RegularExpressions;
using ValueGuard._Internal;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardContext<string> EqualTo(this in GuardContext<string> guard, string value)
        => ref GenericImplementation.EqualTo(guard, value, EqualityComparer<string>.Default);

    public static ref readonly GuardContext<string> EqualTo(
        this in GuardContext<string> guard,
        string value,
        IEqualityComparer<string> comparer)
        => ref GenericImplementation.EqualTo(guard, value, comparer);

    public static ref readonly GuardContext<string> NotEqualTo(this in GuardContext<string> guard, string value)
        => ref GenericImplementation.NotEqualTo(guard, value, EqualityComparer<string>.Default);

    public static ref readonly GuardContext<string> NotEqualTo(
        this in GuardContext<string> guard,
        string value,
        IEqualityComparer<string> comparer)
        => ref GenericImplementation.NotEqualTo(guard, value, comparer);

    public static ref readonly GuardContext<string> IsEmpty(this in GuardContext<string> guard)
    {
        if (guard.Value.Length > 0)
        {
            guard.ThrowException("String must be empty");
        }

        return ref guard;
    }

    public static ref readonly GuardContext<string> NotEmpty(this in GuardContext<string> guard)
    {
        if (string.IsNullOrEmpty(guard.Value))
        {
            guard.ThrowException("String cannot be empty");
        }

        return ref guard;
    }

    public static ref readonly GuardContext<string> IsWhiteSpace(this in GuardContext<string> guard)
    {
        if (!string.IsNullOrWhiteSpace(guard.Value))
        {
            guard.ThrowException("String must be null or consist only of white space characters");
        }

        return ref guard;
    }

    public static ref readonly GuardContext<string> NotWhiteSpace(this in GuardContext<string> guard)
    {
        if (string.IsNullOrWhiteSpace(guard.Value))
        {
            guard.ThrowException("String cannot be null and must have at least one not white space character");
        }

        return ref guard;
    }

    public static ref readonly GuardContext<string> HasMinLength(this in GuardContext<string> guard, int minLength)
    {
        if (guard.Value.Length < minLength)
        {
            guard.ThrowException($"String length must be at least {minLength} characters");
        }

        return ref guard;
    }

    public static ref readonly GuardContext<string> HasMaxLength(this in GuardContext<string> guard, int maxLength)
    {
        if (guard.Value.Length > maxLength)
        {
            guard.ThrowException($"String length must not exceed {maxLength} characters");
        }

        return ref guard;
    }

    public static ref readonly GuardContext<string> HasExactLength(this in GuardContext<string> guard, int exactLength)
    {
        if (guard.Value.Length != exactLength)
        {
            guard.ThrowException($"String length must be exactly {exactLength} characters");
        }

        return ref guard;
    }

    public static ref readonly GuardContext<string> HasLengthInRange(this in GuardContext<string> guard, int minLength, int maxLength)
    {
        if (guard.Value.Length < minLength || guard.Value.Length > maxLength)
        {
            guard.ThrowException($"String length must be between {minLength} and {maxLength} characters");
        }

        return ref guard;
    }

    public static ref readonly GuardContext<string> MatchesPattern(this in GuardContext<string> guard, string pattern)
    {
        if (!Regex.IsMatch(guard.Value, pattern))
        {
            guard.ThrowException($"String does not match the required pattern: {pattern}");
        }

        return ref guard;
    }

    public static ref readonly GuardContext<string> MatchesPattern(this in GuardContext<string> guard, Regex pattern)
    {
        if (!pattern.IsMatch(guard.Value))
        {
            guard.ThrowException($"String does not match the required pattern: {pattern}");
        }

        return ref guard;
    }
}