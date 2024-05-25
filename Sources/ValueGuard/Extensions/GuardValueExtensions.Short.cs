using ValueGuard.Internal;
using ValueGuard.Internal.Conditions.Numbers;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<short> Equal(this in GuardValue<short> guard, short value)
        => ref guard.Equal<short, ShortConditions>(value);

    public static ref readonly GuardValue<short> NotEqual(this in GuardValue<short> guard, short value)
        => ref guard.NotEqual<short, ShortConditions>(value);

    public static ref readonly GuardValue<short> IsDefault(this in GuardValue<short> guard)
        => ref guard.IsDefault<short, ShortConditions>();

    public static ref readonly GuardValue<short> IsNotDefault(this in GuardValue<short> guard)
        => ref guard.IsNotDefault<short, ShortConditions>();

    public static ref readonly GuardValue<short> IsPositive(this in GuardValue<short> guard)
        => ref guard.Greater<short, ShortConditions>(default);

    public static ref readonly GuardValue<short> IsNegative(this in GuardValue<short> guard)
        => ref guard.Less<short, ShortConditions>(default);

    public static ref readonly GuardValue<short> Greater(this in GuardValue<short> guard, short value)
        => ref guard.Greater<short, ShortConditions>(value);

    public static ref readonly GuardValue<short> GreaterOrEqual(this in GuardValue<short> guard, short value)
        => ref guard.GreaterOrEqual<short, ShortConditions>(value);

    public static ref readonly GuardValue<short> Less(this in GuardValue<short> guard, short value)
        => ref guard.Less<short, ShortConditions>(value);

    public static ref readonly GuardValue<short> LessOrEqual(this in GuardValue<short> guard, short value)
        => ref guard.LessOrEqual<short, ShortConditions>(value);

    public static ref readonly GuardValue<short> InRange(
        this in GuardValue<short> guard,
        short min,
        short max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref guard.InRange<short, ShortConditions>(min, max, excludeMin, excludeMax);
}