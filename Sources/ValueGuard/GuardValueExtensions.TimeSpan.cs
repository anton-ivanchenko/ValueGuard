using ValueGuard.Internal;
using ValueGuard.Internal.Conditions;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<TimeSpan> IsEqual(this in GuardValue<TimeSpan> guard, TimeSpan value)
        => ref guard.IsEqual<TimeSpan, TimeSpanConditions>(value);

    public static ref readonly GuardValue<TimeSpan> IsEqual(
        this in GuardValue<TimeSpan> guard,
        TimeSpan value,
        TimeSpan tolerance)
        => ref guard.IsEqual<TimeSpan, TimeSpan, TimeSpanConditions>(value, tolerance);

    public static ref readonly GuardValue<TimeSpan> IsNotEqual(this in GuardValue<TimeSpan> guard, TimeSpan value)
        => ref guard.IsNotEqual<TimeSpan, TimeSpanConditions>(value);

    public static ref readonly GuardValue<TimeSpan> IsNotEqual(
        this in GuardValue<TimeSpan> guard,
        TimeSpan value,
        TimeSpan tolerance)
        => ref guard.IsNotEqual<TimeSpan, TimeSpan, TimeSpanConditions>(value, tolerance);

    public static ref readonly GuardValue<TimeSpan> IsDefault(this in GuardValue<TimeSpan> guard)
        => ref guard.IsDefault<TimeSpan, TimeSpanConditions>();

    public static ref readonly GuardValue<TimeSpan> IsNotDefault(this in GuardValue<TimeSpan> guard)
        => ref guard.IsNotDefault<TimeSpan, TimeSpanConditions>();

    public static ref readonly GuardValue<TimeSpan> IsGreater(this in GuardValue<TimeSpan> guard, TimeSpan value)
        => ref guard.IsGreater<TimeSpan, TimeSpanConditions>(value);

    public static ref readonly GuardValue<TimeSpan> IsGreaterOrEqual(this in GuardValue<TimeSpan> guard, TimeSpan value)
        => ref guard.IsGreaterOrEqual<TimeSpan, TimeSpanConditions>(value);

    public static ref readonly GuardValue<TimeSpan> IsLess(this in GuardValue<TimeSpan> guard, TimeSpan value)
        => ref guard.IsLess<TimeSpan, TimeSpanConditions>(value);

    public static ref readonly GuardValue<TimeSpan> IsLessOrEqual(this in GuardValue<TimeSpan> guard, TimeSpan value)
        => ref guard.IsLessOrEqual<TimeSpan, TimeSpanConditions>(value);

    public static ref readonly GuardValue<TimeSpan> InRange(
        this in GuardValue<TimeSpan> guard,
        TimeSpan min,
        TimeSpan max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref guard.InRange<TimeSpan, TimeSpanConditions>(min, max, excludeMin, excludeMax);
}