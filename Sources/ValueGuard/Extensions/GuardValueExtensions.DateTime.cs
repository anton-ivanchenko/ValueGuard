using ValueGuard.Internal;
using ValueGuard.Internal.Conditions;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<DateTime> Equal(this in GuardValue<DateTime> guard, DateTime value)
        => ref guard.Equal<DateTime, DateTimeConditions>(value);

    public static ref readonly GuardValue<DateTime> Equal(
        this in GuardValue<DateTime> guard,
        DateTime value,
        TimeSpan tolerance)
        => ref guard.Equal<DateTime, TimeSpan, DateTimeConditions>(value, tolerance);

    public static ref readonly GuardValue<DateTime> NotEqual(this in GuardValue<DateTime> guard, DateTime value)
        => ref guard.NotEqual<DateTime, DateTimeConditions>(value);

    public static ref readonly GuardValue<DateTime> NotEqual(
        this in GuardValue<DateTime> guard,
        DateTime value,
        TimeSpan tolerance)
        => ref guard.NotEqual<DateTime, TimeSpan, DateTimeConditions>(value, tolerance);

    public static ref readonly GuardValue<DateTime> IsDefault(this in GuardValue<DateTime> guard)
        => ref guard.IsDefault<DateTime, DateTimeConditions>();

    public static ref readonly GuardValue<DateTime> IsNotDefault(this in GuardValue<DateTime> guard)
        => ref guard.IsNotDefault<DateTime, DateTimeConditions>();

    public static ref readonly GuardValue<DateTime> Greater(this in GuardValue<DateTime> guard, DateTime value)
        => ref guard.Greater<DateTime, DateTimeConditions>(value);

    public static ref readonly GuardValue<DateTime> GreaterOrEqual(this in GuardValue<DateTime> guard, DateTime value)
        => ref guard.GreaterOrEqual<DateTime, DateTimeConditions>(value);

    public static ref readonly GuardValue<DateTime> Less(this in GuardValue<DateTime> guard, DateTime value)
        => ref guard.Less<DateTime, DateTimeConditions>(value);

    public static ref readonly GuardValue<DateTime> LessOrEqual(this in GuardValue<DateTime> guard, DateTime value)
        => ref guard.LessOrEqual<DateTime, DateTimeConditions>(value);

    public static ref readonly GuardValue<DateTime> InRange(
        this in GuardValue<DateTime> guard,
        DateTime min,
        DateTime max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref guard.InRange<DateTime, DateTimeConditions>(min, max, excludeMin, excludeMax);
}