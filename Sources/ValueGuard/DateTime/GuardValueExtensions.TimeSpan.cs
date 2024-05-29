using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardContext<TimeSpan> EqualTo(this in GuardContext<TimeSpan> guard, TimeSpan value)
        => ref GenericImplementation.EqualTo<TimeSpan, TimeSpanPredicates>(guard, value);

    public static ref readonly GuardContext<TimeSpan> EqualTo(
        this in GuardContext<TimeSpan> guard,
        TimeSpan value,
        TimeSpan tolerance)
        => ref GenericImplementation.EqualTo<TimeSpan, TimeSpan, TimeSpanPredicates>(guard, value, tolerance);

    public static ref readonly GuardContext<TimeSpan> NotEqualTo(this in GuardContext<TimeSpan> guard, TimeSpan value)
        => ref GenericImplementation.NotEqualTo<TimeSpan, TimeSpanPredicates>(guard, value);

    public static ref readonly GuardContext<TimeSpan> NotEqualTo(
        this in GuardContext<TimeSpan> guard,
        TimeSpan value,
        TimeSpan tolerance)
        => ref GenericImplementation.NotEqualTo<TimeSpan, TimeSpan, TimeSpanPredicates>(guard, value, tolerance);

    public static ref readonly GuardContext<TimeSpan> IsDefault(this in GuardContext<TimeSpan> guard)
        => ref GenericImplementation.IsDefault<TimeSpan, TimeSpanPredicates>(guard);

    public static ref readonly GuardContext<TimeSpan> NotDefault(this in GuardContext<TimeSpan> guard)
        => ref GenericImplementation.NotDefault<TimeSpan, TimeSpanPredicates>(guard);

    public static ref readonly GuardContext<TimeSpan> GreaterThan(this in GuardContext<TimeSpan> guard, TimeSpan value)
        => ref GenericImplementation.GreaterThan<TimeSpan, TimeSpanPredicates>(guard, value);

    public static ref readonly GuardContext<TimeSpan> GreaterThanOrEqualTo(this in GuardContext<TimeSpan> guard, TimeSpan value)
        => ref GenericImplementation.GreaterThanOrEqualTo<TimeSpan, TimeSpanPredicates>(guard, value);

    public static ref readonly GuardContext<TimeSpan> LessThan(this in GuardContext<TimeSpan> guard, TimeSpan value)
        => ref GenericImplementation.LessThan<TimeSpan, TimeSpanPredicates>(guard, value);

    public static ref readonly GuardContext<TimeSpan> LessThanOrEqualTo(this in GuardContext<TimeSpan> guard, TimeSpan value)
        => ref GenericImplementation.LessThanOrEqualTo<TimeSpan, TimeSpanPredicates>(guard, value);

    public static ref readonly GuardContext<TimeSpan> InRange(
        this in GuardContext<TimeSpan> guard,
        TimeSpan min,
        TimeSpan max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref GenericImplementation.InRange<TimeSpan, TimeSpanPredicates>(guard, min, max, excludeMin, excludeMax);
}