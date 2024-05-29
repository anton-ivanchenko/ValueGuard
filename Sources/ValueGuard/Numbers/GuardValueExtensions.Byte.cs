using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardContext<byte> EqualTo(this in GuardContext<byte> guard, byte value)
        => ref GenericImplementation.EqualTo<byte, BytePredicates>(guard, value);

    public static ref readonly GuardContext<byte> NotEqualTo(this in GuardContext<byte> guard, byte value)
        => ref GenericImplementation.NotEqualTo<byte, BytePredicates>(guard, value);

    public static ref readonly GuardContext<byte> IsDefault(this in GuardContext<byte> guard)
        => ref GenericImplementation.IsDefault<byte, BytePredicates>(guard);

    public static ref readonly GuardContext<byte> NotDefault(this in GuardContext<byte> guard)
        => ref GenericImplementation.NotDefault<byte, BytePredicates>(guard);

    public static ref readonly GuardContext<byte> GreaterThan(this in GuardContext<byte> guard, byte value)
        => ref GenericImplementation.GreaterThan<byte, BytePredicates>(guard, value);

    public static ref readonly GuardContext<byte> GreaterThanOrEqualTo(this in GuardContext<byte> guard, byte value)
        => ref GenericImplementation.GreaterThanOrEqualTo<byte, BytePredicates>(guard, value);

    public static ref readonly GuardContext<byte> LessThan(this in GuardContext<byte> guard, byte value)
        => ref GenericImplementation.LessThan<byte, BytePredicates>(guard, value);

    public static ref readonly GuardContext<byte> LessThanOrEqualTo(this in GuardContext<byte> guard, byte value)
        => ref GenericImplementation.LessThanOrEqualTo<byte, BytePredicates>(guard, value);

    public static ref readonly GuardContext<byte> InRange(
        this in GuardContext<byte> guard,
        byte min,
        byte max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref GenericImplementation.InRange<byte, BytePredicates>(guard, min, max, excludeMin, excludeMax);
}