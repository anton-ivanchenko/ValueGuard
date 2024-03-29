using ValueGuard.Internal;
using ValueGuard.Internal.Conditions;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<int> IsZero(this in GuardValue<int> guard)
        => ref guard.IsDefault<int, IntConditions>();

    public static ref readonly GuardValue<int> IsNotZero(this in GuardValue<int> guard)
        => ref guard.IsNotDefault<int, IntConditions>();

    public static ref readonly GuardValue<int> IsPositive(this in GuardValue<int> guard)
        => ref guard.IsGreater<int, IntConditions>(default);

    public static ref readonly GuardValue<int> IsNegative(this in GuardValue<int> guard)
        => ref guard.IsLess<int, IntConditions>(default);

    public static ref readonly GuardValue<int> IsGreater(this in GuardValue<int> guard, int value)
        => ref guard.IsGreater<int, IntConditions>(value);

    public static ref readonly GuardValue<int> IsGreaterOrEqual(this in GuardValue<int> guard, int value)
        => ref guard.IsGreaterOrEqual<int, IntConditions>(value);

    public static ref readonly GuardValue<int> IsLess(this in GuardValue<int> guard, int value)
        => ref guard.IsLess<int, IntConditions>(value);

    public static ref readonly GuardValue<int> IsLessOrEqual(this in GuardValue<int> guard, int value)
        => ref guard.IsLessOrEqual<int, IntConditions>(value);

    public static ref readonly GuardValue<int> InRange(this in GuardValue<int> guard, int min, int max, bool excludeMin = false, bool excludeMax = false)
        => ref guard.InRange<int, IntConditions>(min, max, excludeMin, excludeMax);
}