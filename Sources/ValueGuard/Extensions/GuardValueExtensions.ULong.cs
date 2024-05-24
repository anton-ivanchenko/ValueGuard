using ValueGuard.Internal;
using ValueGuard.Internal.Conditions.Numbers;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<ulong> IsEqual(this in GuardValue<ulong> guard, ulong value)
        => ref guard.IsEqual<ulong, ULongConditions>(value);

    public static ref readonly GuardValue<ulong> IsNotEqual(this in GuardValue<ulong> guard, ulong value)
        => ref guard.IsNotEqual<ulong, ULongConditions>(value);

    public static ref readonly GuardValue<ulong> IsDefault(this in GuardValue<ulong> guard)
        => ref guard.IsDefault<ulong, ULongConditions>();

    public static ref readonly GuardValue<ulong> IsNotDefault(this in GuardValue<ulong> guard)
        => ref guard.IsNotDefault<ulong, ULongConditions>();

    public static ref readonly GuardValue<ulong> IsGreater(this in GuardValue<ulong> guard, ulong value)
        => ref guard.IsGreater<ulong, ULongConditions>(value);

    public static ref readonly GuardValue<ulong> IsGreaterOrEqual(this in GuardValue<ulong> guard, ulong value)
        => ref guard.IsGreaterOrEqual<ulong, ULongConditions>(value);

    public static ref readonly GuardValue<ulong> IsLess(this in GuardValue<ulong> guard, ulong value)
        => ref guard.IsLess<ulong, ULongConditions>(value);

    public static ref readonly GuardValue<ulong> IsLessOrEqual(this in GuardValue<ulong> guard, ulong value)
        => ref guard.IsLessOrEqual<ulong, ULongConditions>(value);

    public static ref readonly GuardValue<ulong> InRange(
        this in GuardValue<ulong> guard,
        ulong min,
        ulong max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref guard.InRange<ulong, ULongConditions>(min, max, excludeMin, excludeMax);
}