using ValueGuard.Internal;
using ValueGuard.Internal.Conditions.Numbers;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<long> IsEqual(this in GuardValue<long> guard, long value)
        => ref guard.IsEqual<long, LongConditions>(value);

    public static ref readonly GuardValue<long> IsNotEqual(this in GuardValue<long> guard, long value)
        => ref guard.IsNotEqual<long, LongConditions>(value);

    public static ref readonly GuardValue<long> IsDefault(this in GuardValue<long> guard)
        => ref guard.IsDefault<long, LongConditions>();

    public static ref readonly GuardValue<long> IsNotDefault(this in GuardValue<long> guard)
        => ref guard.IsNotDefault<long, LongConditions>();

    public static ref readonly GuardValue<long> IsPositive(this in GuardValue<long> guard)
        => ref guard.IsGreater<long, LongConditions>(default);

    public static ref readonly GuardValue<long> IsNegative(this in GuardValue<long> guard)
        => ref guard.IsLess<long, LongConditions>(default);

    public static ref readonly GuardValue<long> IsGreater(this in GuardValue<long> guard, long value)
        => ref guard.IsGreater<long, LongConditions>(value);

    public static ref readonly GuardValue<long> IsGreaterOrEqual(this in GuardValue<long> guard, long value)
        => ref guard.IsGreaterOrEqual<long, LongConditions>(value);

    public static ref readonly GuardValue<long> IsLess(this in GuardValue<long> guard, long value)
        => ref guard.IsLess<long, LongConditions>(value);

    public static ref readonly GuardValue<long> IsLessOrEqual(this in GuardValue<long> guard, long value)
        => ref guard.IsLessOrEqual<long, LongConditions>(value);

    public static ref readonly GuardValue<long> InRange(
        this in GuardValue<long> guard,
        long min,
        long max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref guard.InRange<long, LongConditions>(min, max, excludeMin, excludeMax);
}