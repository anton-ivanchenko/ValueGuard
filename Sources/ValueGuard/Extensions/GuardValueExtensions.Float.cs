using ValueGuard.Internal;
using ValueGuard.Internal.Conditions.Numbers;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    private const float _defaultFloatTolerance = 1e-12f;

    public static ref readonly GuardValue<float> Equal(
        this in GuardValue<float> guard,
        float value,
        float tolerance = _defaultFloatTolerance)
        => ref guard.Equal<float, float, FloatConditions>(value, tolerance);

    public static ref readonly GuardValue<float> NotEqual(
        this in GuardValue<float> guard,
        float value,
        float tolerance = _defaultFloatTolerance)
        => ref guard.NotEqual<float, float, FloatConditions>(value, tolerance);

    public static ref readonly GuardValue<float> IsDefault(this in GuardValue<float> guard)
        => ref guard.IsDefault<float, FloatConditions>();

    public static ref readonly GuardValue<float> IsNotDefault(this in GuardValue<float> guard)
        => ref guard.IsNotDefault<float, FloatConditions>();

    public static ref readonly GuardValue<float> IsPositive(this in GuardValue<float> guard)
        => ref guard.Greater<float, FloatConditions>(default);

    public static ref readonly GuardValue<float> IsNegative(this in GuardValue<float> guard)
        => ref guard.Less<float, FloatConditions>(default);

    public static ref readonly GuardValue<float> Greater(this in GuardValue<float> guard, float value)
        => ref guard.Greater<float, FloatConditions>(value);

    public static ref readonly GuardValue<float> GreaterOrEqual(this in GuardValue<float> guard, float value)
        => ref guard.GreaterOrEqual<float, FloatConditions>(value);

    public static ref readonly GuardValue<float> Less(this in GuardValue<float> guard, float value)
        => ref guard.Less<float, FloatConditions>(value);

    public static ref readonly GuardValue<float> LessOrEqual(this in GuardValue<float> guard, float value)
        => ref guard.LessOrEqual<float, FloatConditions>(value);

    public static ref readonly GuardValue<float> InRange(
        this in GuardValue<float> guard,
        float min,
        float max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref guard.InRange<float, FloatConditions>(min, max, excludeMin, excludeMax);
}