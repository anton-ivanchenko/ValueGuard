using System.Runtime.CompilerServices;
using ValueGuard.Internal.Conditions.Abstractions;

namespace ValueGuard.Internal.Conditions;

internal readonly struct IntConditions
    : IHaveDefaultCondition<int>
    , IHaveEqualCondition<int>
    , IHaveRangeCondition<int>
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsDefault(int value) => value == 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsEqual(int left, int right) => left == right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsGreater(int left, int right) => left > right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsGreaterOrEqual(int left, int right) => left >= right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsLess(int left, int right) => left < right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsLessOrEqual(int left, int right) => left <= right;
}