using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    private const double _defaultDoubleTolerance = 1e-12;

    public static ref readonly GuardContext<double> EqualTo(
        this in GuardContext<double> guard,
        double value,
        double tolerance = _defaultDoubleTolerance)
        => ref GenericImplementation.EqualTo<double, double, DoublePredicates>(guard, value, tolerance);

    public static ref readonly GuardContext<double> NotEqualTo(
        this in GuardContext<double> guard,
        double value,
        double tolerance = _defaultDoubleTolerance)
        => ref GenericImplementation.NotEqualTo<double, double, DoublePredicates>(guard, value, tolerance);

    public static ref readonly GuardContext<double> IsDefault(this in GuardContext<double> guard)
        => ref GenericImplementation.IsDefault<double, DoublePredicates>(guard);

    public static ref readonly GuardContext<double> NotDefault(this in GuardContext<double> guard)
        => ref GenericImplementation.NotDefault<double, DoublePredicates>(guard);

    public static ref readonly GuardContext<double> IsPositive(this in GuardContext<double> guard)
        => ref GenericImplementation.GreaterThan<double, DoublePredicates>(guard, default);

    public static ref readonly GuardContext<double> IsNegative(this in GuardContext<double> guard)
        => ref GenericImplementation.LessThan<double, DoublePredicates>(guard, default);

    public static ref readonly GuardContext<double> GreaterThan(this in GuardContext<double> guard, double value)
        => ref GenericImplementation.GreaterThan<double, DoublePredicates>(guard, value);

    public static ref readonly GuardContext<double> GreaterThanOrEqualTo(this in GuardContext<double> guard, double value)
        => ref GenericImplementation.GreaterThanOrEqualTo<double, DoublePredicates>(guard, value);

    public static ref readonly GuardContext<double> LessThan(this in GuardContext<double> guard, double value)
        => ref GenericImplementation.LessThan<double, DoublePredicates>(guard, value);

    public static ref readonly GuardContext<double> LessThanOrEqualTo(this in GuardContext<double> guard, double value)
        => ref GenericImplementation.LessThanOrEqualTo<double, DoublePredicates>(guard, value);

    public static ref readonly GuardContext<double> InRange(
        this in GuardContext<double> guard,
        double min,
        double max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref GenericImplementation.InRange<double, DoublePredicates>(guard, min, max, excludeMin, excludeMax);
}