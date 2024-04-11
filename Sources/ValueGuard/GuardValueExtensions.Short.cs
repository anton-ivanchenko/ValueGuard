using ValueGuard.Internal;
using ValueGuard.Internal.Conditions.Numbers;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<short> IsEqual(this in GuardValue<short> guard, short value)
        => ref guard.IsEqual<short, ShortConditions>(value);

    public static ref readonly GuardValue<short> IsNotEqual(this in GuardValue<short> guard, short value)
        => ref guard.IsNotEqual<short, ShortConditions>(value);

    public static ref readonly GuardValue<short> IsDefault(this in GuardValue<short> guard)
        => ref guard.IsDefault<short, ShortConditions>();

    public static ref readonly GuardValue<short> IsNotDefault(this in GuardValue<short> guard)
        => ref guard.IsNotDefault<short, ShortConditions>();

    public static ref readonly GuardValue<short> IsPositive(this in GuardValue<short> guard)
        => ref guard.IsGreater<short, ShortConditions>(default);

    public static ref readonly GuardValue<short> IsNegative(this in GuardValue<short> guard)
        => ref guard.IsLess<short, ShortConditions>(default);

    public static ref readonly GuardValue<short> IsGreater(this in GuardValue<short> guard, short value)
        => ref guard.IsGreater<short, ShortConditions>(value);

    public static ref readonly GuardValue<short> IsGreaterOrEqual(this in GuardValue<short> guard, short value)
        => ref guard.IsGreaterOrEqual<short, ShortConditions>(value);

    public static ref readonly GuardValue<short> IsLess(this in GuardValue<short> guard, short value)
        => ref guard.IsLess<short, ShortConditions>(value);

    public static ref readonly GuardValue<short> IsLessOrEqual(this in GuardValue<short> guard, short value)
        => ref guard.IsLessOrEqual<short, ShortConditions>(value);

    public static ref readonly GuardValue<short> InRange(
        this in GuardValue<short> guard,
        short min,
        short max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref guard.InRange<short, ShortConditions>(min, max, excludeMin, excludeMax);
}