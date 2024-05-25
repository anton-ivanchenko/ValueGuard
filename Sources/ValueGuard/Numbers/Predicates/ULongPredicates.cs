using System.Runtime.CompilerServices;
using ValueGuard._Internal.Abstractions;

namespace ValueGuard.Predicates;

internal readonly struct ULongPredicates
    : IDefaultPredicate<ulong>
    , IEqualPredicate<ulong>
    , IRangePredicate<ulong>
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsDefault(ulong value) => value == 0UL;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsEqual(ulong left, ulong right) => left == right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsGreater(ulong left, ulong right) => left > right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsGreaterOrEqual(ulong left, ulong right) => left >= right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsLess(ulong left, ulong right) => left < right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsLessOrEqual(ulong left, ulong right) => left <= right;
}