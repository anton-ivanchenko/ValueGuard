using System.Runtime.CompilerServices;
using ValueGuard.Internal.Conditions.Abstractions;

namespace ValueGuard.Internal.Conditions;

internal readonly struct BoolConditions : IHaveEqualCondition<bool>
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsEqual(bool left, bool right) => left == right;
}