using System.Runtime.CompilerServices;
using ValueGuard.Internal.Conditions.Abstractions;

namespace ValueGuard.Internal.Conditions;

internal readonly struct TimeSpanConditions
    : IHaveDefaultCondition<TimeSpan>
    , IHaveEqualCondition<TimeSpan>
    , IHaveEqualWithToleranceCondition<TimeSpan, TimeSpan>
    , IHaveRangeCondition<TimeSpan>
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsDefault(TimeSpan value) => value == default;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsEqual(TimeSpan left, TimeSpan right) => left == right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsValidTolerance(TimeSpan tolerance) => tolerance >= TimeSpan.Zero;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsEqual(TimeSpan left, TimeSpan right, TimeSpan tolerance)
        => (left > right ? left - right : right - left) < tolerance;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsGreater(TimeSpan left, TimeSpan right) => left > right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsGreaterOrEqual(TimeSpan left, TimeSpan right) => left >= right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsLess(TimeSpan left, TimeSpan right) => left < right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsLessOrEqual(TimeSpan left, TimeSpan right) => left <= right;
}