using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<sbyte> IsEqual(this in GuardValue<sbyte> guard, sbyte value)
        => ref GenericImplementation.IsEqual<sbyte, SBytePredicates>(guard, value);

    public static ref readonly GuardValue<sbyte> NotEqual(this in GuardValue<sbyte> guard, sbyte value)
        => ref GenericImplementation.NotEqual<sbyte, SBytePredicates>(guard, value);

    public static ref readonly GuardValue<sbyte> IsDefault(this in GuardValue<sbyte> guard)
        => ref GenericImplementation.IsDefault<sbyte, SBytePredicates>(guard);

    public static ref readonly GuardValue<sbyte> NotDefault(this in GuardValue<sbyte> guard)
        => ref GenericImplementation.NotDefault<sbyte, SBytePredicates>(guard);

    public static ref readonly GuardValue<sbyte> IsPositive(this in GuardValue<sbyte> guard)
        => ref GenericImplementation.IsGreater<sbyte, SBytePredicates>(guard, default);

    public static ref readonly GuardValue<sbyte> IsNegative(this in GuardValue<sbyte> guard)
        => ref GenericImplementation.IsLess<sbyte, SBytePredicates>(guard, default);

    public static ref readonly GuardValue<sbyte> IsGreater(this in GuardValue<sbyte> guard, sbyte value)
        => ref GenericImplementation.IsGreater<sbyte, SBytePredicates>(guard, value);

    public static ref readonly GuardValue<sbyte> IsGreaterOrEqual(this in GuardValue<sbyte> guard, sbyte value)
        => ref GenericImplementation.IsGreaterOrEqual<sbyte, SBytePredicates>(guard, value);

    public static ref readonly GuardValue<sbyte> IsLess(this in GuardValue<sbyte> guard, sbyte value)
        => ref GenericImplementation.IsLess<sbyte, SBytePredicates>(guard, value);

    public static ref readonly GuardValue<sbyte> IsLessOrEqual(this in GuardValue<sbyte> guard, sbyte value)
        => ref GenericImplementation.IsLessOrEqual<sbyte, SBytePredicates>(guard, value);

    public static ref readonly GuardValue<sbyte> InRange(
        this in GuardValue<sbyte> guard,
        sbyte min,
        sbyte max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref GenericImplementation.InRange<sbyte, SBytePredicates>(guard, min, max, excludeMin, excludeMax);
}