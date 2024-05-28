using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    private const double _defaultDoubleTolerance = 1e-12;

    public static ref readonly GuardValue<double> EqualTo(
        this in GuardValue<double> guard,
        double value,
        double tolerance = _defaultDoubleTolerance)
        => ref GenericImplementation.EqualTo<double, double, DoublePredicates>(guard, value, tolerance);

    public static ref readonly GuardValue<double> NotEqualTo(
        this in GuardValue<double> guard,
        double value,
        double tolerance = _defaultDoubleTolerance)
        => ref GenericImplementation.NotEqualTo<double, double, DoublePredicates>(guard, value, tolerance);

    public static ref readonly GuardValue<double> IsDefault(this in GuardValue<double> guard)
        => ref GenericImplementation.IsDefault<double, DoublePredicates>(guard);

    public static ref readonly GuardValue<double> NotDefault(this in GuardValue<double> guard)
        => ref GenericImplementation.NotDefault<double, DoublePredicates>(guard);

    public static ref readonly GuardValue<double> IsPositive(this in GuardValue<double> guard)
        => ref GenericImplementation.GreaterThan<double, DoublePredicates>(guard, default);

    public static ref readonly GuardValue<double> IsNegative(this in GuardValue<double> guard)
        => ref GenericImplementation.LessThan<double, DoublePredicates>(guard, default);

    public static ref readonly GuardValue<double> GreaterThan(this in GuardValue<double> guard, double value)
        => ref GenericImplementation.GreaterThan<double, DoublePredicates>(guard, value);

    public static ref readonly GuardValue<double> GreaterThanOrEqualTo(this in GuardValue<double> guard, double value)
        => ref GenericImplementation.GreaterThanOrEqualTo<double, DoublePredicates>(guard, value);

    public static ref readonly GuardValue<double> LessThan(this in GuardValue<double> guard, double value)
        => ref GenericImplementation.LessThan<double, DoublePredicates>(guard, value);

    public static ref readonly GuardValue<double> LessThanOrEqualTo(this in GuardValue<double> guard, double value)
        => ref GenericImplementation.LessThanOrEqualTo<double, DoublePredicates>(guard, value);

    public static ref readonly GuardValue<double> InRange(
        this in GuardValue<double> guard,
        double min,
        double max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref GenericImplementation.InRange<double, DoublePredicates>(guard, min, max, excludeMin, excludeMax);
}