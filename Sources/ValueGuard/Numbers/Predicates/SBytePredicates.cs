using System.Runtime.CompilerServices;
using ValueGuard._Internal.Abstractions;

namespace ValueGuard.Predicates;

internal readonly struct SBytePredicates
    : IDefaultPredicate<sbyte>
    , IEqualPredicate<sbyte>
    , IRangePredicate<sbyte>
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