namespace ValueGuard.Tests.Numbers;

public sealed class GuardValueExtensionsByteTests
{
    [Theory]
    [InlineData(1, 1)]
    public void EqualTo_Equals_NoException(byte value, byte comparableValue)
        => Guard.Value(value).EqualTo(comparableValue);

    [Theory]
    [InlineData(1, 2)]
    public void EqualTo_NoEquals_ThrowException(byte value, byte comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).EqualTo(comparableValue));

    [Theory]
    [InlineData(0, 2)]
    public void IsNotEqualTo_NotEquals_NoException(byte value, byte comparableValue)
        => Guard.Value(value).NotEqualTo(comparableValue);

    [Theory]
    [InlineData(0, 0)]
    public void IsNotEqualTo_Equals_ThrowException(byte value, byte comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).NotEqualTo(comparableValue));

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
        => Guard.Value(value).NotDefault();

    [Theory]
    [InlineData(default(byte))]
    public void IsNotDefault_Zero_ThrowException(byte value)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).NotDefault());

    [Theory]
    [InlineData(5, 0)]
    public void GreaterThan_GreaterThanValue_NoException(byte value, byte comparableValue)
        => Guard.Value(value).GreaterThan(comparableValue);

    [Theory]
    [InlineData(0, 5)]
    [InlineData(5, 5)]
    public void GreaterThan_LessOrEqualThanValue_ThrowException(byte value, byte comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).GreaterThan(comparableValue));

    [Theory]
    [InlineData(5, 0)]
    [InlineData(5, 5)]
    public void GreaterThanOrEqualTo_GreaterOrEqualThanValue_NoException(byte value, byte comparableValue)
        => Guard.Value(value).GreaterThanOrEqualTo(comparableValue);

    [Theory]
    [InlineData(0, 5)]
    public void GreaterThanOrEqualTo_LessThanValue_ThrowException(byte value, byte comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).GreaterThanOrEqualTo(comparableValue));

    [Theory]
    [InlineData(0, 5)]
    public void LessThan_LessThanValue_NoException(byte value, byte comparableValue)
        => Guard.Value(value).LessThan(comparableValue);

    [Theory]
    [InlineData(5, 0)]
    [InlineData(5, 5)]
    public void LessThan_GreaterOrEqualThanValue_ThrowException(byte value, byte comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).LessThan(comparableValue));

    [Theory]
    [InlineData(2, 5)]
    [InlineData(5, 5)]
    public void LessThanOrEqualTo_LessOrEqualThanNumber_NoException(byte value, byte comparableValue)
        => Guard.Value(value).LessThanOrEqualTo(comparableValue);

    [Theory]
    [InlineData(8, 5)]
    public void LessThanOrEqualTo_GreaterThanNumber_ThrowException(byte value, byte comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).LessThanOrEqualTo(comparableValue));

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