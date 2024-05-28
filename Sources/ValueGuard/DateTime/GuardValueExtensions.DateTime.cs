using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<DateTime> EqualTo(this in GuardValue<DateTime> guard, DateTime value)
        => ref GenericImplementation.EqualTo<DateTime, DateTimePredicates>(guard, value);

    public static ref readonly GuardValue<DateTime> EqualTo(
        this in GuardValue<DateTime> guard,
        DateTime value,
        TimeSpan tolerance)
        => ref GenericImplementation.EqualTo<DateTime, TimeSpan, DateTimePredicates>(guard, value, tolerance);

    public static ref readonly GuardValue<DateTime> NotEqualTo(this in GuardValue<DateTime> guard, DateTime value)
        => ref GenericImplementation.NotEqualTo<DateTime, DateTimePredicates>(guard, value);

    public static ref readonly GuardValue<DateTime> NotEqualTo(
        this in GuardValue<DateTime> guard,
        DateTime value,
        TimeSpan tolerance)
        => ref GenericImplementation.NotEqualTo<DateTime, TimeSpan, DateTimePredicates>(guard, value, tolerance);

    public static ref readonly GuardValue<DateTime> IsDefault(this in GuardValue<DateTime> guard)
        => ref GenericImplementation.IsDefault<DateTime, DateTimePredicates>(guard);

    public static ref readonly GuardValue<DateTime> NotDefault(this in GuardValue<DateTime> guard)
        => ref GenericImplementation.NotDefault<DateTime, DateTimePredicates>(guard);

    public static ref readonly GuardValue<DateTime> GreaterThan(this in GuardValue<DateTime> guard, DateTime value)
        => ref GenericImplementation.GreaterThan<DateTime, DateTimePredicates>(guard, value);

    public static ref readonly GuardValue<DateTime> GreaterThanOrEqualTo(this in GuardValue<DateTime> guard, DateTime value)
        => ref GenericImplementation.GreaterThanOrEqualTo<DateTime, DateTimePredicates>(guard, value);

    public static ref readonly GuardValue<DateTime> LessThan(this in GuardValue<DateTime> guard, DateTime value)
        => ref GenericImplementation.LessThan<DateTime, DateTimePredicates>(guard, value);

    public static ref readonly GuardValue<DateTime> LessThanOrEqualTo(this in GuardValue<DateTime> guard, DateTime value)
        => ref GenericImplementation.LessThanOrEqualTo<DateTime, DateTimePredicates>(guard, value);

    public static ref readonly GuardValue<DateTime> InRange(
        this in GuardValue<DateTime> guard,
        DateTime min,
        DateTime max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref GenericImplementation.InRange<DateTime, DateTimePredicates>(guard, min, max, excludeMin, excludeMax);
}