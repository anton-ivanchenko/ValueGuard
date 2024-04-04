using ValueGuard.Internal;
using ValueGuard.Internal.Conditions.Numbers;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<sbyte> IsEqual(this in GuardValue<sbyte> guard, sbyte value)
        => ref guard.IsEqual<sbyte, SByteConditions>(value);

    public static ref readonly GuardValue<sbyte> IsNotEqual(this in GuardValue<sbyte> guard, sbyte value)
        => ref guard.IsNotEqual<sbyte, SByteConditions>(value);

    public static ref readonly GuardValue<sbyte> IsDefault(this in GuardValue<sbyte> guard)
        => ref guard.IsDefault<sbyte, SByteConditions>();

    public static ref readonly GuardValue<sbyte> IsNotDefault(this in GuardValue<sbyte> guard)
        => ref guard.IsNotDefault<sbyte, SByteConditions>();

    public static ref readonly GuardValue<sbyte> IsPositive(this in GuardValue<sbyte> guard)
        => ref guard.IsGreater<sbyte, SByteConditions>(default);

    public static ref readonly GuardValue<sbyte> IsNegative(this in GuardValue<sbyte> guard)
        => ref guard.IsLess<sbyte, SByteConditions>(default);

    public static ref readonly GuardValue<sbyte> IsGreater(this in GuardValue<sbyte> guard, sbyte value)
        => ref guard.IsGreater<sbyte, SByteConditions>(value);

    public static ref readonly GuardValue<sbyte> IsGreaterOrEqual(this in GuardValue<sbyte> guard, sbyte value)
        => ref guard.IsGreaterOrEqual<sbyte, SByteConditions>(value);

    public static ref readonly GuardValue<sbyte> IsLess(this in GuardValue<sbyte> guard, sbyte value)
        => ref guard.IsLess<sbyte, SByteConditions>(value);

    public static ref readonly GuardValue<sbyte> IsLessOrEqual(this in GuardValue<sbyte> guard, sbyte value)
        => ref guard.IsLessOrEqual<sbyte, SByteConditions>(value);

    public static ref readonly GuardValue<sbyte> InRange(
        this in GuardValue<sbyte> guard,
        sbyte min,
        sbyte max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref guard.InRange<sbyte, SByteConditions>(min, max, excludeMin, excludeMax);
}