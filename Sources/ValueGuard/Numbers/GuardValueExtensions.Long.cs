using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<long> EqualTo(this in GuardValue<long> guard, long value)
        => ref GenericImplementation.EqualTo<long, LongPredicates>(guard, value);

    public static ref readonly GuardValue<long> NotEqualTo(this in GuardValue<long> guard, long value)
        => ref GenericImplementation.NotEqualTo<long, LongPredicates>(guard, value);

    public static ref readonly GuardValue<long> IsDefault(this in GuardValue<long> guard)
        => ref GenericImplementation.IsDefault<long, LongPredicates>(guard);

    public static ref readonly GuardValue<long> NotDefault(this in GuardValue<long> guard)
        => ref GenericImplementation.NotDefault<long, LongPredicates>(guard);

    public static ref readonly GuardValue<long> IsPositive(this in GuardValue<long> guard)
        => ref GenericImplementation.GreaterThan<long, LongPredicates>(guard, default);

    public static ref readonly GuardValue<long> IsNegative(this in GuardValue<long> guard)
        => ref GenericImplementation.LessThan<long, LongPredicates>(guard, default);

    public static ref readonly GuardValue<long> GreaterThan(this in GuardValue<long> guard, long value)
        => ref GenericImplementation.GreaterThan<long, LongPredicates>(guard, value);

    public static ref readonly GuardValue<long> GreaterThanOrEqualTo(this in GuardValue<long> guard, long value)
        => ref GenericImplementation.GreaterThanOrEqualTo<long, LongPredicates>(guard, value);

    public static ref readonly GuardValue<long> LessThan(this in GuardValue<long> guard, long value)
        => ref GenericImplementation.LessThan<long, LongPredicates>(guard, value);

    public static ref readonly GuardValue<long> LessThanOrEqualTo(this in GuardValue<long> guard, long value)
        => ref GenericImplementation.LessThanOrEqualTo<long, LongPredicates>(guard, value);

    public static ref readonly GuardValue<long> Between(
        this in GuardValue<long> guard,
        long min,
        long max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref GenericImplementation.Between<long, LongPredicates>(guard, min, max, excludeMin, excludeMax);
}