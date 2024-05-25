using ValueGuard.Internal;
using ValueGuard.Internal.Conditions.Numbers;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<uint> Equal(this in GuardValue<uint> guard, uint value)
        => ref guard.Equal<uint, UIntConditions>(value);

    public static ref readonly GuardValue<uint> NotEqual(this in GuardValue<uint> guard, uint value)
        => ref guard.NotEqual<uint, UIntConditions>(value);

    public static ref readonly GuardValue<uint> IsDefault(this in GuardValue<uint> guard)
        => ref guard.IsDefault<uint, UIntConditions>();

    public static ref readonly GuardValue<uint> IsNotDefault(this in GuardValue<uint> guard)
        => ref guard.IsNotDefault<uint, UIntConditions>();

    public static ref readonly GuardValue<uint> Greater(this in GuardValue<uint> guard, uint value)
        => ref guard.Greater<uint, UIntConditions>(value);

    public static ref readonly GuardValue<uint> GreaterOrEqual(this in GuardValue<uint> guard, uint value)
        => ref guard.GreaterOrEqual<uint, UIntConditions>(value);

    public static ref readonly GuardValue<uint> Less(this in GuardValue<uint> guard, uint value)
        => ref guard.Less<uint, UIntConditions>(value);

    public static ref readonly GuardValue<uint> LessOrEqual(this in GuardValue<uint> guard, uint value)
        => ref guard.LessOrEqual<uint, UIntConditions>(value);

    public static ref readonly GuardValue<uint> InRange(
        this in GuardValue<uint> guard,
        uint min,
        uint max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref guard.InRange<uint, UIntConditions>(min, max, excludeMin, excludeMax);
}