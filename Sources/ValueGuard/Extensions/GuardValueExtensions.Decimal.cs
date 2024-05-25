using ValueGuard.Internal;
using ValueGuard.Internal.Conditions.Numbers;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    private const decimal _defaultDecimalTolerance = 1e-12M;

    public static ref readonly GuardValue<decimal> Equal(
        this in GuardValue<decimal> guard,
        decimal value,
        decimal tolerance = _defaultDecimalTolerance)
        => ref guard.Equal<decimal, decimal, DecimalConditions>(value, tolerance);

    public static ref readonly GuardValue<decimal> NotEqual(
        this in GuardValue<decimal> guard,
        decimal value,
        decimal tolerance = _defaultDecimalTolerance)
        => ref guard.NotEqual<decimal, decimal, DecimalConditions>(value, tolerance);

    public static ref readonly GuardValue<decimal> IsDefault(this in GuardValue<decimal> guard)
        => ref guard.IsDefault<decimal, DecimalConditions>();

    public static ref readonly GuardValue<decimal> IsNotDefault(this in GuardValue<decimal> guard)
        => ref guard.IsNotDefault<decimal, DecimalConditions>();

    public static ref readonly GuardValue<decimal> IsPositive(this in GuardValue<decimal> guard)
        => ref guard.Greater<decimal, DecimalConditions>(default);

    public static ref readonly GuardValue<decimal> IsNegative(this in GuardValue<decimal> guard)
        => ref guard.Less<decimal, DecimalConditions>(default);

    public static ref readonly GuardValue<decimal> Greater(this in GuardValue<decimal> guard, decimal value)
        => ref guard.Greater<decimal, DecimalConditions>(value);

    public static ref readonly GuardValue<decimal> GreaterOrEqual(this in GuardValue<decimal> guard, decimal value)
        => ref guard.GreaterOrEqual<decimal, DecimalConditions>(value);

    public static ref readonly GuardValue<decimal> Less(this in GuardValue<decimal> guard, decimal value)
        => ref guard.Less<decimal, DecimalConditions>(value);

    public static ref readonly GuardValue<decimal> LessOrEqual(this in GuardValue<decimal> guard, decimal value)
        => ref guard.LessOrEqual<decimal, DecimalConditions>(value);

    public static ref readonly GuardValue<decimal> InRange(
        this in GuardValue<decimal> guard,
        decimal min,
        decimal max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref guard.InRange<decimal, DecimalConditions>(min, max, excludeMin, excludeMax);
}