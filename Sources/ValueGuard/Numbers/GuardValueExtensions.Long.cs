using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardContext<long> EqualTo(this in GuardContext<long> guard, long value)
        => ref GenericImplementation.EqualTo<long, LongPredicates>(guard, value);

    public static ref readonly GuardContext<long> NotEqualTo(this in GuardContext<long> guard, long value)
        => ref GenericImplementation.NotEqualTo<long, LongPredicates>(guard, value);

    public static ref readonly GuardContext<long> IsDefault(this in GuardContext<long> guard)
        => ref GenericImplementation.IsDefault<long, LongPredicates>(guard);

    public static ref readonly GuardContext<long> NotDefault(this in GuardContext<long> guard)
        => ref GenericImplementation.NotDefault<long, LongPredicates>(guard);

    public static ref readonly GuardContext<long> IsPositive(this in GuardContext<long> guard)
        => ref GenericImplementation.GreaterThan<long, LongPredicates>(guard, default);

    public static ref readonly GuardContext<long> IsNegative(this in GuardContext<long> guard)
        => ref GenericImplementation.LessThan<long, LongPredicates>(guard, default);

    public static ref readonly GuardContext<long> GreaterThan(this in GuardContext<long> guard, long value)
        => ref GenericImplementation.GreaterThan<long, LongPredicates>(guard, value);

    public static ref readonly GuardContext<long> GreaterThanOrEqualTo(this in GuardContext<long> guard, long value)
        => ref GenericImplementation.GreaterThanOrEqualTo<long, LongPredicates>(guard, value);

    public static ref readonly GuardContext<long> LessThan(this in GuardContext<long> guard, long value)
        => ref GenericImplementation.LessThan<long, LongPredicates>(guard, value);

    public static ref readonly GuardContext<long> LessThanOrEqualTo(this in GuardContext<long> guard, long value)
        => ref GenericImplementation.LessThanOrEqualTo<long, LongPredicates>(guard, value);

    public static ref readonly GuardContext<long> InRange(
        this in GuardContext<long> guard,
        long min,
        long max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref GenericImplementation.InRange<long, LongPredicates>(guard, min, max, excludeMin, excludeMax);
}