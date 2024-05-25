using System.Runtime.CompilerServices;
using ValueGuard.Internal.Conditions.Abstractions;

namespace ValueGuard.Internal.Conditions.Numbers;

internal readonly struct DoubleConditions
    : IHaveDefaultCondition<double>
    , IHaveEqualWithToleranceCondition<double, double>
    , IHaveRangeCondition<double>
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsDefault(double value) => value == 0D;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsValidTolerance(double tolerance) => tolerance >= 0D;

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