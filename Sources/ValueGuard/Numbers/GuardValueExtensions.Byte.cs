using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<byte> EqualTo(this in GuardValue<byte> guard, byte value)
        => ref GenericImplementation.EqualTo<byte, BytePredicates>(guard, value);

    public static ref readonly GuardValue<byte> NotEqualTo(this in GuardValue<byte> guard, byte value)
        => ref GenericImplementation.NotEqualTo<byte, BytePredicates>(guard, value);

    public static ref readonly GuardValue<byte> IsDefault(this in GuardValue<byte> guard)
        => ref GenericImplementation.IsDefault<byte, BytePredicates>(guard);

    public static ref readonly GuardValue<byte> NotDefault(this in GuardValue<byte> guard)
        => ref GenericImplementation.NotDefault<byte, BytePredicates>(guard);

    public static ref readonly GuardValue<byte> GreaterThan(this in GuardValue<byte> guard, byte value)
        => ref GenericImplementation.GreaterThan<byte, BytePredicates>(guard, value);

    public static ref readonly GuardValue<byte> GreaterThanOrEqualTo(this in GuardValue<byte> guard, byte value)
        => ref GenericImplementation.GreaterThanOrEqualTo<byte, BytePredicates>(guard, value);

    public static ref readonly GuardValue<byte> LessThan(this in GuardValue<byte> guard, byte value)
        => ref GenericImplementation.LessThan<byte, BytePredicates>(guard, value);

    public static ref readonly GuardValue<byte> LessThanOrEqualTo(this in GuardValue<byte> guard, byte value)
        => ref GenericImplementation.LessThanOrEqualTo<byte, BytePredicates>(guard, value);

    public static ref readonly GuardValue<byte> InRange(
        this in GuardValue<byte> guard,
        byte min,
        byte max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref GenericImplementation.InRange<byte, BytePredicates>(guard, min, max, excludeMin, excludeMax);
}