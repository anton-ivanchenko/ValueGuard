using System.Runtime.CompilerServices;
using ValueGuard.Internal.Conditions.Abstractions;

namespace ValueGuard.Internal.Conditions.Numbers;

internal readonly struct FloatConditions
    : IHaveDefaultCondition<float>
    , IHaveEqualWithToleranceCondition<float, float>
    , IHaveRangeCondition<float>
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsDefault(float value) => value == 0F;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsValidTolerance(float tolerance) => tolerance >= 0F;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsEqual(float left, float right, float tolerance)
        => Math.Abs(left - right) < tolerance;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsGreater(float left, float right) => left > right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsGreaterOrEqual(float left, float right) => left >= right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsLess(float left, float right) => left < right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsLessOrEqual(float left, float right) => left <= right;
}