using ValueGuard.Internal;
using ValueGuard.Internal.Conditions.Numbers;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<ulong> Equal(this in GuardValue<ulong> guard, ulong value)
        => ref guard.Equal<ulong, ULongConditions>(value);

    public static ref readonly GuardValue<ulong> NotEqual(this in GuardValue<ulong> guard, ulong value)
        => ref guard.NotEqual<ulong, ULongConditions>(value);

    public static ref readonly GuardValue<ulong> IsDefault(this in GuardValue<ulong> guard)
        => ref guard.IsDefault<ulong, ULongConditions>();

    public static ref readonly GuardValue<ulong> IsNotDefault(this in GuardValue<ulong> guard)
        => ref guard.IsNotDefault<ulong, ULongConditions>();

    public static ref readonly GuardValue<ulong> Greater(this in GuardValue<ulong> guard, ulong value)
        => ref guard.Greater<ulong, ULongConditions>(value);

    public static ref readonly GuardValue<ulong> GreaterOrEqual(this in GuardValue<ulong> guard, ulong value)
        => ref guard.GreaterOrEqual<ulong, ULongConditions>(value);

    public static ref readonly GuardValue<ulong> Less(this in GuardValue<ulong> guard, ulong value)
        => ref guard.Less<ulong, ULongConditions>(value);

    public static ref readonly GuardValue<ulong> LessOrEqual(this in GuardValue<ulong> guard, ulong value)
        => ref guard.LessOrEqual<ulong, ULongConditions>(value);

    public static ref readonly GuardValue<ulong> InRange(
        this in GuardValue<ulong> guard,
        ulong min,
        ulong max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref guard.InRange<ulong, ULongConditions>(min, max, excludeMin, excludeMax);
}