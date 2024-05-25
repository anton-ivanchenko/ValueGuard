using System.Runtime.CompilerServices;
using ValueGuard._Internal.Abstractions;

namespace ValueGuard.Predicates;

internal readonly struct DoublePredicates
    : IDefaultPredicate<double>
    , IEqualWithTolerancePredicate<double, double>
    , IRangePredicate<double>
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsDefault(double value) => value == 0D;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsValidTolerance(double tolerance) => tolerance >= 0D;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsEqual(double left, double right, double tolerance)
        => (left > right ? left - right : right - left) < tolerance;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsGreater(double left, double right) => left > right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsGreaterOrEqual(double left, double right) => left >= right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsLess(double left, double right) => left < right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsLessOrEqual(double left, double right) => left <= right;
}