using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardContext<int> EqualTo(this in GuardContext<int> guard, int value)
        => ref GenericImplementation.EqualTo<int, IntPredicates>(guard, value);

    public static ref readonly GuardContext<int> NotEqualTo(this in GuardContext<int> guard, int value)
        => ref GenericImplementation.NotEqualTo<int, IntPredicates>(guard, value);

    public static ref readonly GuardContext<int> IsDefault(this in GuardContext<int> guard)
        => ref GenericImplementation.IsDefault<int, IntPredicates>(guard);

    public static ref readonly GuardContext<int> NotDefault(this in GuardContext<int> guard)
        => ref GenericImplementation.NotDefault<int, IntPredicates>(guard);

    public static ref readonly GuardContext<int> IsPositive(this in GuardContext<int> guard)
        => ref GenericImplementation.GreaterThan<int, IntPredicates>(guard, default);

    public static ref readonly GuardContext<int> IsNegative(this in GuardContext<int> guard)
        => ref GenericImplementation.LessThan<int, IntPredicates>(guard, default);

    public static ref readonly GuardContext<int> GreaterThan(this in GuardContext<int> guard, int value)
        => ref GenericImplementation.GreaterThan<int, IntPredicates>(guard, value);

    public static ref readonly GuardContext<int> GreaterThanOrEqualTo(this in GuardContext<int> guard, int value)
        => ref GenericImplementation.GreaterThanOrEqualTo<int, IntPredicates>(guard, value);

    public static ref readonly GuardContext<int> LessThan(this in GuardContext<int> guard, int value)
        => ref GenericImplementation.LessThan<int, IntPredicates>(guard, value);

    public static ref readonly GuardContext<int> LessThanOrEqualTo(this in GuardContext<int> guard, int value)
        => ref GenericImplementation.LessThanOrEqualTo<int, IntPredicates>(guard, value);

    public static ref readonly GuardContext<int> InRange(
        this in GuardContext<int> guard,
        int min,
        int max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref GenericImplementation.InRange<int, IntPredicates>(guard, min, max, excludeMin, excludeMax);
}