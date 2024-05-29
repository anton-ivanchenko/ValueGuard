using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    private const float _defaultFloatTolerance = 1e-12f;

    public static ref readonly GuardContext<float> EqualTo(
        this in GuardContext<float> guard,
        float value,
        float tolerance = _defaultFloatTolerance)
        => ref GenericImplementation.EqualTo<float, float, FloatPredicates>(guard, value, tolerance);

    public static ref readonly GuardContext<float> NotEqualTo(
        this in GuardContext<float> guard,
        float value,
        float tolerance = _defaultFloatTolerance)
        => ref GenericImplementation.NotEqualTo<float, float, FloatPredicates>(guard, value, tolerance);

    public static ref readonly GuardContext<float> IsDefault(this in GuardContext<float> guard)
        => ref GenericImplementation.IsDefault<float, FloatPredicates>(guard);

    public static ref readonly GuardContext<float> NotDefault(this in GuardContext<float> guard)
        => ref GenericImplementation.NotDefault<float, FloatPredicates>(guard);

    public static ref readonly GuardContext<float> IsPositive(this in GuardContext<float> guard)
        => ref GenericImplementation.GreaterThan<float, FloatPredicates>(guard, default);

    public static ref readonly GuardContext<float> IsNegative(this in GuardContext<float> guard)
        => ref GenericImplementation.LessThan<float, FloatPredicates>(guard, default);

    public static ref readonly GuardContext<float> GreaterThan(this in GuardContext<float> guard, float value)
        => ref GenericImplementation.GreaterThan<float, FloatPredicates>(guard, value);

    public static ref readonly GuardContext<float> GreaterThanOrEqualTo(this in GuardContext<float> guard, float value)
        => ref GenericImplementation.GreaterThanOrEqualTo<float, FloatPredicates>(guard, value);

    public static ref readonly GuardContext<float> LessThan(this in GuardContext<float> guard, float value)
        => ref GenericImplementation.LessThan<float, FloatPredicates>(guard, value);

    public static ref readonly GuardContext<float> LessThanOrEqualTo(this in GuardContext<float> guard, float value)
        => ref GenericImplementation.LessThanOrEqualTo<float, FloatPredicates>(guard, value);

    public static ref readonly GuardContext<float> InRange(
        this in GuardContext<float> guard,
        float min,
        float max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref GenericImplementation.InRange<float, FloatPredicates>(guard, min, max, excludeMin, excludeMax);
}