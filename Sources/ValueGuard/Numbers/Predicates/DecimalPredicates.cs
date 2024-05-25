using System.Runtime.CompilerServices;
using ValueGuard._Internal.Abstractions;

namespace ValueGuard.Predicates;

internal readonly struct DecimalPredicates
    : IDefaultPredicate<decimal>
    , IEqualWithTolerancePredicate<decimal, decimal>
    , IRangePredicate<decimal>
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsDefault(decimal value) => value == 0M;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsValidTolerance(decimal tolerance) => tolerance >= 0M;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsEqual(decimal left, decimal right, decimal tolerance)
        => (left > right ? left - right : right - left) < tolerance;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsGreater(decimal left, decimal right) => left > right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsGreaterOrEqual(decimal left, decimal right) => left >= right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsLess(decimal left, decimal right) => left < right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsLessOrEqual(decimal left, decimal right) => left <= right;
}