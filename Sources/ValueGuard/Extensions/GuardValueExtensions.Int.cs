using ValueGuard.Internal;
using ValueGuard.Internal.Conditions.Numbers;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<int> Equal(this in GuardValue<int> guard, int value)
        => ref guard.Equal<int, IntConditions>(value);

    public static ref readonly GuardValue<int> NotEqual(this in GuardValue<int> guard, int value)
        => ref guard.NotEqual<int, IntConditions>(value);

    public static ref readonly GuardValue<int> IsDefault(this in GuardValue<int> guard)
        => ref guard.IsDefault<int, IntConditions>();

    public static ref readonly GuardValue<int> IsNotDefault(this in GuardValue<int> guard)
        => ref guard.IsNotDefault<int, IntConditions>();

    public static ref readonly GuardValue<int> IsPositive(this in GuardValue<int> guard)
        => ref guard.Greater<int, IntConditions>(default);

    public static ref readonly GuardValue<int> IsNegative(this in GuardValue<int> guard)
        => ref guard.Less<int, IntConditions>(default);

    public static ref readonly GuardValue<int> Greater(this in GuardValue<int> guard, int value)
        => ref guard.Greater<int, IntConditions>(value);

    public static ref readonly GuardValue<int> GreaterOrEqual(this in GuardValue<int> guard, int value)
        => ref guard.GreaterOrEqual<int, IntConditions>(value);

    public static ref readonly GuardValue<int> Less(this in GuardValue<int> guard, int value)
        => ref guard.Less<int, IntConditions>(value);

    public static ref readonly GuardValue<int> LessOrEqual(this in GuardValue<int> guard, int value)
        => ref guard.LessOrEqual<int, IntConditions>(value);

    public static ref readonly GuardValue<int> InRange(
        this in GuardValue<int> guard,
        int min,
        int max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref guard.InRange<int, IntConditions>(min, max, excludeMin, excludeMax);
}