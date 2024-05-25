using ValueGuard.Internal;
using ValueGuard.Internal.Conditions.Numbers;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<sbyte> Equal(this in GuardValue<sbyte> guard, sbyte value)
        => ref guard.Equal<sbyte, SByteConditions>(value);

    public static ref readonly GuardValue<sbyte> NotEqual(this in GuardValue<sbyte> guard, sbyte value)
        => ref guard.NotEqual<sbyte, SByteConditions>(value);

    public static ref readonly GuardValue<sbyte> IsDefault(this in GuardValue<sbyte> guard)
        => ref guard.IsDefault<sbyte, SByteConditions>();

    public static ref readonly GuardValue<sbyte> IsNotDefault(this in GuardValue<sbyte> guard)
        => ref guard.IsNotDefault<sbyte, SByteConditions>();

    public static ref readonly GuardValue<sbyte> IsPositive(this in GuardValue<sbyte> guard)
        => ref guard.Greater<sbyte, SByteConditions>(default);

    public static ref readonly GuardValue<sbyte> IsNegative(this in GuardValue<sbyte> guard)
        => ref guard.Less<sbyte, SByteConditions>(default);

    public static ref readonly GuardValue<sbyte> Greater(this in GuardValue<sbyte> guard, sbyte value)
        => ref guard.Greater<sbyte, SByteConditions>(value);

    public static ref readonly GuardValue<sbyte> GreaterOrEqual(this in GuardValue<sbyte> guard, sbyte value)
        => ref guard.GreaterOrEqual<sbyte, SByteConditions>(value);

    public static ref readonly GuardValue<sbyte> Less(this in GuardValue<sbyte> guard, sbyte value)
        => ref guard.Less<sbyte, SByteConditions>(value);

    public static ref readonly GuardValue<sbyte> LessOrEqual(this in GuardValue<sbyte> guard, sbyte value)
        => ref guard.LessOrEqual<sbyte, SByteConditions>(value);

    public static ref readonly GuardValue<sbyte> InRange(
        this in GuardValue<sbyte> guard,
        sbyte min,
        sbyte max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref guard.InRange<sbyte, SByteConditions>(min, max, excludeMin, excludeMax);
}