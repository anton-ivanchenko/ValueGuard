namespace ValueGuard.Tests.Extensions;

public sealed class GuardValueExtensionsUIntTests
{
    [Theory]
    [InlineData(1, 1)]
    public void IsEqual_Equals_NoException(uint value, uint comparableValue)
        => Guard.Value(value).Equal(comparableValue);

    [Theory]
    [InlineData(1, 2)]
    public void IsEqual_NoEquals_ThrowException(uint value, uint comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).Equal(comparableValue));

    [Theory]
    [InlineData(0, 2)]
    public void IsNotEqual_NotEquals_NoException(uint value, uint comparableValue)
        => Guard.Value(value).NotEqual(comparableValue);

    [Theory]
    [InlineData(0, 0)]
    public void IsNotEqual_Equals_ThrowException(uint value, uint comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).NotEqual(comparableValue));

    [Theory]
    [InlineData(default(uint))]
    public void IsDefault_Zero_NoException(uint value)
        => Guard.Value(value).IsDefault();

    [Theory]
    [InlineData(1)]
    public void IsDefault_NoZero_ThrowException(uint value)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).IsDefault());

    [Theory]
    [InlineData(1)]
    public void IsNotDefault_NotZero_NoException(uint value)
        => Guard.Value(value).IsNotDefault();

    [Theory]
    [InlineData(default(uint))]
    public void IsNotDefault_Zero_ThrowException(uint value)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).IsNotDefault());

    [Theory]
    [InlineData(5, 0)]
    public void IsGreater_GreaterThanValue_NoException(uint value, uint comparableValue)
        => Guard.Value(value).Greater(comparableValue);

    [Theory]
    [InlineData(0, 5)]
    [InlineData(5, 5)]
    public void IsGreater_LessOrEqualThanValue_ThrowException(uint value, uint comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).Greater(comparableValue));

    [Theory]
    [InlineData(5, 0)]
    [InlineData(5, 5)]
    public void IsGreaterOrEqual_GreaterOrEqualThanValue_NoException(uint value, uint comparableValue)
        => Guard.Value(value).GreaterOrEqual(comparableValue);

    [Theory]
    [InlineData(0, 5)]
    public void IsGreaterOrEqual_LessThanValue_ThrowException(uint value, uint comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).GreaterOrEqual(comparableValue));

    [Theory]
    [InlineData(0, 5)]
    public void IsLess_LessThanValue_NoException(uint value, uint comparableValue)
        => Guard.Value(value).Less(comparableValue);

    [Theory]
    [InlineData(5, 0)]
    [InlineData(5, 5)]
    public void IsLess_GreaterOrEqualThanValue_ThrowException(uint value, uint comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).Less(comparableValue));

    [Theory]
    [InlineData(2, 5)]
    [InlineData(5, 5)]
    public void IsLessOrEqual_LessOrEqualThanNumber_NoException(uint value, uint comparableValue)
        => Guard.Value(value).LessOrEqual(comparableValue);

    [Theory]
    [InlineData(8, 5)]
    public void IsLessOrEqual_GreaterThanNumber_ThrowException(uint value, uint comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).LessOrEqual(comparableValue));

    [Theory]
    [InlineData(0, 0, 10, false, false)]
    [InlineData(5, 0, 10, false, false)]
    [InlineData(10, 0, 10, false, false)]
    [InlineData(10, 0, 10, true, false)]
    [InlineData(5, 0, 10, false, true)]
    [InlineData(5, 0, 10, true, true)]
    public void InRange_ValidRange_NoException(uint value, uint min, uint max, bool excludeMin, bool excludeMax)
        => Guard.Value(value).InRange(min, max, excludeMin, excludeMax);

    [Theory]
    [InlineData(0, 0, 10, true, false)]
    [InlineData(10, 0, 10, false, true)]
    [InlineData(0, 0, 10, true, true)]
    [InlineData(10, 0, 10, true, true)]
    public void InRange_InvalidRange_ThrowException(uint value, uint min, uint max, bool excludeMin, bool excludeMax)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).InRange(min, max, excludeMin, excludeMax));
}