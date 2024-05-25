using System.Runtime.CompilerServices;
using ValueGuard._Internal.Abstractions;

namespace ValueGuard.Predicates;

internal readonly struct FloatPredicates
    : IDefaultPredicate<float>
    , IEqualWithTolerancePredicate<float, float>
    , IRangePredicate<float>
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsDefault(float value) => value == 0F;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsValidTolerance(float tolerance) => tolerance >= 0F;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsEqual(float left, float right, float tolerance)
        => (left > right ? left - right : right - left) < tolerance;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsGreater(float left, float right) => left > right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsGreaterOrEqual(float left, float right) => left >= right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsLess(float left, float right) => left < right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsLessOrEqual(float left, float right) => left <= right;
}