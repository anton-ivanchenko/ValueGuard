using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<int> EqualTo(this in GuardValue<int> guard, int value)
        => ref GenericImplementation.EqualTo<int, IntPredicates>(guard, value);

    public static ref readonly GuardValue<int> NotEqualTo(this in GuardValue<int> guard, int value)
        => ref GenericImplementation.NotEqualTo<int, IntPredicates>(guard, value);

    public static ref readonly GuardValue<int> IsDefault(this in GuardValue<int> guard)
        => ref GenericImplementation.IsDefault<int, IntPredicates>(guard);

    public static ref readonly GuardValue<int> NotDefault(this in GuardValue<int> guard)
        => ref GenericImplementation.NotDefault<int, IntPredicates>(guard);

    public static ref readonly GuardValue<int> IsPositive(this in GuardValue<int> guard)
        => ref GenericImplementation.GreaterThan<int, IntPredicates>(guard, default);

    public static ref readonly GuardValue<int> IsNegative(this in GuardValue<int> guard)
        => ref GenericImplementation.LessThan<int, IntPredicates>(guard, default);

    public static ref readonly GuardValue<int> GreaterThan(this in GuardValue<int> guard, int value)
        => ref GenericImplementation.GreaterThan<int, IntPredicates>(guard, value);

    public static ref readonly GuardValue<int> GreaterThanOrEqualTo(this in GuardValue<int> guard, int value)
        => ref GenericImplementation.GreaterThanOrEqualTo<int, IntPredicates>(guard, value);

    public static ref readonly GuardValue<int> LessThan(this in GuardValue<int> guard, int value)
        => ref GenericImplementation.LessThan<int, IntPredicates>(guard, value);

    public static ref readonly GuardValue<int> LessThanOrEqualTo(this in GuardValue<int> guard, int value)
        => ref GenericImplementation.LessThanOrEqualTo<int, IntPredicates>(guard, value);

    public static ref readonly GuardValue<int> InRange(
        this in GuardValue<int> guard,
        int min,
        int max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref GenericImplementation.InRange<int, IntPredicates>(guard, min, max, excludeMin, excludeMax);
}