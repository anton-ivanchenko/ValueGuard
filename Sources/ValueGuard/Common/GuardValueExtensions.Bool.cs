using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<bool> EqualTo(this in GuardValue<bool> guard, bool value)
        => ref GenericImplementation.EqualTo<bool, BoolPredicate>(guard, value);

    public static ref readonly GuardValue<bool> NotEqualTo(this in GuardValue<bool> guard, bool value)
        => ref GenericImplementation.NotEqualTo<bool, BoolPredicate>(guard, value);

    public static ref readonly GuardValue<bool> IsTrue(this in GuardValue<bool> guard)
        => ref GenericImplementation.EqualTo<bool, BoolPredicate>(guard, true);

    public static ref readonly GuardValue<bool> IsFalse(this in GuardValue<bool> guard)
        => ref GenericImplementation.EqualTo<bool, BoolPredicate>(guard, false);
}