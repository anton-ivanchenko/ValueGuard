using System.Runtime.CompilerServices;
using ValueGuard.Internal.Conditions.Abstractions;

namespace ValueGuard.Internal;

internal static partial class InternalGuardValueExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly GuardValue<TValue> IsEqual<TValue>(
        this in GuardValue<TValue> guard,
        TValue value,
        IEqualityComparer<TValue> comparer)
    {
        if (!comparer.Equals(guard.Value, value))
        {
            // TODO: Change error message, because of the comparator, the message may not be correct
            guard.ThrowException($"The value must be '{value}'");
        }

        return ref guard;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly GuardValue<TValue> IsEqual<TValue, TCondition>(this in GuardValue<TValue> guard, TValue value)
        where TCondition : struct, IHaveEqualCondition<TValue>
    {
        if (!default(TCondition).IsEqual(guard.Value, value))
        {
            guard.ThrowException($"The value must be '{value}'");
        }

        return ref guard;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly GuardValue<TValue> IsEqual<TValue, TCondition>(
        this in GuardValue<TValue> guard,
        TValue value,
        TValue tolerance)
        where TCondition : struct, IHaveEqualWithPrecisionCondition<TValue>
    {
        // TODO: The "tolerance" value must also be validated

        if (!default(TCondition).IsEqual(guard.Value, value, tolerance))
        {
            guard.ThrowException($"The value must be '{value}', with a possible tolerance of less than '{tolerance}'");
        }

        return ref guard;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly GuardValue<TValue> IsNotEqual<TValue>(
        this in GuardValue<TValue> guard,
        TValue value,
        IEqualityComparer<TValue> comparer)
    {
        if (comparer.Equals(guard.Value, value))
        {
            // TODO: Change error message, because of the comparator, the message may not be correct
            guard.ThrowException($"The value cannot be '{value}'");
        }

        return ref guard;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly GuardValue<TValue> IsNotEqual<TValue, TCondition>(this in GuardValue<TValue> guard, TValue value)
        where TCondition : struct, IHaveEqualCondition<TValue>
    {
        if (default(TCondition).IsEqual(guard.Value, value))
        {
            guard.ThrowException($"The value cannot be '{value}'");
        }

        return ref guard;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly GuardValue<TValue> IsNotEqual<TValue, TCondition>(
        this in GuardValue<TValue> guard,
        TValue value,
        TValue tolerance)
        where TCondition : struct, IHaveEqualWithPrecisionCondition<TValue>
    {
        // TODO: The "tolerance" value must also be validated

        if (default(TCondition).IsEqual(guard.Value, value, tolerance))
        {
            guard.ThrowException($"The value cannot be '{value}', with a possible tolerance of less than '{tolerance}'");
        }

        return ref guard;
    }
}