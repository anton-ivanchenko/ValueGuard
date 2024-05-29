using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardContext<bool> EqualTo(this in GuardContext<bool> guard, bool value)
        => ref GenericImplementation.EqualTo<bool, BoolPredicate>(guard, value);

    public static ref readonly GuardContext<bool> NotEqualTo(this in GuardContext<bool> guard, bool value)
        => ref GenericImplementation.NotEqualTo<bool, BoolPredicate>(guard, value);

    public static ref readonly GuardContext<bool> IsTrue(this in GuardContext<bool> guard)
        => ref GenericImplementation.EqualTo<bool, BoolPredicate>(guard, true);

    public static ref readonly GuardContext<bool> IsFalse(this in GuardContext<bool> guard)
        => ref GenericImplementation.EqualTo<bool, BoolPredicate>(guard, false);
}