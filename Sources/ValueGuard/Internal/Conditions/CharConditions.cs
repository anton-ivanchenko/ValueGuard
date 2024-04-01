using System.Runtime.CompilerServices;
using ValueGuard.Internal.Conditions.Abstractions;

namespace ValueGuard.Internal.Conditions;

internal readonly struct CharConditions : IHaveEqualCondition<char>
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsEqual(char left, char right) => left == right;
}