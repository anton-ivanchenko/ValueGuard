using ValueGuard.Internal;
using ValueGuard.Internal.Conditions.Numbers;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    private const double _defaultDoubleTolerance = 1e-12;

    public static ref readonly GuardValue<double> IsEqual(
        this in GuardValue<double> guard,
        double value,
        double tolerance = _defaultDoubleTolerance)
        => ref guard.IsEqual<double, double, DoubleConditions>(value, tolerance);

    public static ref readonly GuardValue<double> IsNotEqual(
        this in GuardValue<double> guard,
        double value,
        double tolerance = _defaultDoubleTolerance)
        => ref guard.IsNotEqual<double, double, DoubleConditions>(value, tolerance);

    public static ref readonly GuardValue<double> IsDefault(this in GuardValue<double> guard)
        => ref guard.IsDefault<double, DoubleConditions>();

    public static ref readonly GuardValue<double> IsNotDefault(this in GuardValue<double> guard)
        => ref guard.IsNotDefault<double, DoubleConditions>();

    public static ref readonly GuardValue<double> IsPositive(this in GuardValue<double> guard)
        => ref guard.IsGreater<double, DoubleConditions>(default);

    public static ref readonly GuardValue<double> IsNegative(this in GuardValue<double> guard)
        => ref guard.IsLess<double, DoubleConditions>(default);

    public static ref readonly GuardValue<double> IsGreater(this in GuardValue<double> guard, double value)
        => ref guard.IsGreater<double, DoubleConditions>(value);

    public static ref readonly GuardValue<double> IsGreaterOrEqual(this in GuardValue<double> guard, double value)
        => ref guard.IsGreaterOrEqual<double, DoubleConditions>(value);

    public static ref readonly GuardValue<double> IsLess(this in GuardValue<double> guard, double value)
        => ref guard.IsLess<double, DoubleConditions>(value);

    public static ref readonly GuardValue<double> IsLessOrEqual(this in GuardValue<double> guard, double value)
        => ref guard.IsLessOrEqual<double, DoubleConditions>(value);

    public static ref readonly GuardValue<double> InRange(
        this in GuardValue<double> guard,
        double min,
        double max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref guard.InRange<double, DoubleConditions>(min, max, excludeMin, excludeMax);
}