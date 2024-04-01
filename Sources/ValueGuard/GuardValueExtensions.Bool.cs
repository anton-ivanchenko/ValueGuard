using ValueGuard.Internal;
using ValueGuard.Internal.Conditions;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<bool> IsEqual(this in GuardValue<bool> guard, bool value)
        => ref guard.IsEqual<bool, BoolConditions>(value);

    public static ref readonly GuardValue<bool> IsTrue(this in GuardValue<bool> guard)
    {
        if (!guard.Value)
        {
            guard.ThrowException("The value must be \"true\"");
        }

        return ref guard;
    }

    public static ref readonly GuardValue<bool> IsFalse(this in GuardValue<bool> guard)
    {
        if (guard.Value)
        {
            guard.ThrowException("The value must be \"false\"");
        }

        return ref guard;
    }
}