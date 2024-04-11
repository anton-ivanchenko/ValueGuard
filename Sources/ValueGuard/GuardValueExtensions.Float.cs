using ValueGuard.Internal;
using ValueGuard.Internal.Conditions.Numbers;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    private const float DefaultFloatTolerance = 1e-12f;

    public static ref readonly GuardValue<float> IsEqual(
        this in GuardValue<float> guard,
        float value,
        float tolerance = DefaultFloatTolerance)
        => ref guard.IsEqual<float, FloatConditions>(value, tolerance);

    public static ref readonly GuardValue<float> IsNotEqual(
        this in GuardValue<float> guard,
        float value,
        float tolerance = DefaultFloatTolerance)
        => ref guard.IsNotEqual<float, FloatConditions>(value, tolerance);

    public static ref readonly GuardValue<float> IsDefault(this in GuardValue<float> guard)
        => ref guard.IsDefault<float, FloatConditions>();

    public static ref readonly GuardValue<float> IsNotDefault(this in GuardValue<float> guard)
        => ref guard.IsNotDefault<float, FloatConditions>();

    public static ref readonly GuardValue<float> IsPositive(this in GuardValue<float> guard)
        => ref guard.IsGreater<float, FloatConditions>(default);

    public static ref readonly GuardValue<float> IsNegative(this in GuardValue<float> guard)
        => ref guard.IsLess<float, FloatConditions>(default);

    public static ref readonly GuardValue<float> IsGreater(this in GuardValue<float> guard, float value)
        => ref guard.IsGreater<float, FloatConditions>(value);

    public static ref readonly GuardValue<float> IsGreaterOrEqual(this in GuardValue<float> guard, float value)
        => ref guard.IsGreaterOrEqual<float, FloatConditions>(value);

    public static ref readonly GuardValue<float> IsLess(this in GuardValue<float> guard, float value)
        => ref guard.IsLess<float, FloatConditions>(value);

    public static ref readonly GuardValue<float> IsLessOrEqual(this in GuardValue<float> guard, float value)
        => ref guard.IsLessOrEqual<float, FloatConditions>(value);

    public static ref readonly GuardValue<float> InRange(
        this in GuardValue<float> guard,
        float min,
        float max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref guard.InRange<float, FloatConditions>(min, max, excludeMin, excludeMax);
}