using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<sbyte> EqualTo(this in GuardValue<sbyte> guard, sbyte value)
        => ref GenericImplementation.EqualTo<sbyte, SBytePredicates>(guard, value);

    public static ref readonly GuardValue<sbyte> NotEqualTo(this in GuardValue<sbyte> guard, sbyte value)
        => ref GenericImplementation.NotEqualTo<sbyte, SBytePredicates>(guard, value);

    public static ref readonly GuardValue<sbyte> IsDefault(this in GuardValue<sbyte> guard)
        => ref GenericImplementation.IsDefault<sbyte, SBytePredicates>(guard);

    public static ref readonly GuardValue<sbyte> NotDefault(this in GuardValue<sbyte> guard)
        => ref GenericImplementation.NotDefault<sbyte, SBytePredicates>(guard);

    public static ref readonly GuardValue<sbyte> IsPositive(this in GuardValue<sbyte> guard)
        => ref GenericImplementation.GreaterThan<sbyte, SBytePredicates>(guard, default);

    public static ref readonly GuardValue<sbyte> IsNegative(this in GuardValue<sbyte> guard)
        => ref GenericImplementation.LessThan<sbyte, SBytePredicates>(guard, default);

    public static ref readonly GuardValue<sbyte> GreaterThan(this in GuardValue<sbyte> guard, sbyte value)
        => ref GenericImplementation.GreaterThan<sbyte, SBytePredicates>(guard, value);

    public static ref readonly GuardValue<sbyte> GreaterThanOrEqualTo(this in GuardValue<sbyte> guard, sbyte value)
        => ref GenericImplementation.GreaterThanOrEqualTo<sbyte, SBytePredicates>(guard, value);

    public static ref readonly GuardValue<sbyte> LessThan(this in GuardValue<sbyte> guard, sbyte value)
        => ref GenericImplementation.LessThan<sbyte, SBytePredicates>(guard, value);

    public static ref readonly GuardValue<sbyte> LessThanOrEqualTo(this in GuardValue<sbyte> guard, sbyte value)
        => ref GenericImplementation.LessThanOrEqualTo<sbyte, SBytePredicates>(guard, value);

    public static ref readonly GuardValue<sbyte> Between(
        this in GuardValue<sbyte> guard,
        sbyte min,
        sbyte max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref GenericImplementation.Between<sbyte, SBytePredicates>(guard, min, max, excludeMin, excludeMax);
}