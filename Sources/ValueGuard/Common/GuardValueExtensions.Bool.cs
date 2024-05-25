using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<bool> IsEqual(this in GuardValue<bool> guard, bool value)
        => ref GenericImplementation.IsEqual<bool, BoolPredicate>(guard, value);

    public static ref readonly GuardValue<bool> NotEqual(this in GuardValue<bool> guard, bool value)
        => ref GenericImplementation.NotEqual<bool, BoolPredicate>(guard, value);

    public static ref readonly GuardValue<bool> IsTrue(this in GuardValue<bool> guard)
        => ref GenericImplementation.IsEqual<bool, BoolPredicate>(guard, true);

    public static ref readonly GuardValue<bool> IsFalse(this in GuardValue<bool> guard)
        => ref GenericImplementation.IsEqual<bool, BoolPredicate>(guard, false);
}