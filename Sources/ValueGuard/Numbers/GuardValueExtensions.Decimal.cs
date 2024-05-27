using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    private const decimal _defaultDecimalTolerance = 1e-12M;

    public static ref readonly GuardValue<decimal> EqualTo(
        this in GuardValue<decimal> guard,
        decimal value,
        decimal tolerance = _defaultDecimalTolerance)
        => ref GenericImplementation.EqualTo<decimal, decimal, DecimalPredicates>(guard, value, tolerance);

    public static ref readonly GuardValue<decimal> NotEqualTo(
        this in GuardValue<decimal> guard,
        decimal value,
        decimal tolerance = _defaultDecimalTolerance)
        => ref GenericImplementation.NotEqualTo<decimal, decimal, DecimalPredicates>(guard, value, tolerance);

    public static ref readonly GuardValue<decimal> IsDefault(this in GuardValue<decimal> guard)
        => ref GenericImplementation.IsDefault<decimal, DecimalPredicates>(guard);

    public static ref readonly GuardValue<decimal> NotDefault(this in GuardValue<decimal> guard)
        => ref GenericImplementation.NotDefault<decimal, DecimalPredicates>(guard);

    public static ref readonly GuardValue<decimal> IsPositive(this in GuardValue<decimal> guard)
        => ref GenericImplementation.GreaterThan<decimal, DecimalPredicates>(guard, default);

    public static ref readonly GuardValue<decimal> IsNegative(this in GuardValue<decimal> guard)
        => ref GenericImplementation.LessThan<decimal, DecimalPredicates>(guard, default);

    public static ref readonly GuardValue<decimal> GreaterThan(this in GuardValue<decimal> guard, decimal value)
        => ref GenericImplementation.GreaterThan<decimal, DecimalPredicates>(guard, value);

    public static ref readonly GuardValue<decimal> GreaterThanOrEqualTo(this in GuardValue<decimal> guard, decimal value)
        => ref GenericImplementation.GreaterThanOrEqualTo<decimal, DecimalPredicates>(guard, value);

    public static ref readonly GuardValue<decimal> LessThan(this in GuardValue<decimal> guard, decimal value)
        => ref GenericImplementation.LessThan<decimal, DecimalPredicates>(guard, value);

    public static ref readonly GuardValue<decimal> LessThanOrEqualTo(this in GuardValue<decimal> guard, decimal value)
        => ref GenericImplementation.LessThanOrEqualTo<decimal, DecimalPredicates>(guard, value);

    public static ref readonly GuardValue<decimal> Between(
        this in GuardValue<decimal> guard,
        decimal min,
        decimal max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref GenericImplementation.Between<decimal, DecimalPredicates>(guard, min, max, excludeMin, excludeMax);
}