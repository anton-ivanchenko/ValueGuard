using System.Runtime.CompilerServices;
using ValueGuard.Internal.Conditions.Abstractions;

namespace ValueGuard.Internal.Conditions;

// TODO: Perhaps a tolerance parameter is needed for all comparison methods

internal readonly struct DoubleConditions
    : IHaveDefaultCondition<double>
    , IHaveEqualWithPrecisionCondition<double>
    , IHaveRangeCondition<double>
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsDefault(double value) => value == 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsEqual(double left, double right, double tolerance)
        => Math.Abs(left - right) < tolerance;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsGreater(double left, double right) => left > right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsGreaterOrEqual(double left, double right) => left >= right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsLess(double left, double right) => left < right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsLessOrEqual(double left, double right) => left <= right;
}