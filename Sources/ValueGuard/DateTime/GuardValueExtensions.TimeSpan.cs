using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<TimeSpan> IsEqual(this in GuardValue<TimeSpan> guard, TimeSpan value)
        => ref GenericImplementation.IsEqual<TimeSpan, TimeSpanPredicates>(guard, value);

    public static ref readonly GuardValue<TimeSpan> IsEqual(
        this in GuardValue<TimeSpan> guard,
        TimeSpan value,
        TimeSpan tolerance)
        => ref GenericImplementation.IsEqual<TimeSpan, TimeSpan, TimeSpanPredicates>(guard, value, tolerance);

    public static ref readonly GuardValue<TimeSpan> NotEqual(this in GuardValue<TimeSpan> guard, TimeSpan value)
        => ref GenericImplementation.NotEqual<TimeSpan, TimeSpanPredicates>(guard, value);

    public static ref readonly GuardValue<TimeSpan> NotEqual(
        this in GuardValue<TimeSpan> guard,
        TimeSpan value,
        TimeSpan tolerance)
        => ref GenericImplementation.NotEqual<TimeSpan, TimeSpan, TimeSpanPredicates>(guard, value, tolerance);

    public static ref readonly GuardValue<TimeSpan> IsDefault(this in GuardValue<TimeSpan> guard)
        => ref GenericImplementation.IsDefault<TimeSpan, TimeSpanPredicates>(guard);

    public static ref readonly GuardValue<TimeSpan> NotDefault(this in GuardValue<TimeSpan> guard)
        => ref GenericImplementation.NotDefault<TimeSpan, TimeSpanPredicates>(guard);

    public static ref readonly GuardValue<TimeSpan> IsGreater(this in GuardValue<TimeSpan> guard, TimeSpan value)
        => ref GenericImplementation.IsGreater<TimeSpan, TimeSpanPredicates>(guard, value);

    public static ref readonly GuardValue<TimeSpan> IsGreaterOrEqual(this in GuardValue<TimeSpan> guard, TimeSpan value)
        => ref GenericImplementation.IsGreaterOrEqual<TimeSpan, TimeSpanPredicates>(guard, value);

    public static ref readonly GuardValue<TimeSpan> IsLess(this in GuardValue<TimeSpan> guard, TimeSpan value)
        => ref GenericImplementation.IsLess<TimeSpan, TimeSpanPredicates>(guard, value);

    public static ref readonly GuardValue<TimeSpan> IsLessOrEqual(this in GuardValue<TimeSpan> guard, TimeSpan value)
        => ref GenericImplementation.IsLessOrEqual<TimeSpan, TimeSpanPredicates>(guard, value);

    public static ref readonly GuardValue<TimeSpan> InRange(
        this in GuardValue<TimeSpan> guard,
        TimeSpan min,
        TimeSpan max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref GenericImplementation.InRange<TimeSpan, TimeSpanPredicates>(guard, min, max, excludeMin, excludeMax);
}