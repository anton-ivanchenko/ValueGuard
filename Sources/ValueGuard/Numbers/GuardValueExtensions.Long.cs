using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<long> IsEqual(this in GuardValue<long> guard, long value)
        => ref GenericImplementation.IsEqual<long, LongPredicates>(guard, value);

    public static ref readonly GuardValue<long> NotEqual(this in GuardValue<long> guard, long value)
        => ref GenericImplementation.NotEqual<long, LongPredicates>(guard, value);

    public static ref readonly GuardValue<long> IsDefault(this in GuardValue<long> guard)
        => ref GenericImplementation.IsDefault<long, LongPredicates>(guard);

    public static ref readonly GuardValue<long> NotDefault(this in GuardValue<long> guard)
        => ref GenericImplementation.NotDefault<long, LongPredicates>(guard);

    public static ref readonly GuardValue<long> IsPositive(this in GuardValue<long> guard)
        => ref GenericImplementation.IsGreater<long, LongPredicates>(guard, default);

    public static ref readonly GuardValue<long> IsNegative(this in GuardValue<long> guard)
        => ref GenericImplementation.IsLess<long, LongPredicates>(guard, default);

    public static ref readonly GuardValue<long> IsGreater(this in GuardValue<long> guard, long value)
        => ref GenericImplementation.IsGreater<long, LongPredicates>(guard, value);

    public static ref readonly GuardValue<long> IsGreaterOrEqual(this in GuardValue<long> guard, long value)
        => ref GenericImplementation.IsGreaterOrEqual<long, LongPredicates>(guard, value);

    public static ref readonly GuardValue<long> IsLess(this in GuardValue<long> guard, long value)
        => ref GenericImplementation.IsLess<long, LongPredicates>(guard, value);

    public static ref readonly GuardValue<long> IsLessOrEqual(this in GuardValue<long> guard, long value)
        => ref GenericImplementation.IsLessOrEqual<long, LongPredicates>(guard, value);

    public static ref readonly GuardValue<long> InRange(
        this in GuardValue<long> guard,
        long min,
        long max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref GenericImplementation.InRange<long, LongPredicates>(guard, min, max, excludeMin, excludeMax);
}