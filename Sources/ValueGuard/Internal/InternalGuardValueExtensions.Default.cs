using System.Runtime.CompilerServices;
using ValueGuard.Internal.Conditions.Abstractions;

namespace ValueGuard.Internal;

internal static partial class InternalGuardValueExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly GuardValue<TValue> IsDefault<TValue, TCondition>(this in GuardValue<TValue> guard)
        where TCondition : struct, IHaveDefaultCondition<TValue>
    {
        if (!default(TCondition).IsDefault(guard.Value))
        {
            guard.ThrowException($"The value must be '{default(TValue)}'");
        }

        return ref guard;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly GuardValue<TValue> IsNotDefault<TValue, TCondition>(this in GuardValue<TValue> guard)
        where TCondition : struct, IHaveDefaultCondition<TValue>
    {
        if (default(TCondition).IsDefault(guard.Value))
        {
            guard.ThrowException($"The value must not be '{default(TValue)}'");
        }

        return ref guard;
    }
}