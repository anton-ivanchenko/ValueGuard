using ValueGuard.Internal;
using ValueGuard.Internal.Conditions.Numbers;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    private const decimal DefaultDecimalTolerance = 1e-12M;

    public static ref readonly GuardValue<decimal> IsEqual(
        this in GuardValue<decimal> guard,
        decimal value,
        decimal tolerance = DefaultDecimalTolerance)
        => ref guard.IsEqual<decimal, DecimalConditions>(value, tolerance);

    public static ref readonly GuardValue<decimal> IsNotEqual(
        this in GuardValue<decimal> guard,
        decimal value,
        decimal tolerance = DefaultDecimalTolerance)
        => ref guard.IsNotEqual<decimal, DecimalConditions>(value, tolerance);

    public static ref readonly GuardValue<decimal> IsDefault(this in GuardValue<decimal> guard)
        => ref guard.IsDefault<decimal, DecimalConditions>();

    public static ref readonly GuardValue<decimal> IsNotDefault(this in GuardValue<decimal> guard)
        => ref guard.IsNotDefault<decimal, DecimalConditions>();

    public static ref readonly GuardValue<decimal> IsPositive(this in GuardValue<decimal> guard)
        => ref guard.IsGreater<decimal, DecimalConditions>(default);

    public static ref readonly GuardValue<decimal> IsNegative(this in GuardValue<decimal> guard)
        => ref guard.IsLess<decimal, DecimalConditions>(default);

    public static ref readonly GuardValue<decimal> IsGreater(this in GuardValue<decimal> guard, decimal value)
        => ref guard.IsGreater<decimal, DecimalConditions>(value);

    public static ref readonly GuardValue<decimal> IsGreaterOrEqual(this in GuardValue<decimal> guard, decimal value)
        => ref guard.IsGreaterOrEqual<decimal, DecimalConditions>(value);

    public static ref readonly GuardValue<decimal> IsLess(this in GuardValue<decimal> guard, decimal value)
        => ref guard.IsLess<decimal, DecimalConditions>(value);

    public static ref readonly GuardValue<decimal> IsLessOrEqual(this in GuardValue<decimal> guard, decimal value)
        => ref guard.IsLessOrEqual<decimal, DecimalConditions>(value);

    public static ref readonly GuardValue<decimal> InRange(
        this in GuardValue<decimal> guard,
        decimal min,
        decimal max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref guard.InRange<decimal, DecimalConditions>(min, max, excludeMin, excludeMax);
}