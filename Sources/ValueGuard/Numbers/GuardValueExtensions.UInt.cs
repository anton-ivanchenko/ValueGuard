using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<uint> EqualTo(this in GuardValue<uint> guard, uint value)
        => ref GenericImplementation.EqualTo<uint, UIntPredicates>(guard, value);

    public static ref readonly GuardValue<uint> NotEqualTo(this in GuardValue<uint> guard, uint value)
        => ref GenericImplementation.NotEqualTo<uint, UIntPredicates>(guard, value);

    public static ref readonly GuardValue<uint> IsDefault(this in GuardValue<uint> guard)
        => ref GenericImplementation.IsDefault<uint, UIntPredicates>(guard);

    public static ref readonly GuardValue<uint> NotDefault(this in GuardValue<uint> guard)
        => ref GenericImplementation.NotDefault<uint, UIntPredicates>(guard);

    public static ref readonly GuardValue<uint> GreaterThan(this in GuardValue<uint> guard, uint value)
        => ref GenericImplementation.GreaterThan<uint, UIntPredicates>(guard, value);

    public static ref readonly GuardValue<uint> GreaterThanOrEqualTo(this in GuardValue<uint> guard, uint value)
        => ref GenericImplementation.GreaterThanOrEqualTo<uint, UIntPredicates>(guard, value);

    public static ref readonly GuardValue<uint> LessThan(this in GuardValue<uint> guard, uint value)
        => ref GenericImplementation.LessThan<uint, UIntPredicates>(guard, value);

    public static ref readonly GuardValue<uint> LessThanOrEqualTo(this in GuardValue<uint> guard, uint value)
        => ref GenericImplementation.LessThanOrEqualTo<uint, UIntPredicates>(guard, value);

    public static ref readonly GuardValue<uint> InRange(
        this in GuardValue<uint> guard,
        uint min,
        uint max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref GenericImplementation.InRange<uint, UIntPredicates>(guard, min, max, excludeMin, excludeMax);
}