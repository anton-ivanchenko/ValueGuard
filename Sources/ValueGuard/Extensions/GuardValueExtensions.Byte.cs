using ValueGuard.Internal;
using ValueGuard.Internal.Conditions.Numbers;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<byte> IsEqual(this in GuardValue<byte> guard, byte value)
        => ref guard.IsEqual<byte, ByteConditions>(value);

    public static ref readonly GuardValue<byte> IsNotEqual(this in GuardValue<byte> guard, byte value)
        => ref guard.IsNotEqual<byte, ByteConditions>(value);

    public static ref readonly GuardValue<byte> IsDefault(this in GuardValue<byte> guard)
        => ref guard.IsDefault<byte, ByteConditions>();

    public static ref readonly GuardValue<byte> IsNotDefault(this in GuardValue<byte> guard)
        => ref guard.IsNotDefault<byte, ByteConditions>();

    public static ref readonly GuardValue<byte> IsGreater(this in GuardValue<byte> guard, byte value)
        => ref guard.IsGreater<byte, ByteConditions>(value);

    public static ref readonly GuardValue<byte> IsGreaterOrEqual(this in GuardValue<byte> guard, byte value)
        => ref guard.IsGreaterOrEqual<byte, ByteConditions>(value);

    public static ref readonly GuardValue<byte> IsLess(this in GuardValue<byte> guard, byte value)
        => ref guard.IsLess<byte, ByteConditions>(value);

    public static ref readonly GuardValue<byte> IsLessOrEqual(this in GuardValue<byte> guard, byte value)
        => ref guard.IsLessOrEqual<byte, ByteConditions>(value);

    public static ref readonly GuardValue<byte> InRange(
        this in GuardValue<byte> guard,
        byte min,
        byte max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref guard.InRange<byte, ByteConditions>(min, max, excludeMin, excludeMax);
}