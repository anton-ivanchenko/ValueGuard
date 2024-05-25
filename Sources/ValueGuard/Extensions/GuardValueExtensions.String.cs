using System.Text.RegularExpressions;
using ValueGuard.Internal;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<string> Equal(this in GuardValue<string> guard, string value)
        => ref InternalGuardValueExtensions.Equal(guard, value, EqualityComparer<string>.Default);

    public static ref readonly GuardValue<string> Equal(
        this in GuardValue<string> guard,
        string value,
        IEqualityComparer<string> comparer)
        => ref InternalGuardValueExtensions.Equal(guard, value, comparer);

    public static ref readonly GuardValue<string> NotEqual(this in GuardValue<string> guard, string value)
        => ref InternalGuardValueExtensions.NotEqual(guard, value, EqualityComparer<string>.Default);

    public static ref readonly GuardValue<string> NotEqual(
        this in GuardValue<string> guard,
        string value,
        IEqualityComparer<string> comparer)
        => ref InternalGuardValueExtensions.NotEqual(guard, value, comparer);

    public static ref readonly GuardValue<string> IsEmpty(this in GuardValue<string> guard)
    {
        if (guard.Value.Length > 0)
        {
            guard.ThrowException("String must be empty");
        }

        return ref guard;
    }

    public static ref readonly GuardValue<string> IsNotEmpty(this in GuardValue<string> guard)
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

    public static ref readonly GuardValue<string> IsNotWhiteSpace(this in GuardValue<string> guard)
    {
        if (string.IsNullOrWhiteSpace(guard.Value))
        {
            guard.ThrowException("String cannot be null and must have at least one not white space character");
        }

        return ref guard;
    }

    public static ref readonly GuardValue<string> MinLength(this in GuardValue<string> guard, int minLength)
    {
        if (guard.Value.Length < minLength)
        {
            guard.ThrowException($"String length must be at least {minLength} characters");
        }

        return ref guard;
    }

    public static ref readonly GuardValue<string> MaxLength(this in GuardValue<string> guard, int maxLength)
    {
        if (guard.Value.Length > maxLength)
        {
            guard.ThrowException($"String length must not exceed {maxLength} characters");
        }

        return ref guard;
    }

    public static ref readonly GuardValue<string> ExactLength(this in GuardValue<string> guard, int exactLength)
    {
        if (guard.Value.Length != exactLength)
        {
            guard.ThrowException($"String length must be exactly {exactLength} characters");
        }

        return ref guard;
    }

    public static ref readonly GuardValue<string> LengthInRange(this in GuardValue<string> guard, int minLength, int maxLength)
    {
        if (guard.Value.Length < minLength || guard.Value.Length > maxLength)
        {
            guard.ThrowException($"String length must be between {minLength} and {maxLength} characters");
        }

        return ref guard;
    }

    public static ref readonly GuardValue<string> IsMatchesPattern(this in GuardValue<string> guard, string pattern)
    {
        if (!Regex.IsMatch(guard.Value, pattern))
        {
            guard.ThrowException($"String does not match the required pattern: {pattern}");
        }

        return ref guard;
    }

    public static ref readonly GuardValue<string> IsMatchesPattern(this in GuardValue<string> guard, Regex pattern)
    {
        if (!pattern.IsMatch(guard.Value))
        {
            guard.ThrowException($"String does not match the required pattern: {pattern}");
        }

        return ref guard;
    }
}