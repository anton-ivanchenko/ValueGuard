using System.Text.RegularExpressions;
using ValueGuard._Internal;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<string> IsEqual(this in GuardValue<string> guard, string value)
        => ref GenericImplementation.IsEqual(guard, value, EqualityComparer<string>.Default);

    public static ref readonly GuardValue<string> IsEqual(
        this in GuardValue<string> guard,
        string value,
        IEqualityComparer<string> comparer)
        => ref GenericImplementation.IsEqual(guard, value, comparer);

    public static ref readonly GuardValue<string> NotEqual(this in GuardValue<string> guard, string value)
        => ref GenericImplementation.NotEqual(guard, value, EqualityComparer<string>.Default);

    public static ref readonly GuardValue<string> NotEqual(
        this in GuardValue<string> guard,
        string value,
        IEqualityComparer<string> comparer)
        => ref GenericImplementation.NotEqual(guard, value, comparer);

    public static ref readonly GuardValue<string> IsEmpty(this in GuardValue<string> guard)
    {
        if (guard.Value.Length > 0)
        {
            guard.ThrowException("String must be empty");
        }

        return ref guard;
    }

    public static ref readonly GuardValue<string> NotEmpty(this in GuardValue<string> guard)
    {
        if (string.IsNullOrEmpty(guard.Value))
        {
            guard.ThrowException("String cannot be empty");
        }

        return ref guard;
    }

    public static ref readonly GuardValue<string> IsWhiteSpace(this in GuardValue<string> guard)
    {
        if (!string.IsNullOrWhiteSpace(guard.Value))
        {
            guard.ThrowException("String must be null or consist only of white space characters");
        }

        return ref guard;
    }

    public static ref readonly GuardValue<string> NotWhiteSpace(this in GuardValue<string> guard)
    {
        if (string.IsNullOrWhiteSpace(guard.Value))
        {
            guard.ThrowException("String cannot be null and must have at least one not white space character");
        }

        return ref guard;
    }

    public static ref readonly GuardValue<string> HasMinLength(this in GuardValue<string> guard, int minLength)
    {
        if (guard.Value.Length < minLength)
        {
            guard.ThrowException($"String length must be at least {minLength} characters");
        }

        return ref guard;
    }

    public static ref readonly GuardValue<string> HasMaxLength(this in GuardValue<string> guard, int maxLength)
    {
        if (guard.Value.Length > maxLength)
        {
            guard.ThrowException($"String length must not exceed {maxLength} characters");
        }

        return ref guard;
    }

    public static ref readonly GuardValue<string> HasExactLength(this in GuardValue<string> guard, int exactLength)
    {
        if (guard.Value.Length != exactLength)
        {
            guard.ThrowException($"String length must be exactly {exactLength} characters");
        }

        return ref guard;
    }

    public static ref readonly GuardValue<string> HasLengthInRange(this in GuardValue<string> guard, int minLength, int maxLength)
    {
        if (guard.Value.Length < minLength || guard.Value.Length > maxLength)
        {
            guard.ThrowException($"String length must be between {minLength} and {maxLength} characters");
        }

        return ref guard;
    }

    public static ref readonly GuardValue<string> MatchesPattern(this in GuardValue<string> guard, string pattern)
    {
        if (!Regex.IsMatch(guard.Value, pattern))
        {
            guard.ThrowException($"String does not match the required pattern: {pattern}");
        }

        return ref guard;
    }

    public static ref readonly GuardValue<string> MatchesPattern(this in GuardValue<string> guard, Regex pattern)
    {
        if (!pattern.IsMatch(guard.Value))
        {
            guard.ThrowException($"String does not match the required pattern: {pattern}");
        }

        return ref guard;
    }
}