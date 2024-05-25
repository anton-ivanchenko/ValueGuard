using ValueGuard.Internal;
using ValueGuard.Internal.Conditions.Numbers;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    private const double _defaultDoubleTolerance = 1e-12;

    public static ref readonly GuardValue<double> Equal(
        this in GuardValue<double> guard,
        double value,
        double tolerance = _defaultDoubleTolerance)
        => ref guard.Equal<double, double, DoubleConditions>(value, tolerance);

    public static ref readonly GuardValue<double> NotEqual(
        this in GuardValue<double> guard,
        double value,
        double tolerance = _defaultDoubleTolerance)
        => ref guard.NotEqual<double, double, DoubleConditions>(value, tolerance);

    public static ref readonly GuardValue<double> IsDefault(this in GuardValue<double> guard)
        => ref guard.IsDefault<double, DoubleConditions>();

    public static ref readonly GuardValue<double> IsNotDefault(this in GuardValue<double> guard)
        => ref guard.IsNotDefault<double, DoubleConditions>();

    public static ref readonly GuardValue<double> IsPositive(this in GuardValue<double> guard)
        => ref guard.Greater<double, DoubleConditions>(default);

    public static ref readonly GuardValue<double> IsNegative(this in GuardValue<double> guard)
        => ref guard.Less<double, DoubleConditions>(default);

    public static ref readonly GuardValue<double> Greater(this in GuardValue<double> guard, double value)
        => ref guard.Greater<double, DoubleConditions>(value);

    public static ref readonly GuardValue<double> GreaterOrEqual(this in GuardValue<double> guard, double value)
        => ref guard.GreaterOrEqual<double, DoubleConditions>(value);

    public static ref readonly GuardValue<double> Less(this in GuardValue<double> guard, double value)
        => ref guard.Less<double, DoubleConditions>(value);

    public static ref readonly GuardValue<double> LessOrEqual(this in GuardValue<double> guard, double value)
        => ref guard.LessOrEqual<double, DoubleConditions>(value);

    public static ref readonly GuardValue<double> InRange(
        this in GuardValue<double> guard,
        double min,
        double max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref guard.InRange<double, DoubleConditions>(min, max, excludeMin, excludeMax);
}