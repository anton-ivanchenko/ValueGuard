using System.Runtime.CompilerServices;
using ValueGuard.Internal.Conditions.Abstractions;

namespace ValueGuard.Internal.Conditions.Numbers;

// TODO: Perhaps a tolerance parameter is needed for all comparison methods

internal readonly struct DecimalConditions
    : IHaveDefaultCondition<decimal>
    , IHaveEqualWithPrecisionCondition<decimal>
    , IHaveRangeCondition<decimal>
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsDefault(decimal value) => value == 0M;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsEqual(decimal left, decimal right, decimal tolerance)
        => Math.Abs(left - right) < tolerance;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsGreater(decimal left, decimal right) => left > right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsGreaterOrEqual(decimal left, decimal right) => left >= right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsLess(decimal left, decimal right) => left < right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsLessOrEqual(decimal left, decimal right) => left <= right;
}