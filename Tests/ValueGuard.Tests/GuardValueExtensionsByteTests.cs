namespace ValueGuard.Tests;

public sealed class GuardValueExtensionsByteTests
{
    [Theory]
    [InlineData(1, 1)]
    public void IsEqual_Equals_NoException(byte value, byte comparableValue)
        => Guard.Value(value).IsEqual(comparableValue);

    [Theory]
    [InlineData(1, 2)]
    public void IsEqual_NoEquals_ThrowException(byte value, byte comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).IsEqual(comparableValue));

    [Theory]
    [InlineData(0, 2)]
    public void IsNotEqual_NotEquals_NoException(byte value, byte comparableValue)
        => Guard.Value(value).IsNotEqual(comparableValue);

    [Theory]
    [InlineData(0, 0)]
    public void IsNotEqual_Equals_ThrowException(byte value, byte comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).IsNotEqual(comparableValue));

    [Theory]
    [InlineData(default(byte))]
    public void IsDefault_Zero_NoException(byte value)
        => Guard.Value(value).IsDefault();

    [Theory]
    [InlineData(1)]
    public void IsDefault_NoZero_ThrowException(byte value)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).IsDefault());

    [Theory]
    [InlineData(1)]
    public void IsNotDefault_NotZero_NoException(byte value)
        => Guard.Value(value).IsNotDefault();

    [Theory]
    [InlineData(default(byte))]
    public void IsNotDefault_Zero_ThrowException(byte value)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).IsNotDefault());

    [Theory]
    [InlineData(5, 0)]
    public void IsGreater_GreaterThanValue_NoException(byte value, byte comparableValue)
        => Guard.Value(value).IsGreater(comparableValue);

    [Theory]
    [InlineData(0, 5)]
    [InlineData(5, 5)]
    public void IsGreater_LessOrEqualThanValue_ThrowException(byte value, byte comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).IsGreater(comparableValue));

    [Theory]
    [InlineData(5, 0)]
    [InlineData(5, 5)]
    public void IsGreaterOrEqual_GreaterOrEqualThanValue_NoException(byte value, byte comparableValue)
        => Guard.Value(value).IsGreaterOrEqual(comparableValue);

    [Theory]
    [InlineData(0, 5)]
    public void IsGreaterOrEqual_LessThanValue_ThrowException(byte value, byte comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).IsGreaterOrEqual(comparableValue));

    [Theory]
    [InlineData(0, 5)]
    public void IsLess_LessThanValue_NoException(byte value, byte comparableValue)
        => Guard.Value(value).IsLess(comparableValue);

    [Theory]
    [InlineData(5, 0)]
    [InlineData(5, 5)]
    public void IsLess_GreaterOrEqualThanValue_ThrowException(byte value, byte comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).IsLess(comparableValue));

    [Theory]
    [InlineData(2, 5)]
    [InlineData(5, 5)]
    public void IsLessOrEqual_LessOrEqualThanNumber_NoException(byte value, byte comparableValue)
        => Guard.Value(value).IsLessOrEqual(comparableValue);

    [Theory]
    [InlineData(8, 5)]
    public void IsLessOrEqual_GreaterThanNumber_ThrowException(byte value, byte comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).IsLessOrEqual(comparableValue));

    [Theory]
    [InlineData(0, 0, 10, false, false)]
    [InlineData(5, 0, 10, false, false)]
    [InlineData(10, 0, 10, false, false)]
    [InlineData(10, 0, 10, true, false)]
    [InlineData(5, 0, 10, false, true)]
    [InlineData(5, 0, 10, true, true)]
    public void InRange_ValidRange_NoException(byte value, byte min, byte max, bool excludeMin, bool excludeMax)
        => Guard.Value(value).InRange(min, max, excludeMin, excludeMax);

    [Theory]
    [InlineData(0, 0, 10, true, false)]
    [InlineData(10, 0, 10, false, true)]
    [InlineData(0, 0, 10, true, true)]
    [InlineData(10, 0, 10, true, true)]
    public void InRange_InvalidRange_ThrowException(byte value, byte min, byte max, bool excludeMin, bool excludeMax)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).InRange(min, max, excludeMin, excludeMax));
}