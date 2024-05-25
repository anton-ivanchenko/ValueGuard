using System.Runtime.CompilerServices;
using ValueGuard._Internal.Abstractions;

namespace ValueGuard._Internal;

internal static partial class GenericImplementation
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly GuardValue<TValue> IsDefault<TValue, TPredicate>(in GuardValue<TValue> guard)
        where TPredicate : struct, IDefaultPredicate<TValue>
    {
        if (!default(TPredicate).IsDefault(guard.Value))
        {
            guard.ThrowException($"The value must be '{default(TValue)}'.");
        }

        return ref guard;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ref readonly GuardValue<TValue> NotDefault<TValue, TPredicate>(in GuardValue<TValue> guard)
        where TPredicate : struct, IDefaultPredicate<TValue>
    {
        if (default(TPredicate).IsDefault(guard.Value))
        {
            guard.ThrowException($"The value must not be '{default(TValue)}'.");
        }

        return ref guard;
    }
}