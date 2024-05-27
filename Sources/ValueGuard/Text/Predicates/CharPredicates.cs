using System.Runtime.CompilerServices;
using ValueGuard._Internal.Abstractions;

namespace ValueGuard.Predicates;

internal readonly struct CharPredicates : IEqualPredicate<char>
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsEqual(char left, char right) => left == right;
}