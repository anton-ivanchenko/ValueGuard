using System.Runtime.CompilerServices;
using ValueGuard._Internal.Abstractions;

namespace ValueGuard._Internal;

internal static partial class GenericImplementation
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly GuardContext<TValue> EqualTo<TValue>(
        in GuardContext<TValue> guard,
        TValue value,
        IEqualityComparer<TValue> comparer)
    {
        if (!comparer.Equals(guard.Value, value))
        {
            guard.ThrowException($"The value must be equal '{value}' with {comparer.GetType()} comparer");
        }

        return ref guard;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly GuardContext<TValue> EqualTo<TValue, TPredicate>(in GuardContext<TValue> guard, TValue value)
        where TPredicate : struct, IEqualPredicate<TValue>
    {
        if (!default(TPredicate).IsEqual(guard.Value, value))
        {
            guard.ThrowException($"The value must be '{value}'");
        }

        return ref guard;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly GuardContext<TValue> EqualTo<TValue, TTolerance, TPredicate>(
        in GuardContext<TValue> guard,
        TValue value,
        TTolerance tolerance)
        where TPredicate : struct, IEqualWithTolerancePredicate<TValue, TTolerance>
    {
        if (!default(TPredicate).IsValidTolerance(tolerance))
        {
            throw new ArgumentOutOfRangeException(nameof(tolerance), tolerance, "Incorrect tolerance value");
        }

        if (!default(TPredicate).IsEqual(guard.Value, value, tolerance))
        {
            guard.ThrowException($"The value must be '{value}', with a possible tolerance of less than '{tolerance}'");
        }

        return ref guard;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly GuardContext<TValue> NotEqualTo<TValue>(
        in GuardContext<TValue> guard,
        TValue value,
        IEqualityComparer<TValue> comparer)
    {
        if (comparer.Equals(guard.Value, value))
        {
            guard.ThrowException($"The value must be equal '{value}' with {comparer.GetType()} comparer");
        }

        return ref guard;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly GuardContext<TValue> NotEqualTo<TValue, TPredicate>(in GuardContext<TValue> guard, TValue value)
        where TPredicate : struct, IEqualPredicate<TValue>
    {
        if (default(TPredicate).IsEqual(guard.Value, value))
        {
            guard.ThrowException($"The value cannot be '{value}'");
        }

        return ref guard;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly GuardContext<TValue> NotEqualTo<TValue, TTolerance, TPredicate>(
        in GuardContext<TValue> guard,
        TValue value,
        TTolerance tolerance)
        where TPredicate : struct, IEqualWithTolerancePredicate<TValue, TTolerance>
    {
        if (!default(TPredicate).IsValidTolerance(tolerance))
        {
            throw new ArgumentOutOfRangeException(nameof(tolerance), tolerance, "Incorrect tolerance value");
        }

        if (default(TPredicate).IsEqual(guard.Value, value, tolerance))
        {
            guard.ThrowException($"The value cannot be '{value}', with a possible tolerance of less than '{tolerance}'");
        }

        return ref guard;
    }
}