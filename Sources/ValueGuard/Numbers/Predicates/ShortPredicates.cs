using System.Runtime.CompilerServices;
using ValueGuard._Internal.Abstractions;

namespace ValueGuard.Predicates;

internal readonly struct ShortPredicates
    : IDefaultPredicate<short>
    , IEqualPredicate<short>
    , IRangePredicate<short>
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsDefault(short value) => value == 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsEqual(short left, short right) => left == right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsGreater(short left, short right) => left > right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsGreaterOrEqual(short left, short right) => left >= right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsLess(short left, short right) => left < right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsLessOrEqual(short left, short right) => left <= right;
}