using System.Runtime.CompilerServices;
using ValueGuard._Internal.Abstractions;

namespace ValueGuard._Internal;

internal static partial class GenericImplementation
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly GuardValue<TValue> GreaterThan<TValue, TPredicate>(in GuardValue<TValue> guard, TValue value)
        where TPredicate : struct, IRangePredicate<TValue>
    {
        if (default(TPredicate).IsLessOrEqual(guard.Value, value))
        {
            guard.ThrowException($"The value must be greater than {value}");
        }

        return ref guard;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly GuardValue<TValue> GreaterThanOrEqualTo<TValue, TPredicate>(
        in GuardValue<TValue> guard,
        TValue value)
        where TPredicate : struct, IRangePredicate<TValue>
    {
        if (default(TPredicate).IsLess(guard.Value, value))
        {
            guard.ThrowException($"The value must be greater than or equal to {value}");
        }

        return ref guard;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly GuardValue<TValue> LessThan<TValue, TPredicate>(in GuardValue<TValue> guard, TValue value)
        where TPredicate : struct, IRangePredicate<TValue>
    {
        if (default(TPredicate).IsGreaterOrEqual(guard.Value, value))
        {
            guard.ThrowException($"The value must be less than {value}");
        }

        return ref guard;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly GuardValue<TValue> LessThanOrEqualTo<TValue, TPredicate>(
        in GuardValue<TValue> guard,
        TValue value)
        where TPredicate : struct, IRangePredicate<TValue>
    {
        if (default(TPredicate).IsGreater(guard.Value, value))
        {
            guard.ThrowException($"The value must be less than or equal to {value}");
        }

        return ref guard;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly GuardValue<TValue> InRange<TValue, TPredicate>(
        in GuardValue<TValue> guard,
        TValue min,
        TValue max,
        bool excludeMin = false,
        bool excludeMax = false)
        where TPredicate : struct, IRangePredicate<TValue>
    {
        var comparer = default(TPredicate);

        switch (excludeMin, excludeMax)
        {
            case (false, false)
                when comparer.IsLess(guard.Value, min) || comparer.IsGreater(guard.Value, max):
                guard.ThrowException($"The value must be in the range {min} to {max}, inclusive");
                break;

            case (false, true)
                when comparer.IsLess(guard.Value, min) || comparer.IsGreaterOrEqual(guard.Value, max):
                guard.ThrowException($"The value must be in the range {min} to {max}, including min but excluding max");
                break;

            case (true, false)
                when comparer.IsLessOrEqual(guard.Value, min) || comparer.IsGreater(guard.Value, max):
                guard.ThrowException($"The value must be in the range {min} to {max}, excluding min but including max");
                break;

            case (true, true)
                when comparer.IsLessOrEqual(guard.Value, min) || comparer.IsGreaterOrEqual(guard.Value, max):
                guard.ThrowException($"The value must be in the range {min} to {max}, exclusive");
                break;
        }

        return ref guard;
    }
}