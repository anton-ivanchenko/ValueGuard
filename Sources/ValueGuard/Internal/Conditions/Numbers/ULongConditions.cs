using System.Runtime.CompilerServices;
using ValueGuard.Internal.Conditions.Abstractions;

namespace ValueGuard.Internal.Conditions.Numbers;

internal readonly struct ULongConditions
    : IHaveDefaultCondition<ulong>
    , IHaveEqualCondition<ulong>
    , IHaveRangeCondition<ulong>
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsDefault(ulong value) => value == 0UL;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsEqual(ulong left, ulong right) => left == right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsGreater(ulong left, ulong right) => left > right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsGreaterOrEqual(ulong left, ulong right) => left >= right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsLess(ulong left, ulong right) => left < right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsLessOrEqual(ulong left, ulong right) => left <= right;
}