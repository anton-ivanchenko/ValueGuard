namespace ValueGuard.Tests;

public sealed class GuardValueExtensionsDoubleTests
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(1e-13, 0)]
    public void IsEqual_LessDefaultTolerance_NoException(double value, double expected)
        => Guard.Value(value).IsEqual(expected);

    [Theory]
    [InlineData(1e-10, 0)]
    [InlineData(0.01, 0)]
    [InlineData(1, 0)]
    public void IsEqual_GreaterDefaultTolerance_ThrowException(double value, double expected)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).IsEqual(expected));

    [Theory]
    [InlineData(0, 0, 0.1)]
    [InlineData(0.009, 0, 0.01)]
    public void IsEqual_LessSpecificTolerance_NoException(double value, double expected, double tolerance)
        => Guard.Value(value).IsEqual(expected, tolerance);

    [Theory]
    [InlineData(0.1, 0, 0.1)]
    [InlineData(0.1, 0, 0.01)]
    public void IsEqual_GreaterSpecificTolerance_ThrowException(double value, double expected, double tolerance)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).IsEqual(expected, tolerance));

    [Theory]
    [InlineData(0)]
    public void IsDefault_Zero_NoException(double number)
        => Guard.Value(number).IsDefault();

    [Theory]
    [InlineData(-0.1)]
    [InlineData(-2.0)]
    [InlineData(0.1)]
    [InlineData(2.0)]
    public void IsDefault_NoZero_ThrowException(double number)
        => Assert.Throws<GuardException>(()
            => Guard.Value(number).IsDefault());

    [Theory]
    [InlineData(-0.1)]
    [InlineData(-2.0)]
    [InlineData(0.1)]
    [InlineData(2.0)]
    public void IsNotDefault_NotZero_NoException(double number)
        => Guard.Value(number).IsNotDefault();

    [Theory]
    [InlineData(0)]
    public void IsNotDefault_Zero_ThrowException(double number)
        => Assert.Throws<GuardException>(()
            => Guard.Value(number).IsNotDefault());

    [Theory]
    [InlineData(0.1)]
    [InlineData(1)]
    public void IsPositive_Positive_NoException(double number)
        => Guard.Value(number).IsPositive();

    [Theory]
    [InlineData(0)]
    [InlineData(-0.1)]
    [InlineData(-1)]
    public void IsPositive_NotPositive_ThrowException(double number)
        => Assert.Throws<GuardException>(()
            => Guard.Value(number).IsPositive());

    [Theory]
    [InlineData(-0.1)]
    [InlineData(-1)]
    public void IsNegative_Negative_NoException(double number)
        => Guard.Value(number).IsNegative();

    [Theory]
    [InlineData(0.1)]
    [InlineData(1)]
    public void IsNegative_Positive_ThrowException(double number)
        => Assert.Throws<GuardException>(()
            => Guard.Value(number).IsNegative());

    [Theory]
    [InlineData(0.01, 0)]
    public void IsGreater_GreaterThanValue_NoException(double number, double comparable)
        => Guard.Value(number).IsGreater(comparable);

    [Theory]
    [InlineData(0.01, 0.01)]
    [InlineData(0.99, 1)]
    public void IsGreater_LessOrEqualThanValue_ThrowException(double number, double comparable)
        => Assert.Throws<GuardException>(()
            => Guard.Value(number).IsGreater(comparable));

    [Theory]
    [InlineData(5, 5)]
    [InlineData(8, 5)]
    public void IsGreaterOrEqual_GreaterOrEqualThanValue_NoException(double number, double comparable)
        => Guard.Value(number).IsGreaterOrEqual(comparable);

    [Theory]
    [InlineData(0, 5)]
    public void IsGreaterOrEqual_LessThanValue_ThrowException(double number, double comparable)
        => Assert.Throws<GuardException>(()
            => Guard.Value(number).IsGreaterOrEqual(comparable));

    [Theory]
    [InlineData(0, 5)]
    public void IsLess_LessThanValue_NoException(double number, double comparable)
        => Guard.Value(number).IsLess(comparable);

    [Theory]
    [InlineData(5, 5)]
    [InlineData(8, 5)]
    public void IsLess_GreaterOrEqualThanValue_ThrowException(double number, double comparable)
        => Assert.Throws<GuardException>(()
            => Guard.Value(number).IsLess(comparable));

    [Theory]
    [InlineData(2, 5)]
    [InlineData(5, 5)]
    public void IsLessOrEqual_LessOrEqualThanNumber_NoException(double number, double comparable)
        => Guard.Value(number).IsLessOrEqual(comparable);

    [Theory]
    [InlineData(8, 5)]
    public void IsLessOrEqual_GreaterThanNumber_ThrowException(double number, double comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(number).IsLessOrEqual(comparableValue));

    [Theory]
    [InlineData(0, 0, 1, false, false)]
    [InlineData(0e-20, 0, 1, false, false)]
    [InlineData(1, 0, 1, false, false)]
    [InlineData(1, 0, 1, true, false)]
    [InlineData(0, 0, 1, false, true)]
    [InlineData(0.25, 0, 1, true, true)]
    public void InRange_ValidRange_NoException(double value, double min, double max, bool excludeMin, bool excludeMax)
        => Guard.Value(value).InRange(min, max, excludeMin, excludeMax);

    [Theory]
    [InlineData(0, 0, 1, true, false)]
    [InlineData(1, 0, 1, false, true)]
    [InlineData(0, 0, 1, true, true)]
    [InlineData(1, 0, 1, true, true)]
    public void InRange_InvalidRange_ThrowException(double value, double min, double max, bool excludeMin, bool excludeMax)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).InRange(min, max, excludeMin, excludeMax));
}