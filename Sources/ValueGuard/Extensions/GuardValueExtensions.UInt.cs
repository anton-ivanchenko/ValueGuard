using ValueGuard.Internal;
using ValueGuard.Internal.Conditions.Numbers;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<uint> IsEqual(this in GuardValue<uint> guard, uint value)
        => ref guard.IsEqual<uint, UIntConditions>(value);

    public static ref readonly GuardValue<uint> IsNotEqual(this in GuardValue<uint> guard, uint value)
        => ref guard.IsNotEqual<uint, UIntConditions>(value);

    public static ref readonly GuardValue<uint> IsDefault(this in GuardValue<uint> guard)
        => ref guard.IsDefault<uint, UIntConditions>();

    public static ref readonly GuardValue<uint> IsNotDefault(this in GuardValue<uint> guard)
        => ref guard.IsNotDefault<uint, UIntConditions>();

    public static ref readonly GuardValue<uint> IsGreater(this in GuardValue<uint> guard, uint value)
        => ref guard.IsGreater<uint, UIntConditions>(value);

    public static ref readonly GuardValue<uint> IsGreaterOrEqual(this in GuardValue<uint> guard, uint value)
        => ref guard.IsGreaterOrEqual<uint, UIntConditions>(value);

    public static ref readonly GuardValue<uint> IsLess(this in GuardValue<uint> guard, uint value)
        => ref guard.IsLess<uint, UIntConditions>(value);

    public static ref readonly GuardValue<uint> IsLessOrEqual(this in GuardValue<uint> guard, uint value)
        => ref guard.IsLessOrEqual<uint, UIntConditions>(value);

    public static ref readonly GuardValue<uint> InRange(
        this in GuardValue<uint> guard,
        uint min,
        uint max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref guard.InRange<uint, UIntConditions>(min, max, excludeMin, excludeMax);
}