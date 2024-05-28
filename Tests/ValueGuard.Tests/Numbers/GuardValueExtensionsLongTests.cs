namespace ValueGuard.Tests.Numbers;

public sealed class GuardValueExtensionsLongTests
{
    [Theory]
    [InlineData(10, 10)]
    public void EqualTo_Equals_NoException(long value, long comparableValue)
        => Guard.Value(value).EqualTo(comparableValue);

    [Theory]
    [InlineData(10, 20)]
    public void EqualTo_NoEquals_ThrowException(long value, long comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).EqualTo(comparableValue));

    [Theory]
    [InlineData(0, 2)]
    public void IsNotEqualTo_NotEquals_NoException(long value, long comparableValue)
        => Guard.Value(value).NotEqualTo(comparableValue);

    [Theory]
    [InlineData(0, 0)]
    public void IsNotEqualTo_Equals_ThrowException(long value, long comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).NotEqualTo(comparableValue));

    [Theory]
    [InlineData(0)]
    public void IsDefault_Zero_NoException(long value)
        => Guard.Value(value).IsDefault();

    [Theory]
    [InlineData(-1)]
    [InlineData(1)]
    public void IsDefault_NoZero_ThrowException(long value)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).IsDefault());

    [Theory]
    [InlineData(-1)]
    [InlineData(1)]
    public void IsNotDefault_NotZero_NoException(long value)
        => Guard.Value(value).NotDefault();

    [Theory]
    [InlineData(0)]
    public void IsNotDefault_Zero_ThrowException(long value)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).NotDefault());

    [Theory]
    [InlineData(1)]
    public void IsPositive_Positive_NoException(long value)
        => Guard.Value(value).IsPositive();

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void IsPositive_NotPositive_ThrowException(long value)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).IsPositive());

    [Theory]
    [InlineData(-1)]
    public void IsNegative_Negative_NoException(long value)
        => Guard.Value(value).IsNegative();

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    public void IsNegative_Positive_ThrowException(long value)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).IsNegative());

    [Theory]
    [InlineData(5, 0)]
    public void GreaterThan_GreaterThanValue_NoException(long value, long comparableValue)
        => Guard.Value(value).GreaterThan(comparableValue);

    [Theory]
    [InlineData(0, 5)]
    [InlineData(5, 5)]
    public void GreaterThan_LessOrEqualThanValue_ThrowException(long value, long comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).GreaterThan(comparableValue));

    [Theory]
    [InlineData(5, 0)]
    [InlineData(5, 5)]
    public void GreaterThanOrEqualTo_GreaterOrEqualThanValue_NoException(long value, long comparableValue)
        => Guard.Value(value).GreaterThanOrEqualTo(comparableValue);

    [Theory]
    [InlineData(0, 5)]
    public void GreaterThanOrEqualTo_LessThanValue_ThrowException(long value, long comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).GreaterThanOrEqualTo(comparableValue));

    [Theory]
    [InlineData(0, 5)]
    public void LessThan_LessThanValue_NoException(long value, long comparableValue)
        => Guard.Value(value).LessThan(comparableValue);

    [Theory]
    [InlineData(5, 0)]
    [InlineData(5, 5)]
    public void LessThan_GreaterOrEqualThanValue_ThrowException(long value, long comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).LessThan(comparableValue));

    [Theory]
    [InlineData(2, 5)]
    [InlineData(5, 5)]
    public void LessThanOrEqualTo_LessOrEqualThanNumber_NoException(long value, long comparableValue)
        => Guard.Value(value).LessThanOrEqualTo(comparableValue);

    [Theory]
    [InlineData(8, 5)]
    public void LessThanOrEqualTo_GreaterThanNumber_ThrowException(long value, long comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).LessThanOrEqualTo(comparableValue));

    [Theory]
    [InlineData(0, 0, 10, false, false)]
    [InlineData(5, 0, 10, false, false)]
    [InlineData(10, 0, 10, false, false)]
    [InlineData(10, 0, 10, true, false)]
    [InlineData(5, 0, 10, false, true)]
    [InlineData(5, 0, 10, true, true)]
    public void InRange_ValidRange_NoException(long value, long min, long max, bool excludeMin, bool excludeMax)
        => Guard.Value(value).InRange(min, max, excludeMin, excludeMax);

    [Theory]
    [InlineData(0, 0, 10, true, false)]
    [InlineData(10, 0, 10, false, true)]
    [InlineData(0, 0, 10, true, true)]
    [InlineData(10, 0, 10, true, true)]
    public void InRange_InvalidRange_ThrowException(long value, long min, long max, bool excludeMin, bool excludeMax)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).InRange(min, max, excludeMin, excludeMax));
}