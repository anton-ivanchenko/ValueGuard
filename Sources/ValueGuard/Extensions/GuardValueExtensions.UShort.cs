using ValueGuard.Internal;
using ValueGuard.Internal.Conditions.Numbers;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<ushort> IsEqual(this in GuardValue<ushort> guard, ushort value)
        => ref guard.IsEqual<ushort, UShortConditions>(value);

    public static ref readonly GuardValue<ushort> IsNotEqual(this in GuardValue<ushort> guard, ushort value)
        => ref guard.IsNotEqual<ushort, UShortConditions>(value);

    public static ref readonly GuardValue<ushort> IsDefault(this in GuardValue<ushort> guard)
        => ref guard.IsDefault<ushort, UShortConditions>();

    public static ref readonly GuardValue<ushort> IsNotDefault(this in GuardValue<ushort> guard)
        => ref guard.IsNotDefault<ushort, UShortConditions>();

    public static ref readonly GuardValue<ushort> IsGreater(this in GuardValue<ushort> guard, ushort value)
        => ref guard.IsGreater<ushort, UShortConditions>(value);

    public static ref readonly GuardValue<ushort> IsGreaterOrEqual(this in GuardValue<ushort> guard, ushort value)
        => ref guard.IsGreaterOrEqual<ushort, UShortConditions>(value);

    public static ref readonly GuardValue<ushort> IsLess(this in GuardValue<ushort> guard, ushort value)
        => ref guard.IsLess<ushort, UShortConditions>(value);

    public static ref readonly GuardValue<ushort> IsLessOrEqual(this in GuardValue<ushort> guard, ushort value)
        => ref guard.IsLessOrEqual<ushort, UShortConditions>(value);

    public static ref readonly GuardValue<ushort> InRange(
        this in GuardValue<ushort> guard,
        ushort min,
        ushort max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref guard.InRange<ushort, UShortConditions>(min, max, excludeMin, excludeMax);
}