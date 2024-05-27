using System.Runtime.CompilerServices;
using ValueGuard._Internal.Abstractions;

namespace ValueGuard.Predicates;

internal readonly struct UIntPredicates
    : IDefaultPredicate<uint>
    , IEqualPredicate<uint>
    , IRangePredicate<uint>
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsDefault(uint value) => value == 0U;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsEqual(uint left, uint right) => left == right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsGreater(uint left, uint right) => left > right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsGreaterOrEqual(uint left, uint right) => left >= right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsLess(uint left, uint right) => left < right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsLessOrEqual(uint left, uint right) => left <= right;
}