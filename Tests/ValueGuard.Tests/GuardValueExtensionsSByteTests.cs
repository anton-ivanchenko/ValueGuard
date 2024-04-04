namespace ValueGuard.Tests;

public sealed class GuardValueExtensionsSByteTests
{
    [Theory]
    [InlineData(10, 10)]
    public void IsEqual_Equals_NoException(sbyte value, sbyte expected)
        => Guard.Value(value).IsEqual(expected);

    [Theory]
    [InlineData(10, 20)]
    public void IsEqual_NoEquals_ThrowException(sbyte value, sbyte expected)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).IsEqual(expected));

    [Theory]
    [InlineData(0, 2)]
    public void IsNotEqual_NotEquals_NoException(sbyte value, sbyte expected)
        => Guard.Value(value).IsNotEqual(expected);

    [Theory]
    [InlineData(0, 0)]
    public void IsNotEqual_Equals_ThrowException(sbyte value, sbyte expected)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).IsNotEqual(expected));

    [Theory]
    [InlineData(default(sbyte))]
    public void IsDefault_Zero_NoException(sbyte number)
        => Guard.Value(number).IsDefault();

    [Theory]
    [InlineData(-1)]
    [InlineData(1)]
    public void IsDefault_NoZero_ThrowException(sbyte number)
        => Assert.Throws<GuardException>(()
            => Guard.Value(number).IsDefault());

    [Theory]
    [InlineData(-1)]
    [InlineData(1)]
    public void IsNotDefault_NotZero_NoException(sbyte number)
        => Guard.Value(number).IsNotDefault();

    [Theory]
    [InlineData(default(sbyte))]
    public void IsNotDefault_Zero_ThrowException(sbyte number)
        => Assert.Throws<GuardException>(()
            => Guard.Value(number).IsNotDefault());

    [Theory]
    [InlineData(1)]
    public void IsPositive_Positive_NoException(sbyte number)
        => Guard.Value(number).IsPositive();

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void IsPositive_NotPositive_ThrowException(sbyte number)
        => Assert.Throws<GuardException>(()
            => Guard.Value(number).IsPositive());

    [Theory]
    [InlineData(-1)]
    public void IsNegative_Negative_NoException(sbyte number)
        => Guard.Value(number).IsNegative();

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    public void IsNegative_Positive_ThrowException(sbyte number)
        => Assert.Throws<GuardException>(()
            => Guard.Value(number).IsNegative());

    [Theory]
    [InlineData(5, 0)]
    public void IsGreater_GreaterThanValue_NoException(sbyte number, sbyte comparableValue)
        => Guard.Value(number).IsGreater(comparableValue);

    [Theory]
    [InlineData(0, 5)]
    [InlineData(5, 5)]
    public void IsGreater_LessOrEqualThanValue_ThrowException(sbyte number, sbyte comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(number).IsGreater(comparableValue));

    [Theory]
    [InlineData(5, 0)]
    [InlineData(5, 5)]
    public void IsGreaterOrEqual_GreaterOrEqualThanValue_NoException(sbyte number, sbyte comparableValue)
        => Guard.Value(number).IsGreaterOrEqual(comparableValue);

    [Theory]
    [InlineData(0, 5)]
    public void IsGreaterOrEqual_LessThanValue_ThrowException(sbyte number, sbyte comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(number).IsGreaterOrEqual(comparableValue));

    [Theory]
    [InlineData(0, 5)]
    public void IsLess_LessThanValue_NoException(sbyte number, sbyte comparableValue)
        => Guard.Value(number).IsLess(comparableValue);

    [Theory]
    [InlineData(5, 0)]
    [InlineData(5, 5)]
    public void IsLess_GreaterOrEqualThanValue_ThrowException(sbyte number, sbyte comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(number).IsLess(comparableValue));

    [Theory]
    [InlineData(2, 5)]
    [InlineData(5, 5)]
    public void IsLessOrEqual_LessOrEqualThanNumber_NoException(sbyte number, sbyte comparableValue)
        => Guard.Value(number).IsLessOrEqual(comparableValue);

    [Theory]
    [InlineData(8, 5)]
    public void IsLessOrEqual_GreaterThanNumber_ThrowException(sbyte number, sbyte comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(number).IsLessOrEqual(comparableValue));

    [Theory]
    [InlineData(0, 0, 10, false, false)]
    [InlineData(5, 0, 10, false, false)]
    [InlineData(10, 0, 10, false, false)]
    [InlineData(10, 0, 10, true, false)]
    [InlineData(5, 0, 10, false, true)]
    [InlineData(5, 0, 10, true, true)]
    public void InRange_ValidRange_NoException(sbyte value, sbyte min, sbyte max, bool excludeMin, bool excludeMax)
        => Guard.Value(value).InRange(min, max, excludeMin, excludeMax);

    [Theory]
    [InlineData(0, 0, 10, true, false)]
    [InlineData(10, 0, 10, false, true)]
    [InlineData(0, 0, 10, true, true)]
    [InlineData(10, 0, 10, true, true)]
    public void InRange_InvalidRange_ThrowException(sbyte value, sbyte min, sbyte max, bool excludeMin, bool excludeMax)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).InRange(min, max, excludeMin, excludeMax));
}