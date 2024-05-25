using System.Runtime.CompilerServices;
using ValueGuard._Internal.Abstractions;

namespace ValueGuard.Predicates;

internal readonly struct BoolPredicate : IEqualPredicate<bool>
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsEqual(bool left, bool right) => left == right;
}