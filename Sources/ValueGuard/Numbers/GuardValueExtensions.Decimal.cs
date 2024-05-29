using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    private const decimal _defaultDecimalTolerance = 1e-12M;

    public static ref readonly GuardContext<decimal> EqualTo(
        this in GuardContext<decimal> guard,
        decimal value,
        decimal tolerance = _defaultDecimalTolerance)
        => ref GenericImplementation.EqualTo<decimal, decimal, DecimalPredicates>(guard, value, tolerance);

    public static ref readonly GuardContext<decimal> NotEqualTo(
        this in GuardContext<decimal> guard,
        decimal value,
        decimal tolerance = _defaultDecimalTolerance)
        => ref GenericImplementation.NotEqualTo<decimal, decimal, DecimalPredicates>(guard, value, tolerance);

    public static ref readonly GuardContext<decimal> IsDefault(this in GuardContext<decimal> guard)
        => ref GenericImplementation.IsDefault<decimal, DecimalPredicates>(guard);

    public static ref readonly GuardContext<decimal> NotDefault(this in GuardContext<decimal> guard)
        => ref GenericImplementation.NotDefault<decimal, DecimalPredicates>(guard);

    public static ref readonly GuardContext<decimal> IsPositive(this in GuardContext<decimal> guard)
        => ref GenericImplementation.GreaterThan<decimal, DecimalPredicates>(guard, default);

    public static ref readonly GuardContext<decimal> IsNegative(this in GuardContext<decimal> guard)
        => ref GenericImplementation.LessThan<decimal, DecimalPredicates>(guard, default);

    public static ref readonly GuardContext<decimal> GreaterThan(this in GuardContext<decimal> guard, decimal value)
        => ref GenericImplementation.GreaterThan<decimal, DecimalPredicates>(guard, value);

    public static ref readonly GuardContext<decimal> GreaterThanOrEqualTo(this in GuardContext<decimal> guard, decimal value)
        => ref GenericImplementation.GreaterThanOrEqualTo<decimal, DecimalPredicates>(guard, value);

    public static ref readonly GuardContext<decimal> LessThan(this in GuardContext<decimal> guard, decimal value)
        => ref GenericImplementation.LessThan<decimal, DecimalPredicates>(guard, value);

    public static ref readonly GuardContext<decimal> LessThanOrEqualTo(this in GuardContext<decimal> guard, decimal value)
        => ref GenericImplementation.LessThanOrEqualTo<decimal, DecimalPredicates>(guard, value);

    public static ref readonly GuardContext<decimal> InRange(
        this in GuardContext<decimal> guard,
        decimal min,
        decimal max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref GenericImplementation.InRange<decimal, DecimalPredicates>(guard, min, max, excludeMin, excludeMax);
}