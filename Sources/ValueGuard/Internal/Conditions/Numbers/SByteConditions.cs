using System.Runtime.CompilerServices;
using ValueGuard.Internal.Conditions.Abstractions;

namespace ValueGuard.Internal.Conditions.Numbers;

internal readonly struct SByteConditions
    : IHaveDefaultCondition<sbyte>
    , IHaveEqualCondition<sbyte>
    , IHaveRangeCondition<sbyte>
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsDefault(sbyte value) => value == 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsEqual(sbyte left, sbyte right) => left == right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsGreater(sbyte left, sbyte right) => left > right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsGreaterOrEqual(sbyte left, sbyte right) => left >= right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsLess(sbyte left, sbyte right) => left < right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsLessOrEqual(sbyte left, sbyte right) => left <= right;
}