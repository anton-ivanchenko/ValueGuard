using System.Runtime.CompilerServices;
using ValueGuard.Internal.Conditions.Abstractions;

namespace ValueGuard.Internal;

internal static partial class InternalGuardValueExtensions
{
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
}