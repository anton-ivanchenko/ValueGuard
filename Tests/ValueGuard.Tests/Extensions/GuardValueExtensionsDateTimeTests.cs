namespace ValueGuard.Tests.Extensions;

public sealed class GuardValueExtensionsDateTimeTests
{
    [Fact]
    public void IsEqual_Equal_NoException()
    {
        var value = DateTime.UtcNow;
        var comparableValue = value;

        Guard.Value(value).Equal(comparableValue);
    }

    [Fact]
    public void IsEqual_NotEqual_ThrowException()
    {
        var value = DateTime.UtcNow;
        var comparableValue = value.AddMilliseconds(1);

        Assert.Throws<GuardException>(()
            => Guard.Value(value).Equal(comparableValue));
    }

    [Fact]
    public void IsEqual_DifferenceLessSpecificTolerance_NoException()
    {
        var value = DateTime.UtcNow;
        var difference = TimeSpan.FromSeconds(9);
        var comparableValue = value + difference;
        var tolerance = TimeSpan.FromSeconds(10);

        Guard.Value(value).Equal(comparableValue, tolerance);
    }

    [Fact]
    public void IsEqual_DifferenceGreaterSpecificTolerance_ThrowException()
    {
        var value = DateTime.UtcNow;
        var difference = TimeSpan.FromSeconds(12);
        var comparableValue = value + difference;
        var tolerance = TimeSpan.FromSeconds(10);

        Assert.Throws<GuardException>(()
            => Guard.Value(value).Equal(comparableValue, tolerance));
    }

    [Fact]
    public void IsNotEqual_DifferenceGreaterSpecificTolerance_NoException()
    {
        var value = DateTime.UtcNow;
        var difference = TimeSpan.FromSeconds(12);
        var comparableValue = value + difference;
        var tolerance = TimeSpan.FromSeconds(10);

        Guard.Value(value).NotEqual(comparableValue, tolerance);
    }

    [Fact]
    public void IsNotEqual_DifferenceLessSpecificTolerance_ThrowException()
    {
        var value = DateTime.UtcNow;
        var difference = TimeSpan.FromSeconds(5);
        var comparableValue = value + difference;
        var tolerance = TimeSpan.FromSeconds(10);

        Assert.Throws<GuardException>(()
            => Guard.Value(value).NotEqual(comparableValue, tolerance));
    }

    [Fact]
    public void IsDefault_Default_NoException()
        => Guard.Value(default(DateTime)).IsDefault();

    [Fact]
    public void IsDefault_NotDefault_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value(DateTime.UtcNow).IsDefault());

    [Fact]
    public void IsNotDefault_NotDefault_NoException()
        => Guard.Value(DateTime.UtcNow).IsNotDefault();

    [Fact]
    public void IsNotDefault_Default_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value(default(DateTime)).IsNotDefault());

    [Fact]
    public void IsGreater_GreaterThanValue_NoException()
    {
        var value = DateTime.UtcNow;
        var comparableValue = value.AddMilliseconds(-2);

        Guard.Value(value).Greater(comparableValue);
    }

    [Fact]
    public void IsGreater_LessOrEqualThanValue_ThrowException()
    {
        var value = DateTime.UtcNow;
        var comparableValue = value.AddMilliseconds(2);

        Assert.Throws<GuardException>(()
            => Guard.Value(value).Greater(comparableValue));
    }

    [Fact]
    public void IsGreaterOrEqual_GreaterOrEqualThanValue_NoException()
    {
        var value = DateTime.UtcNow;
        var comparableValue = value.AddMilliseconds(-2);

        Guard.Value(value).GreaterOrEqual(value);
        Guard.Value(value).GreaterOrEqual(comparableValue);
    }

    [Fact]
    public void IsGreaterOrEqual_LessThanValue_ThrowException()
    {
        var value = DateTime.UtcNow;
        var comparableValue = value.AddMilliseconds(2);

        Assert.Throws<GuardException>(()
            => Guard.Value(value).GreaterOrEqual(comparableValue));
    }

    [Fact]
    public void IsLess_LessThanValue_NoException()
    {
        var value = DateTime.UtcNow;
        var comparableValue = value.AddMilliseconds(2);

        Guard.Value(value).Less(comparableValue);
    }

    [Fact]
    public void IsLess_GreaterOrEqualThanValue_ThrowException()
    {
        var value = DateTime.UtcNow;
        var comparableValue = value.AddMilliseconds(-2);

        Assert.Throws<GuardException>(()
            => Guard.Value(value).Less(comparableValue));
    }

    [Fact]
    public void IsLessOrEqual_LessOrEqualThanComparableValue_NoException()
    {
        var value = DateTime.UtcNow;
        var comparableValue = value.AddMilliseconds(2);

        Guard.Value(value).LessOrEqual(value);
        Guard.Value(value).LessOrEqual(comparableValue);
    }

    [Fact]
    public void IsLessOrEqual_GreaterThanComparableValue_ThrowException()
    {
        var value = DateTime.UtcNow;
        var comparableValue = value.AddMilliseconds(-2);

        Assert.Throws<GuardException>(()
            => Guard.Value(value).LessOrEqual(comparableValue));
    }

    [Theory]
    [InlineData("2020-01-01", "2020-01-01", "2020-01-05", false, false)]
    [InlineData("2020-01-05", "2020-01-01", "2020-01-15", false, false)]
    [InlineData("2020-01-15", "2020-01-01", "2020-01-15", true, false)]
    [InlineData("2020-01-05", "2020-01-01", "2020-01-15", false, true)]
    [InlineData("2020-01-05", "2020-01-01", "2020-01-15", true, true)]
    public void InRange_ValidRange_NoException(DateTime value, DateTime min, DateTime max, bool excludeMin, bool excludeMax)
        => Guard.Value(value).InRange(min, max, excludeMin, excludeMax);

    [Theory]
    [InlineData("2020-01-01", "2020-01-01", "2020-01-05", true, false)]
    [InlineData("2020-01-01", "2020-01-05", "2020-01-05", false, true)]
    [InlineData("2019-01-01", "2020-01-01", "2020-01-05", true, true)]
    [InlineData("2021-01-01", "2020-01-01", "2020-01-05", true, true)]
    public void InRange_InvalidRange_ThrowException(DateTime value, DateTime min, DateTime max, bool excludeMin, bool excludeMax)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).InRange(min, max, excludeMin, excludeMax));
}