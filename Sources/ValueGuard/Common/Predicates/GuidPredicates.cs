using System.Runtime.CompilerServices;
using ValueGuard._Internal.Abstractions;

namespace ValueGuard.Predicates;

public readonly struct GuidPredicates
    : IDefaultPredicate<Guid>
    , IEqualPredicate<Guid>
    , IRangePredicate<Guid>
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsDefault(Guid value) => value == default;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsEqual(Guid left, Guid right) => left == right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsGreater(Guid left, Guid right) => left.CompareTo(right) > 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsGreaterOrEqual(Guid left, Guid right) => left.CompareTo(right) >= 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsLess(Guid left, Guid right) => left.CompareTo(right) < 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsLessOrEqual(Guid left, Guid right) => left.CompareTo(right) <= 0;
}