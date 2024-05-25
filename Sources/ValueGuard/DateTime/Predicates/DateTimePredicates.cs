using System.Runtime.CompilerServices;
using ValueGuard._Internal.Abstractions;

namespace ValueGuard.Predicates;

internal readonly struct DateTimePredicates
    : IDefaultPredicate<DateTime>
    , IEqualPredicate<DateTime>
    , IEqualWithTolerancePredicate<DateTime, TimeSpan>
    , IRangePredicate<DateTime>
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsDefault(DateTime value) => value == default;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsEqual(DateTime left, DateTime right) => left == right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsValidTolerance(TimeSpan tolerance) => tolerance >= TimeSpan.Zero;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsEqual(DateTime left, DateTime right, TimeSpan tolerance)
        => (left > right ? left - right : right - left) < tolerance;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsGreater(DateTime left, DateTime right) => left > right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsGreaterOrEqual(DateTime left, DateTime right) => left >= right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsLess(DateTime left, DateTime right) => left < right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsLessOrEqual(DateTime left, DateTime right) => left <= right;
}