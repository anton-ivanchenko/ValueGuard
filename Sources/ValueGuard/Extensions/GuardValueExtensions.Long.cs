using ValueGuard.Internal;
using ValueGuard.Internal.Conditions.Numbers;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<long> Equal(this in GuardValue<long> guard, long value)
        => ref guard.Equal<long, LongConditions>(value);

    public static ref readonly GuardValue<long> NotEqual(this in GuardValue<long> guard, long value)
        => ref guard.NotEqual<long, LongConditions>(value);

    public static ref readonly GuardValue<long> IsDefault(this in GuardValue<long> guard)
        => ref guard.IsDefault<long, LongConditions>();

    public static ref readonly GuardValue<long> IsNotDefault(this in GuardValue<long> guard)
        => ref guard.IsNotDefault<long, LongConditions>();

    public static ref readonly GuardValue<long> IsPositive(this in GuardValue<long> guard)
        => ref guard.Greater<long, LongConditions>(default);

    public static ref readonly GuardValue<long> IsNegative(this in GuardValue<long> guard)
        => ref guard.Less<long, LongConditions>(default);

    public static ref readonly GuardValue<long> Greater(this in GuardValue<long> guard, long value)
        => ref guard.Greater<long, LongConditions>(value);

    public static ref readonly GuardValue<long> GreaterOrEqual(this in GuardValue<long> guard, long value)
        => ref guard.GreaterOrEqual<long, LongConditions>(value);

    public static ref readonly GuardValue<long> Less(this in GuardValue<long> guard, long value)
        => ref guard.Less<long, LongConditions>(value);

    public static ref readonly GuardValue<long> LessOrEqual(this in GuardValue<long> guard, long value)
        => ref guard.LessOrEqual<long, LongConditions>(value);

    public static ref readonly GuardValue<long> InRange(
        this in GuardValue<long> guard,
        long min,
        long max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref guard.InRange<long, LongConditions>(min, max, excludeMin, excludeMax);
}