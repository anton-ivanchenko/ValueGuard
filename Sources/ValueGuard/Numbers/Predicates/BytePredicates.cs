using System.Runtime.CompilerServices;
using ValueGuard._Internal.Abstractions;

namespace ValueGuard.Predicates;

internal readonly struct BytePredicates
    : IDefaultPredicate<byte>
    , IEqualPredicate<byte>
    , IRangePredicate<byte>
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsDefault(byte value) => value == 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsEqual(byte left, byte right) => left == right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsGreater(byte left, byte right) => left > right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsGreaterOrEqual(byte left, byte right) => left >= right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsLess(byte left, byte right) => left < right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsLessOrEqual(byte left, byte right) => left <= right;
}