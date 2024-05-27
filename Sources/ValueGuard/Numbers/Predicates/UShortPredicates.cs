using System.Runtime.CompilerServices;
using ValueGuard._Internal.Abstractions;

namespace ValueGuard.Predicates;

internal readonly struct UShortPredicates
    : IDefaultPredicate<ushort>
    , IEqualPredicate<ushort>
    , IRangePredicate<ushort>
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