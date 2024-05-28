using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    private const float _defaultFloatTolerance = 1e-12f;

    public static ref readonly GuardValue<float> EqualTo(
        this in GuardValue<float> guard,
        float value,
        float tolerance = _defaultFloatTolerance)
        => ref GenericImplementation.EqualTo<float, float, FloatPredicates>(guard, value, tolerance);

    public static ref readonly GuardValue<float> NotEqualTo(
        this in GuardValue<float> guard,
        float value,
        float tolerance = _defaultFloatTolerance)
        => ref GenericImplementation.NotEqualTo<float, float, FloatPredicates>(guard, value, tolerance);

    public static ref readonly GuardValue<float> IsDefault(this in GuardValue<float> guard)
        => ref GenericImplementation.IsDefault<float, FloatPredicates>(guard);

    public static ref readonly GuardValue<float> NotDefault(this in GuardValue<float> guard)
        => ref GenericImplementation.NotDefault<float, FloatPredicates>(guard);

    public static ref readonly GuardValue<float> IsPositive(this in GuardValue<float> guard)
        => ref GenericImplementation.GreaterThan<float, FloatPredicates>(guard, default);

    public static ref readonly GuardValue<float> IsNegative(this in GuardValue<float> guard)
        => ref GenericImplementation.LessThan<float, FloatPredicates>(guard, default);

    public static ref readonly GuardValue<float> GreaterThan(this in GuardValue<float> guard, float value)
        => ref GenericImplementation.GreaterThan<float, FloatPredicates>(guard, value);

    public static ref readonly GuardValue<float> GreaterThanOrEqualTo(this in GuardValue<float> guard, float value)
        => ref GenericImplementation.GreaterThanOrEqualTo<float, FloatPredicates>(guard, value);

    public static ref readonly GuardValue<float> LessThan(this in GuardValue<float> guard, float value)
        => ref GenericImplementation.LessThan<float, FloatPredicates>(guard, value);

    public static ref readonly GuardValue<float> LessThanOrEqualTo(this in GuardValue<float> guard, float value)
        => ref GenericImplementation.LessThanOrEqualTo<float, FloatPredicates>(guard, value);

    public static ref readonly GuardValue<float> InRange(
        this in GuardValue<float> guard,
        float min,
        float max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref GenericImplementation.InRange<float, FloatPredicates>(guard, min, max, excludeMin, excludeMax);
}