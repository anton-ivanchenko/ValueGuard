namespace ValueGuard.Tests.Numbers;

public sealed class GuardValueExtensionsSByteTests
{
    [Theory]
    [InlineData(10, 10)]
    public void EqualTo_Equals_NoException(sbyte value, sbyte comparableValue)
        => Guard.Value(value).EqualTo(comparableValue);

    [Theory]
    [InlineData(10, 20)]
    public void EqualTo_NoEquals_ThrowException(sbyte value, sbyte comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).EqualTo(comparableValue));

    [Theory]
    [InlineData(0, 2)]
    public void IsNotEqualTo_NotEquals_NoException(sbyte value, sbyte comparableValue)
        => Guard.Value(value).NotEqualTo(comparableValue);

    [Theory]
    [InlineData(0, 0)]
    public void IsNotEqualTo_Equals_ThrowException(sbyte value, sbyte comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).NotEqualTo(comparableValue));

    [Theory]
    [InlineData(default(sbyte))]
    public void IsDefault_Zero_NoException(sbyte value)
        => Guard.Value(value).IsDefault();

    [Theory]
    [InlineData(-1)]
    [InlineData(1)]
    public void IsDefault_NoZero_ThrowException(sbyte value)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).IsDefault());

    [Theory]
    [InlineData(-1)]
    [InlineData(1)]
    public void IsNotDefault_NotZero_NoException(sbyte value)
        => Guard.Value(value).NotDefault();

    [Theory]
    [InlineData(default(sbyte))]
    public void IsNotDefault_Zero_ThrowException(sbyte value)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).NotDefault());

    [Theory]
    [InlineData(1)]
    public void IsPositive_Positive_NoException(sbyte value)
        => Guard.Value(value).IsPositive();

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void IsPositive_NotPositive_ThrowException(sbyte value)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).IsPositive());

    [Theory]
    [InlineData(-1)]
    public void IsNegative_Negative_NoException(sbyte value)
        => Guard.Value(value).IsNegative();

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    public void IsNegative_Positive_ThrowException(sbyte value)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).IsNegative());

    [Theory]
    [InlineData(5, 0)]
    public void GreaterThan_GreaterThanValue_NoException(sbyte value, sbyte comparableValue)
        => Guard.Value(value).GreaterThan(comparableValue);

    [Theory]
    [InlineData(0, 5)]
    [InlineData(5, 5)]
    public void GreaterThan_LessOrEqualThanValue_ThrowException(sbyte value, sbyte comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).GreaterThan(comparableValue));

    [Theory]
    [InlineData(5, 0)]
    [InlineData(5, 5)]
    public void GreaterThanOrEqualTo_GreaterOrEqualThanValue_NoException(sbyte value, sbyte comparableValue)
        => Guard.Value(value).GreaterThanOrEqualTo(comparableValue);

    [Theory]
    [InlineData(0, 5)]
    public void GreaterThanOrEqualTo_LessThanValue_ThrowException(sbyte value, sbyte comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).GreaterThanOrEqualTo(comparableValue));

    [Theory]
    [InlineData(0, 5)]
    public void LessThan_LessThanValue_NoException(sbyte value, sbyte comparableValue)
        => Guard.Value(value).LessThan(comparableValue);

    [Theory]
    [InlineData(5, 0)]
    [InlineData(5, 5)]
    public void LessThan_GreaterOrEqualThanValue_ThrowException(sbyte value, sbyte comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).LessThan(comparableValue));

    [Theory]
    [InlineData(2, 5)]
    [InlineData(5, 5)]
    public void LessThanOrEqualTo_LessOrEqualThanNumber_NoException(sbyte value, sbyte comparableValue)
        => Guard.Value(value).LessThanOrEqualTo(comparableValue);

    [Theory]
    [InlineData(8, 5)]
    public void LessThanOrEqualTo_GreaterThanNumber_ThrowException(sbyte value, sbyte comparableValue)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).LessThanOrEqualTo(comparableValue));

    [Theory]
    [InlineData(0, 0, 10, false, false)]
    [InlineData(5, 0, 10, false, false)]
    [InlineData(10, 0, 10, false, false)]
    [InlineData(10, 0, 10, true, false)]
    [InlineData(5, 0, 10, false, true)]
    [InlineData(5, 0, 10, true, true)]
    public void Between_ValidRange_NoException(sbyte value, sbyte min, sbyte max, bool excludeMin, bool excludeMax)
        => Guard.Value(value).Between(min, max, excludeMin, excludeMax);

    [Theory]
    [InlineData(0, 0, 10, true, false)]
    [InlineData(10, 0, 10, false, true)]
    [InlineData(0, 0, 10, true, true)]
    [InlineData(10, 0, 10, true, true)]
    public void Between_InvalidRange_ThrowException(sbyte value, sbyte min, sbyte max, bool excludeMin, bool excludeMax)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).Between(min, max, excludeMin, excludeMax));
}