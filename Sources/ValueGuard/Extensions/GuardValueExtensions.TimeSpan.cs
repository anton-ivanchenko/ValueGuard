using ValueGuard.Internal;
using ValueGuard.Internal.Conditions;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<TimeSpan> Equal(this in GuardValue<TimeSpan> guard, TimeSpan value)
        => ref guard.Equal<TimeSpan, TimeSpanConditions>(value);

    public static ref readonly GuardValue<TimeSpan> Equal(
        this in GuardValue<TimeSpan> guard,
        TimeSpan value,
        TimeSpan tolerance)
        => ref guard.Equal<TimeSpan, TimeSpan, TimeSpanConditions>(value, tolerance);

    public static ref readonly GuardValue<TimeSpan> NotEqual(this in GuardValue<TimeSpan> guard, TimeSpan value)
        => ref guard.NotEqual<TimeSpan, TimeSpanConditions>(value);

    public static ref readonly GuardValue<TimeSpan> NotEqual(
        this in GuardValue<TimeSpan> guard,
        TimeSpan value,
        TimeSpan tolerance)
        => ref guard.NotEqual<TimeSpan, TimeSpan, TimeSpanConditions>(value, tolerance);

    public static ref readonly GuardValue<TimeSpan> IsDefault(this in GuardValue<TimeSpan> guard)
        => ref guard.IsDefault<TimeSpan, TimeSpanConditions>();

    public static ref readonly GuardValue<TimeSpan> IsNotDefault(this in GuardValue<TimeSpan> guard)
        => ref guard.IsNotDefault<TimeSpan, TimeSpanConditions>();

    public static ref readonly GuardValue<TimeSpan> Greater(this in GuardValue<TimeSpan> guard, TimeSpan value)
        => ref guard.Greater<TimeSpan, TimeSpanConditions>(value);

    public static ref readonly GuardValue<TimeSpan> GreaterOrEqual(this in GuardValue<TimeSpan> guard, TimeSpan value)
        => ref guard.GreaterOrEqual<TimeSpan, TimeSpanConditions>(value);

    public static ref readonly GuardValue<TimeSpan> Less(this in GuardValue<TimeSpan> guard, TimeSpan value)
        => ref guard.Less<TimeSpan, TimeSpanConditions>(value);

    public static ref readonly GuardValue<TimeSpan> LessOrEqual(this in GuardValue<TimeSpan> guard, TimeSpan value)
        => ref guard.LessOrEqual<TimeSpan, TimeSpanConditions>(value);

    public static ref readonly GuardValue<TimeSpan> InRange(
        this in GuardValue<TimeSpan> guard,
        TimeSpan min,
        TimeSpan max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref guard.InRange<TimeSpan, TimeSpanConditions>(min, max, excludeMin, excludeMax);
}