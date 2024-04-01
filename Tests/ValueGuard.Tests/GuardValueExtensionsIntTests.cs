namespace ValueGuard.Tests;

public sealed class GuardValueExtensionsIntTests
{
    [Theory]
    [InlineData(10, 10)]
    public void IsEqual_Equals_NoException(int value, int expected)
        => Guard.Value(value).IsEqual(expected);

    [Theory]
    [InlineData(10, 20)]
    public void IsEqual_NoEquals_ThrowException(int value, int expected)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).IsEqual(expected));

    [Fact]
    public void IsDefault_Zero_NoException()
        => Guard.Value(0).IsDefault();

    [Theory]
    [InlineData(-1)]
    [InlineData(1)]
    public void IsDefault_NoZero_ThrowException(int number)
        => Assert.Throws<GuardException>(()
            => Guard.Value(number).IsDefault());

    [Theory]
    [InlineData(-1)]
    [InlineData(1)]
    public void IsNotDefault_NotZero_NoException(int number)
        => Guard.Value(number).IsNotDefault();

    [Fact]
    public void IsNotDefault_Zero_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value(0).IsNotDefault());

    [Fact]
    public void IsPositive_Positive_NoException()
        => Guard.Value(1).IsPositive();

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void IsPositive_NotPositive_ThrowException(int number)
        => Assert.Throws<GuardException>(()
            => Guard.Value(number).IsPositive());

    [Fact]
    public void IsNegative_Negative_NoException()
        => Guard.Value(-1).IsNegative();

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    public void IsNegative_Positive_ThrowException(int number)
        => Assert.Throws<GuardException>(()
            => Guard.Value(number).IsNegative());

    [Theory]
    [InlineData(5, 0)]
    public void IsGreater_GreaterThanValue_NoException(int number, int comparableValue)
        => Guard.Value(number).IsGreater(comparableValue);

    [Theory]
    [InlineData(0, 5)]
    [InlineData(5, 5)]
    public void IsGreater_LessOrEqualThanValue_ThrowException(int number, int comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(number).IsGreater(comparableValue));

    [Theory]
    [InlineData(5, 0)]
    [InlineData(5, 5)]
    public void IsGreaterOrEqual_GreaterOrEqualThanValue_NoException(int number, int comparableValue)
        => Guard.Value(number).IsGreaterOrEqual(comparableValue);

    [Theory]
    [InlineData(0, 5)]
    public void IsGreaterOrEqual_LessThanValue_ThrowException(int number, int comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(number).IsGreaterOrEqual(comparableValue));

    [Theory]
    [InlineData(0, 5)]
    public void IsLess_LessThanValue_NoException(int number, int comparableValue)
        => Guard.Value(number).IsLess(comparableValue);

    [Theory]
    [InlineData(5, 0)]
    [InlineData(5, 5)]
    public void IsLess_GreaterOrEqualThanValue_ThrowException(int number, int comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(number).IsLess(comparableValue));

    [Theory]
    [InlineData(2, 5)]
    [InlineData(5, 5)]
    public void IsLessOrEqual_LessOrEqualThanNumber_NoException(int number, int comparableValue)
        => Guard.Value(number).IsLessOrEqual(comparableValue);

    [Theory]
    [InlineData(8, 5)]
    public void IsLessOrEqual_GreaterThanNumber_ThrowException(int number, int comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(number).IsLessOrEqual(comparableValue));

    [Theory]
    [InlineData(0, 0, 10, false, false)]
    [InlineData(5, 0, 10, false, false)]
    [InlineData(10, 0, 10, false, false)]
    [InlineData(10, 0, 10, true, false)]
    [InlineData(5, 0, 10, false, true)]
    [InlineData(5, 0, 10, true, true)]
    public void InRange_ValidRange_NoException(int value, int min, int max, bool excludeMin, bool excludeMax)
        => Guard.Value(value).InRange(min, max, excludeMin, excludeMax);

    [Theory]
    [InlineData(0, 0, 10, true, false)]
    [InlineData(10, 0, 10, false, true)]
    [InlineData(0, 0, 10, true, true)]
    [InlineData(10, 0, 10, true, true)]
    public void InRange_InvalidRange_ThrowException(int value, int min, int max, bool excludeMin, bool excludeMax)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).InRange(min, max, excludeMin, excludeMax));
}