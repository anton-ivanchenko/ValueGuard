namespace ValueGuard.Tests.Numbers;

public sealed class GuardValueExtensionsFloatTests
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(1e-13, 0)]
    public void EqualTo_LessDefaultTolerance_NoException(float value, float comparableValue)
        => Guard.Value(value).EqualTo(comparableValue);

    [Theory]
    [InlineData(1e-10, 0)]
    [InlineData(0.01, 0)]
    [InlineData(1, 0)]
    public void EqualTo_GreaterDefaultTolerance_ThrowException(float value, float comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).EqualTo(comparableValue));

    [Theory]
    [InlineData(0, 0, 0.1)]
    [InlineData(0.009, 0, 0.01)]
    public void EqualTo_LessSpecificTolerance_NoException(float value, float comparableValue, float tolerance)
        => Guard.Value(value).EqualTo(comparableValue, tolerance);

    [Theory]
    [InlineData(0.1, 0, 0.1)]
    [InlineData(0.1, 0, 0.01)]
    public void EqualTo_GreaterSpecificTolerance_ThrowException(float value, float comparableValue, float tolerance)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).EqualTo(comparableValue, tolerance));

    [Theory]
    [InlineData(1e-10, 0)]
    public void IsNotEqualTo_GreaterDefaultTolerance_NoException(float value, float comparableValue)
        => Guard.Value(value).NotEqualTo(comparableValue);

    [Theory]
    [InlineData(1e-13, 0)]
    public void IsNotEqualTo_LessDefaultTolerance_ThrowException(float value, float comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).NotEqualTo(comparableValue));

    [Theory]
    [InlineData(0, 0.1, 0.1)]
    [InlineData(0, 0.2, 0.1)]
    public void IsNotEqualTo_GreaterSpecificTolerance_NoException(float value, float comparableValue, float tolerance)
        => Guard.Value(value).NotEqualTo(comparableValue, tolerance);

    [Theory]
    [InlineData(0, 0.01, 0.1)]
    public void IsNotEqualTo_LessSpecificTolerance_ThrowException(float value, float comparableValue, float tolerance)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).NotEqualTo(comparableValue, tolerance));

    [Theory]
    [InlineData(0)]
    public void IsDefault_Zero_NoException(float value)
        => Guard.Value(value).IsDefault();

    [Theory]
    [InlineData(-0.1)]
    [InlineData(-2.0)]
    [InlineData(0.1)]
    [InlineData(2.0)]
    public void IsDefault_NoZero_ThrowException(float value)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).IsDefault());

    [Theory]
    [InlineData(-0.1)]
    [InlineData(-2.0)]
    [InlineData(0.1)]
    [InlineData(2.0)]
    public void IsNotDefault_NotZero_NoException(float value)
        => Guard.Value(value).NotDefault();

    [Theory]
    [InlineData(0)]
    public void IsNotDefault_Zero_ThrowException(float value)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).NotDefault());

    [Theory]
    [InlineData(0.1)]
    [InlineData(1)]
    public void IsPositive_Positive_NoException(float value)
        => Guard.Value(value).IsPositive();

    [Theory]
    [InlineData(0)]
    [InlineData(-0.1)]
    [InlineData(-1)]
    public void IsPositive_NotPositive_ThrowException(float value)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).IsPositive());

    [Theory]
    [InlineData(-0.1)]
    [InlineData(-1)]
    public void IsNegative_Negative_NoException(float value)
        => Guard.Value(value).IsNegative();

    [Theory]
    [InlineData(0.1)]
    [InlineData(1)]
    public void IsNegative_Positive_ThrowException(float value)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).IsNegative());

    [Theory]
    [InlineData(0.01, 0)]
    public void GreaterThan_GreaterThanValue_NoException(float value, float comparableValue)
        => Guard.Value(value).GreaterThan(comparableValue);

    [Theory]
    [InlineData(0.01, 0.01)]
    [InlineData(0.99, 1)]
    public void GreaterThan_LessOrEqualThanValue_ThrowException(float value, float comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).GreaterThan(comparableValue));

    [Theory]
    [InlineData(5, 5)]
    [InlineData(8, 5)]
    public void GreaterThanOrEqualTo_GreaterOrEqualThanValue_NoException(float value, float comparableValue)
        => Guard.Value(value).GreaterThanOrEqualTo(comparableValue);

    [Theory]
    [InlineData(0, 5)]
    public void GreaterThanOrEqualTo_LessThanValue_ThrowException(float value, float comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).GreaterThanOrEqualTo(comparableValue));

    [Theory]
    [InlineData(0, 5)]
    public void LessThan_LessThanValue_NoException(float value, float comparableValue)
        => Guard.Value(value).LessThan(comparableValue);

    [Theory]
    [InlineData(5, 5)]
    [InlineData(8, 5)]
    public void LessThan_GreaterOrEqualThanValue_ThrowException(float value, float comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).LessThan(comparableValue));

    [Theory]
    [InlineData(2, 5)]
    [InlineData(5, 5)]
    public void LessThanOrEqualTo_LessOrEqualThanComparableValue_NoException(float value, float comparableValue)
        => Guard.Value(value).LessThanOrEqualTo(comparableValue);

    [Theory]
    [InlineData(8, 5)]
    public void LessThanOrEqualTo_GreaterThanComparableValue_ThrowException(float value, float comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).LessThanOrEqualTo(comparableValue));

    [Theory]
    [InlineData(0, 0, 1, false, false)]
    [InlineData(0e-20, 0, 1, false, false)]
    [InlineData(1, 0, 1, false, false)]
    [InlineData(1, 0, 1, true, false)]
    [InlineData(0, 0, 1, false, true)]
    [InlineData(0.25, 0, 1, true, true)]
    public void InRange_ValidRange_NoException(float value, float min, float max, bool excludeMin, bool excludeMax)
        => Guard.Value(value).InRange(min, max, excludeMin, excludeMax);

    [Theory]
    [InlineData(0, 0, 1, true, false)]
    [InlineData(1, 0, 1, false, true)]
    [InlineData(0, 0, 1, true, true)]
    [InlineData(1, 0, 1, true, true)]
    public void InRange_InvalidRange_ThrowException(float value, float min, float max, bool excludeMin, bool excludeMax)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).InRange(min, max, excludeMin, excludeMax));
}