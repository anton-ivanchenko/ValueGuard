namespace ValueGuard.Tests.Extensions;

public sealed class GuardValueExtensionsUShortTests
{
    [Theory]
    [InlineData(1, 1)]
    public void IsEqual_Equals_NoException(ushort value, ushort comparableValue)
        => Guard.Value(value).Equal(comparableValue);

    [Theory]
    [InlineData(1, 2)]
    public void IsEqual_NoEquals_ThrowException(ushort value, ushort comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).Equal(comparableValue));

    [Theory]
    [InlineData(0, 2)]
    public void IsNotEqual_NotEquals_NoException(ushort value, ushort comparableValue)
        => Guard.Value(value).NotEqual(comparableValue);

    [Theory]
    [InlineData(0, 0)]
    public void IsNotEqual_Equals_ThrowException(ushort value, ushort comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).NotEqual(comparableValue));

    [Theory]
    [InlineData(default(ushort))]
    public void IsDefault_Zero_NoException(ushort value)
        => Guard.Value(value).IsDefault();

    [Theory]
    [InlineData(1)]
    public void IsDefault_NoZero_ThrowException(ushort value)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).IsDefault());

    [Theory]
    [InlineData(1)]
    public void IsNotDefault_NotZero_NoException(ushort value)
        => Guard.Value(value).IsNotDefault();

    [Theory]
    [InlineData(default(ushort))]
    public void IsNotDefault_Zero_ThrowException(ushort value)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).IsNotDefault());

    [Theory]
    [InlineData(5, 0)]
    public void IsGreater_GreaterThanValue_NoException(ushort value, ushort comparableValue)
        => Guard.Value(value).Greater(comparableValue);

    [Theory]
    [InlineData(0, 5)]
    [InlineData(5, 5)]
    public void IsGreater_LessOrEqualThanValue_ThrowException(ushort value, ushort comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).Greater(comparableValue));

    [Theory]
    [InlineData(5, 0)]
    [InlineData(5, 5)]
    public void IsGreaterOrEqual_GreaterOrEqualThanValue_NoException(ushort value, ushort comparableValue)
        => Guard.Value(value).GreaterOrEqual(comparableValue);

    [Theory]
    [InlineData(0, 5)]
    public void IsGreaterOrEqual_LessThanValue_ThrowException(ushort value, ushort comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).GreaterOrEqual(comparableValue));

    [Theory]
    [InlineData(0, 5)]
    public void IsLess_LessThanValue_NoException(ushort value, ushort comparableValue)
        => Guard.Value(value).Less(comparableValue);

    [Theory]
    [InlineData(5, 0)]
    [InlineData(5, 5)]
    public void IsLess_GreaterOrEqualThanValue_ThrowException(ushort value, ushort comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).Less(comparableValue));

    [Theory]
    [InlineData(2, 5)]
    [InlineData(5, 5)]
    public void IsLessOrEqual_LessOrEqualThanNumber_NoException(ushort value, ushort comparableValue)
        => Guard.Value(value).LessOrEqual(comparableValue);

    [Theory]
    [InlineData(8, 5)]
    public void IsLessOrEqual_GreaterThanNumber_ThrowException(ushort value, ushort comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).LessOrEqual(comparableValue));

    [Theory]
    [InlineData(0, 0, 10, false, false)]
    [InlineData(5, 0, 10, false, false)]
    [InlineData(10, 0, 10, false, false)]
    [InlineData(10, 0, 10, true, false)]
    [InlineData(5, 0, 10, false, true)]
    [InlineData(5, 0, 10, true, true)]
    public void InRange_ValidRange_NoException(ushort value, ushort min, ushort max, bool excludeMin, bool excludeMax)
        => Guard.Value(value).InRange(min, max, excludeMin, excludeMax);

    [Theory]
    [InlineData(0, 0, 10, true, false)]
    [InlineData(10, 0, 10, false, true)]
    [InlineData(0, 0, 10, true, true)]
    [InlineData(10, 0, 10, true, true)]
    public void InRange_InvalidRange_ThrowException(ushort value, ushort min, ushort max, bool excludeMin, bool excludeMax)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).InRange(min, max, excludeMin, excludeMax));
}