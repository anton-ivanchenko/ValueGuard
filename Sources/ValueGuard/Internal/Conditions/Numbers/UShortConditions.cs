using System.Runtime.CompilerServices;
using ValueGuard.Internal.Conditions.Abstractions;

namespace ValueGuard.Internal.Conditions.Numbers;

internal readonly struct UShortConditions
    : IHaveDefaultCondition<ushort>
    , IHaveEqualCondition<ushort>
    , IHaveRangeCondition<ushort>
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsDefault(ushort value) => value == 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsEqual(ushort left, ushort right) => left == right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsGreater(ushort left, ushort right) => left > right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsGreaterOrEqual(ushort left, ushort right) => left >= right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsLess(ushort left, ushort right) => left < right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsLessOrEqual(ushort left, ushort right) => left <= right;
}