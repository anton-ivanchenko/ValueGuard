using ValueGuard.Internal;
using ValueGuard.Internal.Conditions.Numbers;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<ushort> Equal(this in GuardValue<ushort> guard, ushort value)
        => ref guard.Equal<ushort, UShortConditions>(value);

    public static ref readonly GuardValue<ushort> NotEqual(this in GuardValue<ushort> guard, ushort value)
        => ref guard.NotEqual<ushort, UShortConditions>(value);

    public static ref readonly GuardValue<ushort> IsDefault(this in GuardValue<ushort> guard)
        => ref guard.IsDefault<ushort, UShortConditions>();

    public static ref readonly GuardValue<ushort> IsNotDefault(this in GuardValue<ushort> guard)
        => ref guard.IsNotDefault<ushort, UShortConditions>();

    public static ref readonly GuardValue<ushort> Greater(this in GuardValue<ushort> guard, ushort value)
        => ref guard.Greater<ushort, UShortConditions>(value);

    public static ref readonly GuardValue<ushort> GreaterOrEqual(this in GuardValue<ushort> guard, ushort value)
        => ref guard.GreaterOrEqual<ushort, UShortConditions>(value);

    public static ref readonly GuardValue<ushort> Less(this in GuardValue<ushort> guard, ushort value)
        => ref guard.Less<ushort, UShortConditions>(value);

    public static ref readonly GuardValue<ushort> LessOrEqual(this in GuardValue<ushort> guard, ushort value)
        => ref guard.LessOrEqual<ushort, UShortConditions>(value);

    public static ref readonly GuardValue<ushort> InRange(
        this in GuardValue<ushort> guard,
        ushort min,
        ushort max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref guard.InRange<ushort, UShortConditions>(min, max, excludeMin, excludeMax);
}