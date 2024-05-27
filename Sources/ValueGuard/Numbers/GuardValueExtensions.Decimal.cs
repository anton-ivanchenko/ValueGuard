using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    private const decimal _defaultDecimalTolerance = 1e-12M;

    public static ref readonly GuardValue<decimal> IsEqual(
        this in GuardValue<decimal> guard,
        decimal value,
        decimal tolerance = _defaultDecimalTolerance)
        => ref GenericImplementation.IsEqual<decimal, decimal, DecimalPredicates>(guard, value, tolerance);

    public static ref readonly GuardValue<decimal> NotEqual(
        this in GuardValue<decimal> guard,
        decimal value,
        decimal tolerance = _defaultDecimalTolerance)
        => ref GenericImplementation.NotEqual<decimal, decimal, DecimalPredicates>(guard, value, tolerance);

    public static ref readonly GuardValue<decimal> IsDefault(this in GuardValue<decimal> guard)
        => ref GenericImplementation.IsDefault<decimal, DecimalPredicates>(guard);

    public static ref readonly GuardValue<decimal> NotDefault(this in GuardValue<decimal> guard)
        => ref GenericImplementation.NotDefault<decimal, DecimalPredicates>(guard);

    public static ref readonly GuardValue<decimal> IsPositive(this in GuardValue<decimal> guard)
        => ref GenericImplementation.IsGreater<decimal, DecimalPredicates>(guard, default);

    public static ref readonly GuardValue<decimal> IsNegative(this in GuardValue<decimal> guard)
        => ref GenericImplementation.IsLess<decimal, DecimalPredicates>(guard, default);

    public static ref readonly GuardValue<decimal> IsGreater(this in GuardValue<decimal> guard, decimal value)
        => ref GenericImplementation.IsGreater<decimal, DecimalPredicates>(guard, value);

    public static ref readonly GuardValue<decimal> IsGreaterOrEqual(this in GuardValue<decimal> guard, decimal value)
        => ref GenericImplementation.IsGreaterOrEqual<decimal, DecimalPredicates>(guard, value);

    public static ref readonly GuardValue<decimal> IsLess(this in GuardValue<decimal> guard, decimal value)
        => ref GenericImplementation.IsLess<decimal, DecimalPredicates>(guard, value);

    public static ref readonly GuardValue<decimal> IsLessOrEqual(this in GuardValue<decimal> guard, decimal value)
        => ref GenericImplementation.IsLessOrEqual<decimal, DecimalPredicates>(guard, value);

    public static ref readonly GuardValue<decimal> InRange(
        this in GuardValue<decimal> guard,
        decimal min,
        decimal max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref GenericImplementation.InRange<decimal, DecimalPredicates>(guard, min, max, excludeMin, excludeMax);
}