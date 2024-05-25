using System.Runtime.CompilerServices;
using ValueGuard._Internal.Abstractions;

namespace ValueGuard.Predicates;

internal readonly struct TimeSpanPredicates
    : IDefaultPredicate<TimeSpan>
    , IEqualPredicate<TimeSpan>
    , IEqualWithTolerancePredicate<TimeSpan, TimeSpan>
    , IRangePredicate<TimeSpan>
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