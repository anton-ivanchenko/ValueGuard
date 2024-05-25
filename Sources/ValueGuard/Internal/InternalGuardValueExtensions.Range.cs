using System.Runtime.CompilerServices;
using ValueGuard.Internal.Conditions.Abstractions;

namespace ValueGuard.Internal;

internal static partial class InternalGuardValueExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly GuardValue<TValue> Greater<TValue, TCondition>(this in GuardValue<TValue> guard, TValue value)
        where TCondition : struct, IHaveRangeCondition<TValue>
    {
        if (default(TCondition).IsLessOrEqual(guard.Value, value))
        {
            guard.ThrowException($"The value must be greater than {value}");
        }

        return ref guard;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly GuardValue<TValue> GreaterOrEqual<TValue, TCondition>(
        this in GuardValue<TValue> guard,
        TValue value)
        where TCondition : struct, IHaveRangeCondition<TValue>
    {
        if (default(TCondition).IsLess(guard.Value, value))
        {
            guard.ThrowException($"The value must be greater than or equal to {value}");
        }

        return ref guard;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly GuardValue<TValue> Less<TValue, TCondition>(this in GuardValue<TValue> guard, TValue value)
        where TCondition : struct, IHaveRangeCondition<TValue>
    {
        if (default(TCondition).IsGreaterOrEqual(guard.Value, value))
        {
            guard.ThrowException($"The value must be less than {value}");
        }

        return ref guard;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly GuardValue<TValue> LessOrEqual<TValue, TCondition>(
        this in GuardValue<TValue> guard,
        TValue value)
        where TCondition : struct, IHaveRangeCondition<TValue>
    {
        if (default(TCondition).IsGreater(guard.Value, value))
        {
            guard.ThrowException($"The value must be less than or equal to {value}");
        }

        return ref guard;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly GuardValue<TValue> InRange<TValue, TCondition>(
        this in GuardValue<TValue> guard,
        TValue min,
        TValue max,
        bool excludeMin = false,
        bool excludeMax = false)
        where TCondition : struct, IHaveRangeCondition<TValue>
    {
        var comparer = default(TCondition);

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