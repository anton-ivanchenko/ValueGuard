using ValueGuard.Internal;
using ValueGuard.Internal.Conditions;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<DateTime> IsEqual(this in GuardValue<DateTime> guard, DateTime value)
        => ref guard.IsEqual<DateTime, DateTimeConditions>(value);

    public static ref readonly GuardValue<DateTime> IsEqual(
        this in GuardValue<DateTime> guard,
        DateTime value,
        TimeSpan tolerance)
        => ref guard.IsEqual<DateTime, TimeSpan, DateTimeConditions>(value, tolerance);

    public static ref readonly GuardValue<DateTime> IsNotEqual(this in GuardValue<DateTime> guard, DateTime value)
        => ref guard.IsNotEqual<DateTime, DateTimeConditions>(value);

    public static ref readonly GuardValue<DateTime> IsNotEqual(
        this in GuardValue<DateTime> guard,
        DateTime value,
        TimeSpan tolerance)
        => ref guard.IsNotEqual<DateTime, TimeSpan, DateTimeConditions>(value, tolerance);

    public static ref readonly GuardValue<DateTime> IsDefault(this in GuardValue<DateTime> guard)
        => ref guard.IsDefault<DateTime, DateTimeConditions>();

    public static ref readonly GuardValue<DateTime> IsNotDefault(this in GuardValue<DateTime> guard)
        => ref guard.IsNotDefault<DateTime, DateTimeConditions>();

    public static ref readonly GuardValue<DateTime> IsGreater(this in GuardValue<DateTime> guard, DateTime value)
        => ref guard.IsGreater<DateTime, DateTimeConditions>(value);

    public static ref readonly GuardValue<DateTime> IsGreaterOrEqual(this in GuardValue<DateTime> guard, DateTime value)
        => ref guard.IsGreaterOrEqual<DateTime, DateTimeConditions>(value);

    public static ref readonly GuardValue<DateTime> IsLess(this in GuardValue<DateTime> guard, DateTime value)
        => ref guard.IsLess<DateTime, DateTimeConditions>(value);

    public static ref readonly GuardValue<DateTime> IsLessOrEqual(this in GuardValue<DateTime> guard, DateTime value)
        => ref guard.IsLessOrEqual<DateTime, DateTimeConditions>(value);

    public static ref readonly GuardValue<DateTime> InRange(
        this in GuardValue<DateTime> guard,
        DateTime min,
        DateTime max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref guard.InRange<DateTime, DateTimeConditions>(min, max, excludeMin, excludeMax);
}