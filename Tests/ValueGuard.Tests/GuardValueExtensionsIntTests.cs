using ValueGuard.Exceptions;

namespace ValueGuard.Tests;

public class GuardValueExtensionsIntTests
{
    [Fact]
    public void IsZero_Zero_NoException()
        => Guard.Value(0).IsZero();

    [Theory]
    [InlineData(-1)]
    [InlineData(1)]
    public void IsZero_NoZero_ThrowException(int number)
        => Assert.Throws<GuardException>(()
            => Guard.Value(number).IsZero());

    [Theory]
    [InlineData(-1)]
    [InlineData(1)]
    public void IsNotZero_NotZero_NoException(int number)
        => Guard.Value(number).IsNotZero();

    [Fact]
    public void IsNotZero_Zero_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value(0).IsNotZero());

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
    public void Greater_GreaterThanValue_NoException(int number, int comparableValue)
        => Guard.Value(number).Greater(comparableValue);

    [Theory]
    [InlineData(0, 5)]
    [InlineData(5, 5)]
    public void Greater_LessOrEqualThanValue_ThrowException(int number, int comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(number).Greater(comparableValue));

    [Theory]
    [InlineData(5, 0)]
    [InlineData(5, 5)]
    public void GreaterOrEqual_GreaterOrEqualThanValue_NoException(int number, int comparableValue)
        => Guard.Value(number).GreaterOrEqual(comparableValue);

    [Theory]
    [InlineData(0, 5)]
    public void GreaterOrEqual_LessThanValue_ThrowException(int number, int comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(number).GreaterOrEqual(comparableValue));

    [Theory]
    [InlineData(0, 5)]
    public void Less_LessThanValue_NoException(int number, int comparableValue)
        => Guard.Value(number).Less(comparableValue);

    [Theory]
    [InlineData(5, 0)]
    [InlineData(5, 5)]
    public void Less_GreaterOrEqualThanValue_ThrowException(int number, int comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(number).Less(comparableValue));

    [Theory]
    [InlineData(2, 5)]
    [InlineData(5, 5)]
    public void LessOrEqual_LessOrEqualThanNumber_NoException(int number, int comparableValue)
        => Guard.Value(number).LessOrEqual(comparableValue);

    [Theory]
    [InlineData(8, 5)]
    public void LessOrEqual_GreaterThanNumber_ThrowException(int number, int comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(number).LessOrEqual(comparableValue));

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