using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    private const float _defaultFloatTolerance = 1e-12f;

    public static ref readonly GuardValue<float> IsEqual(
        this in GuardValue<float> guard,
        float value,
        float tolerance = _defaultFloatTolerance)
        => ref GenericImplementation.IsEqual<float, float, FloatPredicates>(guard, value, tolerance);

    public static ref readonly GuardValue<float> NotEqual(
        this in GuardValue<float> guard,
        float value,
        float tolerance = _defaultFloatTolerance)
        => ref GenericImplementation.NotEqual<float, float, FloatPredicates>(guard, value, tolerance);

    public static ref readonly GuardValue<float> IsDefault(this in GuardValue<float> guard)
        => ref GenericImplementation.IsDefault<float, FloatPredicates>(guard);

    public static ref readonly GuardValue<float> NotDefault(this in GuardValue<float> guard)
        => ref GenericImplementation.NotDefault<float, FloatPredicates>(guard);

    public static ref readonly GuardValue<float> IsPositive(this in GuardValue<float> guard)
        => ref GenericImplementation.IsGreater<float, FloatPredicates>(guard, default);

    public static ref readonly GuardValue<float> IsNegative(this in GuardValue<float> guard)
        => ref GenericImplementation.IsLess<float, FloatPredicates>(guard, default);

    public static ref readonly GuardValue<float> IsGreater(this in GuardValue<float> guard, float value)
        => ref GenericImplementation.IsGreater<float, FloatPredicates>(guard, value);

    public static ref readonly GuardValue<float> IsGreaterOrEqual(this in GuardValue<float> guard, float value)
        => ref GenericImplementation.IsGreaterOrEqual<float, FloatPredicates>(guard, value);

    public static ref readonly GuardValue<float> IsLess(this in GuardValue<float> guard, float value)
        => ref GenericImplementation.IsLess<float, FloatPredicates>(guard, value);

    public static ref readonly GuardValue<float> IsLessOrEqual(this in GuardValue<float> guard, float value)
        => ref GenericImplementation.IsLessOrEqual<float, FloatPredicates>(guard, value);

    public static ref readonly GuardValue<float> InRange(
        this in GuardValue<float> guard,
        float min,
        float max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref GenericImplementation.InRange<float, FloatPredicates>(guard, min, max, excludeMin, excludeMax);
}