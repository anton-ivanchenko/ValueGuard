using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    private const double _defaultDoubleTolerance = 1e-12;

    public static ref readonly GuardValue<double> IsEqual(
        this in GuardValue<double> guard,
        double value,
        double tolerance = _defaultDoubleTolerance)
        => ref GenericImplementation.IsEqual<double, double, DoublePredicates>(guard, value, tolerance);

    public static ref readonly GuardValue<double> NotEqual(
        this in GuardValue<double> guard,
        double value,
        double tolerance = _defaultDoubleTolerance)
        => ref GenericImplementation.NotEqual<double, double, DoublePredicates>(guard, value, tolerance);

    public static ref readonly GuardValue<double> IsDefault(this in GuardValue<double> guard)
        => ref GenericImplementation.IsDefault<double, DoublePredicates>(guard);

    public static ref readonly GuardValue<double> NotDefault(this in GuardValue<double> guard)
        => ref GenericImplementation.NotDefault<double, DoublePredicates>(guard);

    public static ref readonly GuardValue<double> IsPositive(this in GuardValue<double> guard)
        => ref GenericImplementation.IsGreater<double, DoublePredicates>(guard, default);

    public static ref readonly GuardValue<double> IsNegative(this in GuardValue<double> guard)
        => ref GenericImplementation.IsLess<double, DoublePredicates>(guard, default);

    public static ref readonly GuardValue<double> IsGreater(this in GuardValue<double> guard, double value)
        => ref GenericImplementation.IsGreater<double, DoublePredicates>(guard, value);

    public static ref readonly GuardValue<double> IsGreaterOrEqual(this in GuardValue<double> guard, double value)
        => ref GenericImplementation.IsGreaterOrEqual<double, DoublePredicates>(guard, value);

    public static ref readonly GuardValue<double> IsLess(this in GuardValue<double> guard, double value)
        => ref GenericImplementation.IsLess<double, DoublePredicates>(guard, value);

    public static ref readonly GuardValue<double> IsLessOrEqual(this in GuardValue<double> guard, double value)
        => ref GenericImplementation.IsLessOrEqual<double, DoublePredicates>(guard, value);

    public static ref readonly GuardValue<double> InRange(
        this in GuardValue<double> guard,
        double min,
        double max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref GenericImplementation.InRange<double, DoublePredicates>(guard, min, max, excludeMin, excludeMax);
}