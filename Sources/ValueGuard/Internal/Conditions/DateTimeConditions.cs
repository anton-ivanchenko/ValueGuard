using System.Runtime.CompilerServices;
using ValueGuard.Internal.Conditions.Abstractions;

namespace ValueGuard.Internal.Conditions;

internal struct DateTimeConditions
    : IHaveDefaultCondition<DateTime>
    , IHaveEqualCondition<DateTime>
    , IHaveEqualWithToleranceCondition<DateTime, TimeSpan>
    , IHaveRangeCondition<DateTime>
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsDefault(DateTime value) => value == default;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsEqual(DateTime left, DateTime right) => left == right;

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