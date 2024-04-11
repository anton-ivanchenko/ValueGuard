namespace ValueGuard.Tests;

public sealed class GuardValueExtensionsDecimalTests
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(1e-13, 0)]
    public void IsEqual_LessDefaultTolerance_NoException(decimal value, decimal comparableValue)
        => Guard.Value(value).IsEqual(comparableValue);

    [Theory]
    [InlineData(1e-10, 0)]
    [InlineData(0.01, 0)]
    [InlineData(1, 0)]
    public void IsEqual_GreaterDefaultTolerance_ThrowException(decimal value, decimal comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).IsEqual(comparableValue));

    [Theory]
    [InlineData(0, 0, 0.1)]
    [InlineData(0.009, 0, 0.01)]
    public void IsEqual_LessSpecificTolerance_NoException(decimal value, decimal comparableValue, decimal tolerance)
        => Guard.Value(value).IsEqual(comparableValue, tolerance);

    [Theory]
    [InlineData(0.1, 0, 0.1)]
    [InlineData(0.1, 0, 0.01)]
    public void IsEqual_GreaterSpecificTolerance_ThrowException(decimal value, decimal comparableValue, decimal tolerance)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).IsEqual(comparableValue, tolerance));

    [Theory]
    [InlineData(1e-10, 0)]
    public void IsNotEqual_GreaterDefaultTolerance_NoException(decimal value, decimal comparableValue)
        => Guard.Value(value).IsNotEqual(comparableValue);

    [Theory]
    [InlineData(1e-13, 0)]
    public void IsNotEqual_LessDefaultTolerance_ThrowException(decimal value, decimal comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).IsNotEqual(comparableValue));

    [Theory]
    [InlineData(0, 0.1, 0.1)]
    [InlineData(0, 0.2, 0.1)]
    public void IsNotEqual_GreaterSpecificTolerance_NoException(decimal value, decimal comparableValue, decimal tolerance)
        => Guard.Value(value).IsNotEqual(comparableValue, tolerance);

    [Theory]
    [InlineData(0, 0.01, 0.1)]
    public void IsNotEqual_LessSpecificTolerance_ThrowException(decimal value, decimal comparableValue, decimal tolerance)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).IsNotEqual(comparableValue, tolerance));

    [Theory]
    [InlineData(0)]
    public void IsDefault_Zero_NoException(decimal value)
        => Guard.Value(value).IsDefault();

    [Theory]
    [InlineData(-0.1)]
    [InlineData(-2.0)]
    [InlineData(0.1)]
    [InlineData(2.0)]
    public void IsDefault_NoZero_ThrowException(decimal value)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).IsDefault());

    [Theory]
    [InlineData(-0.1)]
    [InlineData(-2.0)]
    [InlineData(0.1)]
    [InlineData(2.0)]
    public void IsNotDefault_NotZero_NoException(decimal value)
        => Guard.Value(value).IsNotDefault();

    [Theory]
    [InlineData(0)]
    public void IsNotDefault_Zero_ThrowException(decimal value)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).IsNotDefault());

    [Theory]
    [InlineData(0.1)]
    [InlineData(1)]
    public void IsPositive_Positive_NoException(decimal value)
        => Guard.Value(value).IsPositive();

    [Theory]
    [InlineData(0)]
    [InlineData(-0.1)]
    [InlineData(-1)]
    public void IsPositive_NotPositive_ThrowException(decimal value)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).IsPositive());

    [Theory]
    [InlineData(-0.1)]
    [InlineData(-1)]
    public void IsNegative_Negative_NoException(decimal value)
        => Guard.Value(value).IsNegative();

    [Theory]
    [InlineData(0.1)]
    [InlineData(1)]
    public void IsNegative_Positive_ThrowException(decimal value)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).IsNegative());

    [Theory]
    [InlineData(0.01, 0)]
    public void IsGreater_GreaterThanValue_NoException(decimal value, decimal comparableValue)
        => Guard.Value(value).IsGreater(comparableValue);

    [Theory]
    [InlineData(0.01, 0.01)]
    [InlineData(0.99, 1)]
    public void IsGreater_LessOrEqualThanValue_ThrowException(decimal value, decimal comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).IsGreater(comparableValue));

    [Theory]
    [InlineData(5, 5)]
    [InlineData(8, 5)]
    public void IsGreaterOrEqual_GreaterOrEqualThanValue_NoException(decimal value, decimal comparableValue)
        => Guard.Value(value).IsGreaterOrEqual(comparableValue);

    [Theory]
    [InlineData(0, 5)]
    public void IsGreaterOrEqual_LessThanValue_ThrowException(decimal value, decimal comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).IsGreaterOrEqual(comparableValue));

    [Theory]
    [InlineData(0, 5)]
    public void IsLess_LessThanValue_NoException(decimal value, decimal comparableValue)
        => Guard.Value(value).IsLess(comparableValue);

    [Theory]
    [InlineData(5, 5)]
    [InlineData(8, 5)]
    public void IsLess_GreaterOrEqualThanValue_ThrowException(decimal value, decimal comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).IsLess(comparableValue));

    [Theory]
    [InlineData(2, 5)]
    [InlineData(5, 5)]
    public void IsLessOrEqual_LessOrEqualThanComparableValue_NoException(decimal value, decimal comparableValue)
        => Guard.Value(value).IsLessOrEqual(comparableValue);

    [Theory]
    [InlineData(8, 5)]
    public void IsLessOrEqual_GreaterThanComparableValue_ThrowException(decimal value, decimal comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).IsLessOrEqual(comparableValue));

    [Theory]
    [InlineData(0, 0, 1, false, false)]
    [InlineData(0e-20, 0, 1, false, false)]
    [InlineData(1, 0, 1, false, false)]
    [InlineData(1, 0, 1, true, false)]
    [InlineData(0, 0, 1, false, true)]
    [InlineData(0.25, 0, 1, true, true)]
    public void InRange_ValidRange_NoException(decimal value, decimal min, decimal max, bool excludeMin, bool excludeMax)
        => Guard.Value(value).InRange(min, max, excludeMin, excludeMax);

    [Theory]
    [InlineData(0, 0, 1, true, false)]
    [InlineData(1, 0, 1, false, true)]
    [InlineData(0, 0, 1, true, true)]
    [InlineData(1, 0, 1, true, true)]
    public void InRange_InvalidRange_ThrowException(decimal value, decimal min, decimal max, bool excludeMin, bool excludeMax)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).InRange(min, max, excludeMin, excludeMax));
}