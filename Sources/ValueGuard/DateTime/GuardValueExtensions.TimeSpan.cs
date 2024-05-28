using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<TimeSpan> EqualTo(this in GuardValue<TimeSpan> guard, TimeSpan value)
        => ref GenericImplementation.EqualTo<TimeSpan, TimeSpanPredicates>(guard, value);

    public static ref readonly GuardValue<TimeSpan> EqualTo(
        this in GuardValue<TimeSpan> guard,
        TimeSpan value,
        TimeSpan tolerance)
        => ref GenericImplementation.EqualTo<TimeSpan, TimeSpan, TimeSpanPredicates>(guard, value, tolerance);

    public static ref readonly GuardValue<TimeSpan> NotEqualTo(this in GuardValue<TimeSpan> guard, TimeSpan value)
        => ref GenericImplementation.NotEqualTo<TimeSpan, TimeSpanPredicates>(guard, value);

    public static ref readonly GuardValue<TimeSpan> NotEqualTo(
        this in GuardValue<TimeSpan> guard,
        TimeSpan value,
        TimeSpan tolerance)
        => ref GenericImplementation.NotEqualTo<TimeSpan, TimeSpan, TimeSpanPredicates>(guard, value, tolerance);

    public static ref readonly GuardValue<TimeSpan> IsDefault(this in GuardValue<TimeSpan> guard)
        => ref GenericImplementation.IsDefault<TimeSpan, TimeSpanPredicates>(guard);

    public static ref readonly GuardValue<TimeSpan> NotDefault(this in GuardValue<TimeSpan> guard)
        => ref GenericImplementation.NotDefault<TimeSpan, TimeSpanPredicates>(guard);

    public static ref readonly GuardValue<TimeSpan> GreaterThan(this in GuardValue<TimeSpan> guard, TimeSpan value)
        => ref GenericImplementation.GreaterThan<TimeSpan, TimeSpanPredicates>(guard, value);

    public static ref readonly GuardValue<TimeSpan> GreaterThanOrEqualTo(this in GuardValue<TimeSpan> guard, TimeSpan value)
        => ref GenericImplementation.GreaterThanOrEqualTo<TimeSpan, TimeSpanPredicates>(guard, value);

    public static ref readonly GuardValue<TimeSpan> LessThan(this in GuardValue<TimeSpan> guard, TimeSpan value)
        => ref GenericImplementation.LessThan<TimeSpan, TimeSpanPredicates>(guard, value);

    public static ref readonly GuardValue<TimeSpan> LessThanOrEqualTo(this in GuardValue<TimeSpan> guard, TimeSpan value)
        => ref GenericImplementation.LessThanOrEqualTo<TimeSpan, TimeSpanPredicates>(guard, value);

    public static ref readonly GuardValue<TimeSpan> InRange(
        this in GuardValue<TimeSpan> guard,
        TimeSpan min,
        TimeSpan max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref GenericImplementation.InRange<TimeSpan, TimeSpanPredicates>(guard, min, max, excludeMin, excludeMax);
}