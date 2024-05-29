using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardContext<DateTime> EqualTo(this in GuardContext<DateTime> guard, DateTime value)
        => ref GenericImplementation.EqualTo<DateTime, DateTimePredicates>(guard, value);

    public static ref readonly GuardContext<DateTime> EqualTo(
        this in GuardContext<DateTime> guard,
        DateTime value,
        TimeSpan tolerance)
        => ref GenericImplementation.EqualTo<DateTime, TimeSpan, DateTimePredicates>(guard, value, tolerance);

    public static ref readonly GuardContext<DateTime> NotEqualTo(this in GuardContext<DateTime> guard, DateTime value)
        => ref GenericImplementation.NotEqualTo<DateTime, DateTimePredicates>(guard, value);

    public static ref readonly GuardContext<DateTime> NotEqualTo(
        this in GuardContext<DateTime> guard,
        DateTime value,
        TimeSpan tolerance)
        => ref GenericImplementation.NotEqualTo<DateTime, TimeSpan, DateTimePredicates>(guard, value, tolerance);

    public static ref readonly GuardContext<DateTime> IsDefault(this in GuardContext<DateTime> guard)
        => ref GenericImplementation.IsDefault<DateTime, DateTimePredicates>(guard);

    public static ref readonly GuardContext<DateTime> NotDefault(this in GuardContext<DateTime> guard)
        => ref GenericImplementation.NotDefault<DateTime, DateTimePredicates>(guard);

    public static ref readonly GuardContext<DateTime> GreaterThan(this in GuardContext<DateTime> guard, DateTime value)
        => ref GenericImplementation.GreaterThan<DateTime, DateTimePredicates>(guard, value);

    public static ref readonly GuardContext<DateTime> GreaterThanOrEqualTo(this in GuardContext<DateTime> guard, DateTime value)
        => ref GenericImplementation.GreaterThanOrEqualTo<DateTime, DateTimePredicates>(guard, value);

    public static ref readonly GuardContext<DateTime> LessThan(this in GuardContext<DateTime> guard, DateTime value)
        => ref GenericImplementation.LessThan<DateTime, DateTimePredicates>(guard, value);

    public static ref readonly GuardContext<DateTime> LessThanOrEqualTo(this in GuardContext<DateTime> guard, DateTime value)
        => ref GenericImplementation.LessThanOrEqualTo<DateTime, DateTimePredicates>(guard, value);

    public static ref readonly GuardContext<DateTime> InRange(
        this in GuardContext<DateTime> guard,
        DateTime min,
        DateTime max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref GenericImplementation.InRange<DateTime, DateTimePredicates>(guard, min, max, excludeMin, excludeMax);
}