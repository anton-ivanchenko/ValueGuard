using System.Runtime.CompilerServices;
using ValueGuard.Internal.Conditions.Abstractions;

namespace ValueGuard.Internal.Conditions.Numbers;

internal readonly struct LongConditions
    : IHaveDefaultCondition<long>
    , IHaveEqualCondition<long>
    , IHaveRangeCondition<long>
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsDefault(long value) => value == 0L;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsEqual(long left, long right) => left == right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsGreater(long left, long right) => left > right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsGreaterOrEqual(long left, long right) => left >= right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsLess(long left, long right) => left < right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsLessOrEqual(long left, long right) => left <= right;
}