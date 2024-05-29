using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardContext<sbyte> EqualTo(this in GuardContext<sbyte> guard, sbyte value)
        => ref GenericImplementation.EqualTo<sbyte, SBytePredicates>(guard, value);

    public static ref readonly GuardContext<sbyte> NotEqualTo(this in GuardContext<sbyte> guard, sbyte value)
        => ref GenericImplementation.NotEqualTo<sbyte, SBytePredicates>(guard, value);

    public static ref readonly GuardContext<sbyte> IsDefault(this in GuardContext<sbyte> guard)
        => ref GenericImplementation.IsDefault<sbyte, SBytePredicates>(guard);

    public static ref readonly GuardContext<sbyte> NotDefault(this in GuardContext<sbyte> guard)
        => ref GenericImplementation.NotDefault<sbyte, SBytePredicates>(guard);

    public static ref readonly GuardContext<sbyte> IsPositive(this in GuardContext<sbyte> guard)
        => ref GenericImplementation.GreaterThan<sbyte, SBytePredicates>(guard, default);

    public static ref readonly GuardContext<sbyte> IsNegative(this in GuardContext<sbyte> guard)
        => ref GenericImplementation.LessThan<sbyte, SBytePredicates>(guard, default);

    public static ref readonly GuardContext<sbyte> GreaterThan(this in GuardContext<sbyte> guard, sbyte value)
        => ref GenericImplementation.GreaterThan<sbyte, SBytePredicates>(guard, value);

    public static ref readonly GuardContext<sbyte> GreaterThanOrEqualTo(this in GuardContext<sbyte> guard, sbyte value)
        => ref GenericImplementation.GreaterThanOrEqualTo<sbyte, SBytePredicates>(guard, value);

    public static ref readonly GuardContext<sbyte> LessThan(this in GuardContext<sbyte> guard, sbyte value)
        => ref GenericImplementation.LessThan<sbyte, SBytePredicates>(guard, value);

    public static ref readonly GuardContext<sbyte> LessThanOrEqualTo(this in GuardContext<sbyte> guard, sbyte value)
        => ref GenericImplementation.LessThanOrEqualTo<sbyte, SBytePredicates>(guard, value);

    public static ref readonly GuardContext<sbyte> InRange(
        this in GuardContext<sbyte> guard,
        sbyte min,
        sbyte max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref GenericImplementation.InRange<sbyte, SBytePredicates>(guard, min, max, excludeMin, excludeMax);
}