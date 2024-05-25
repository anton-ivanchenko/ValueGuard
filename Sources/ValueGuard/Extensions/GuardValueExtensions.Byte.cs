using ValueGuard.Internal;
using ValueGuard.Internal.Conditions.Numbers;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<byte> Equal(this in GuardValue<byte> guard, byte value)
        => ref guard.Equal<byte, ByteConditions>(value);

    public static ref readonly GuardValue<byte> NotEqual(this in GuardValue<byte> guard, byte value)
        => ref guard.NotEqual<byte, ByteConditions>(value);

    public static ref readonly GuardValue<byte> IsDefault(this in GuardValue<byte> guard)
        => ref guard.IsDefault<byte, ByteConditions>();

    public static ref readonly GuardValue<byte> IsNotDefault(this in GuardValue<byte> guard)
        => ref guard.IsNotDefault<byte, ByteConditions>();

    public static ref readonly GuardValue<byte> Greater(this in GuardValue<byte> guard, byte value)
        => ref guard.Greater<byte, ByteConditions>(value);

    public static ref readonly GuardValue<byte> GreaterOrEqual(this in GuardValue<byte> guard, byte value)
        => ref guard.GreaterOrEqual<byte, ByteConditions>(value);

    public static ref readonly GuardValue<byte> Less(this in GuardValue<byte> guard, byte value)
        => ref guard.Less<byte, ByteConditions>(value);

    public static ref readonly GuardValue<byte> LessOrEqual(this in GuardValue<byte> guard, byte value)
        => ref guard.LessOrEqual<byte, ByteConditions>(value);

    public static ref readonly GuardValue<byte> InRange(
        this in GuardValue<byte> guard,
        byte min,
        byte max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref guard.InRange<byte, ByteConditions>(min, max, excludeMin, excludeMax);
}