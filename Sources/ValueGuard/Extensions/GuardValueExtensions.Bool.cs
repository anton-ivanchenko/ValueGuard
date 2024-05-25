using ValueGuard.Internal;
using ValueGuard.Internal.Conditions;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<bool> Equal(this in GuardValue<bool> guard, bool value)
        => ref guard.Equal<bool, BoolConditions>(value);

    public static ref readonly GuardValue<bool> NotEqual(this in GuardValue<bool> guard, bool value)
        => ref guard.NotEqual<bool, BoolConditions>(value);

    public static ref readonly GuardValue<bool> IsTrue(this in GuardValue<bool> guard)
        => ref guard.Equal<bool, BoolConditions>(true);

    public static ref readonly GuardValue<bool> IsFalse(this in GuardValue<bool> guard)
        => ref guard.Equal<bool, BoolConditions>(false);
}