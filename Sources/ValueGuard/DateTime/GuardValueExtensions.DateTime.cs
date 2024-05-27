using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<DateTime> IsEqual(this in GuardValue<DateTime> guard, DateTime value)
        => ref GenericImplementation.IsEqual<DateTime, DateTimePredicates>(guard, value);

    public static ref readonly GuardValue<DateTime> IsEqual(
        this in GuardValue<DateTime> guard,
        DateTime value,
        TimeSpan tolerance)
        => ref GenericImplementation.IsEqual<DateTime, TimeSpan, DateTimePredicates>(guard, value, tolerance);

    public static ref readonly GuardValue<DateTime> NotEqual(this in GuardValue<DateTime> guard, DateTime value)
        => ref GenericImplementation.NotEqual<DateTime, DateTimePredicates>(guard, value);

    public static ref readonly GuardValue<DateTime> NotEqual(
        this in GuardValue<DateTime> guard,
        DateTime value,
        TimeSpan tolerance)
        => ref GenericImplementation.NotEqual<DateTime, TimeSpan, DateTimePredicates>(guard, value, tolerance);

    public static ref readonly GuardValue<DateTime> IsDefault(this in GuardValue<DateTime> guard)
        => ref GenericImplementation.IsDefault<DateTime, DateTimePredicates>(guard);

    public static ref readonly GuardValue<DateTime> NotDefault(this in GuardValue<DateTime> guard)
        => ref GenericImplementation.NotDefault<DateTime, DateTimePredicates>(guard);

    public static ref readonly GuardValue<DateTime> IsGreater(this in GuardValue<DateTime> guard, DateTime value)
        => ref GenericImplementation.IsGreater<DateTime, DateTimePredicates>(guard, value);

    public static ref readonly GuardValue<DateTime> IsGreaterOrEqual(this in GuardValue<DateTime> guard, DateTime value)
        => ref GenericImplementation.IsGreaterOrEqual<DateTime, DateTimePredicates>(guard, value);

    public static ref readonly GuardValue<DateTime> IsLess(this in GuardValue<DateTime> guard, DateTime value)
        => ref GenericImplementation.IsLess<DateTime, DateTimePredicates>(guard, value);

    public static ref readonly GuardValue<DateTime> IsLessOrEqual(this in GuardValue<DateTime> guard, DateTime value)
        => ref GenericImplementation.IsLessOrEqual<DateTime, DateTimePredicates>(guard, value);

    public static ref readonly GuardValue<DateTime> InRange(
        this in GuardValue<DateTime> guard,
        DateTime min,
        DateTime max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref GenericImplementation.InRange<DateTime, DateTimePredicates>(guard, min, max, excludeMin, excludeMax);
}