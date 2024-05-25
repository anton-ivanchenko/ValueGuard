using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<int> IsEqual(this in GuardValue<int> guard, int value)
        => ref GenericImplementation.IsEqual<int, IntPredicates>(guard, value);

    public static ref readonly GuardValue<int> NotEqual(this in GuardValue<int> guard, int value)
        => ref GenericImplementation.NotEqual<int, IntPredicates>(guard, value);

    public static ref readonly GuardValue<int> IsDefault(this in GuardValue<int> guard)
        => ref GenericImplementation.IsDefault<int, IntPredicates>(guard);

    public static ref readonly GuardValue<int> NotDefault(this in GuardValue<int> guard)
        => ref GenericImplementation.NotDefault<int, IntPredicates>(guard);

    public static ref readonly GuardValue<int> IsPositive(this in GuardValue<int> guard)
        => ref GenericImplementation.IsGreater<int, IntPredicates>(guard, default);

    public static ref readonly GuardValue<int> IsNegative(this in GuardValue<int> guard)
        => ref GenericImplementation.IsLess<int, IntPredicates>(guard, default);

    public static ref readonly GuardValue<int> IsGreater(this in GuardValue<int> guard, int value)
        => ref GenericImplementation.IsGreater<int, IntPredicates>(guard, value);

    public static ref readonly GuardValue<int> IsGreaterOrEqual(this in GuardValue<int> guard, int value)
        => ref GenericImplementation.IsGreaterOrEqual<int, IntPredicates>(guard, value);

    public static ref readonly GuardValue<int> IsLess(this in GuardValue<int> guard, int value)
        => ref GenericImplementation.IsLess<int, IntPredicates>(guard, value);

    public static ref readonly GuardValue<int> IsLessOrEqual(this in GuardValue<int> guard, int value)
        => ref GenericImplementation.IsLessOrEqual<int, IntPredicates>(guard, value);

    public static ref readonly GuardValue<int> InRange(
        this in GuardValue<int> guard,
        int min,
        int max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref GenericImplementation.InRange<int, IntPredicates>(guard, min, max, excludeMin, excludeMax);
}