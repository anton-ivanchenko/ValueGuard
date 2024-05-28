namespace ValueGuard.Tests.Numbers;

public sealed class GuardValueExtensionsULongTests
{
    [Theory]
    [InlineData(1, 1)]
    public void EqualTo_Equals_NoException(ulong value, ulong comparableValue)
        => Guard.Value(value).EqualTo(comparableValue);

    [Theory]
    [InlineData(1, 2)]
    public void EqualTo_NoEquals_ThrowException(ulong value, ulong comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).EqualTo(comparableValue));

    [Theory]
    [InlineData(0, 2)]
    public void IsNotEqualTo_NotEquals_NoException(ulong value, ulong comparableValue)
        => Guard.Value(value).NotEqualTo(comparableValue);

    [Theory]
    [InlineData(0, 0)]
    public void IsNotEqualTo_Equals_ThrowException(ulong value, ulong comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).NotEqualTo(comparableValue));

    [Theory]
    [InlineData(default(ulong))]
    public void IsDefault_Zero_NoException(ulong value)
        => Guard.Value(value).IsDefault();

    [Theory]
    [InlineData(1)]
    public void IsDefault_NoZero_ThrowException(ulong value)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).IsDefault());

    [Theory]
    [InlineData(1)]
    public void IsNotDefault_NotZero_NoException(ulong value)
        => Guard.Value(value).NotDefault();

    [Theory]
    [InlineData(default(ulong))]
    public void IsNotDefault_Zero_ThrowException(ulong value)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).NotDefault());

    [Theory]
    [InlineData(5, 0)]
    public void GreaterThan_GreaterThanValue_NoException(ulong value, ulong comparableValue)
        => Guard.Value(value).GreaterThan(comparableValue);

    [Theory]
    [InlineData(0, 5)]
    [InlineData(5, 5)]
    public void GreaterThan_LessOrEqualThanValue_ThrowException(ulong value, ulong comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).GreaterThan(comparableValue));

    [Theory]
    [InlineData(5, 0)]
    [InlineData(5, 5)]
    public void GreaterThanOrEqualTo_GreaterOrEqualThanValue_NoException(ulong value, ulong comparableValue)
        => Guard.Value(value).GreaterThanOrEqualTo(comparableValue);

    [Theory]
    [InlineData(0, 5)]
    public void GreaterThanOrEqualTo_LessThanValue_ThrowException(ulong value, ulong comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).GreaterThanOrEqualTo(comparableValue));

    [Theory]
    [InlineData(0, 5)]
    public void LessThan_LessThanValue_NoException(ulong value, ulong comparableValue)
        => Guard.Value(value).LessThan(comparableValue);

    [Theory]
    [InlineData(5, 0)]
    [InlineData(5, 5)]
    public void LessThan_GreaterOrEqualThanValue_ThrowException(ulong value, ulong comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).LessThan(comparableValue));

    [Theory]
    [InlineData(2, 5)]
    [InlineData(5, 5)]
    public void LessThanOrEqualTo_LessOrEqualThanNumber_NoException(ulong value, ulong comparableValue)
        => Guard.Value(value).LessThanOrEqualTo(comparableValue);

    [Theory]
    [InlineData(8, 5)]
    public void LessThanOrEqualTo_GreaterThanNumber_ThrowException(ulong value, ulong comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).LessThanOrEqualTo(comparableValue));

    [Theory]
    [InlineData(0, 0, 10, false, false)]
    [InlineData(5, 0, 10, false, false)]
    [InlineData(10, 0, 10, false, false)]
    [InlineData(10, 0, 10, true, false)]
    [InlineData(5, 0, 10, false, true)]
    [InlineData(5, 0, 10, true, true)]
    public void InRange_ValidRange_NoException(ulong value, ulong min, ulong max, bool excludeMin, bool excludeMax)
        => Guard.Value(value).InRange(min, max, excludeMin, excludeMax);

    [Theory]
    [InlineData(0, 0, 10, true, false)]
    [InlineData(10, 0, 10, false, true)]
    [InlineData(0, 0, 10, true, true)]
    [InlineData(10, 0, 10, true, true)]
    public void InRange_InvalidRange_ThrowException(ulong value, ulong min, ulong max, bool excludeMin, bool excludeMax)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).InRange(min, max, excludeMin, excludeMax));
}