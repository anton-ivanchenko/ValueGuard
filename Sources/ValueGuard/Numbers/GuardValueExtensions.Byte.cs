using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<byte> IsEqual(this in GuardValue<byte> guard, byte value)
        => ref GenericImplementation.IsEqual<byte, BytePredicates>(guard, value);

    public static ref readonly GuardValue<byte> NotEqual(this in GuardValue<byte> guard, byte value)
        => ref GenericImplementation.NotEqual<byte, BytePredicates>(guard, value);

    public static ref readonly GuardValue<byte> IsDefault(this in GuardValue<byte> guard)
        => ref GenericImplementation.IsDefault<byte, BytePredicates>(guard);

    public static ref readonly GuardValue<byte> NotDefault(this in GuardValue<byte> guard)
        => ref GenericImplementation.NotDefault<byte, BytePredicates>(guard);

    public static ref readonly GuardValue<byte> IsGreater(this in GuardValue<byte> guard, byte value)
        => ref GenericImplementation.IsGreater<byte, BytePredicates>(guard, value);

    public static ref readonly GuardValue<byte> IsGreaterOrEqual(this in GuardValue<byte> guard, byte value)
        => ref GenericImplementation.IsGreaterOrEqual<byte, BytePredicates>(guard, value);

    public static ref readonly GuardValue<byte> IsLess(this in GuardValue<byte> guard, byte value)
        => ref GenericImplementation.IsLess<byte, BytePredicates>(guard, value);

    public static ref readonly GuardValue<byte> IsLessOrEqual(this in GuardValue<byte> guard, byte value)
        => ref GenericImplementation.IsLessOrEqual<byte, BytePredicates>(guard, value);

    public static ref readonly GuardValue<byte> InRange(
        this in GuardValue<byte> guard,
        byte min,
        byte max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref GenericImplementation.InRange<byte, BytePredicates>(guard, min, max, excludeMin, excludeMax);
}