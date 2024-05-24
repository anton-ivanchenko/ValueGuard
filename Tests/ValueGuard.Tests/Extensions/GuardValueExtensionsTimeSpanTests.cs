namespace ValueGuard.Tests.Extensions;

public sealed class GuardValueExtensionsTimeSpanTests
{
    [Fact]
    public void IsEqual_Equal_NoException()
    {
        var value = TimeSpan.FromMinutes(10);
        var comparableValue = value;

        Guard.Value(value).IsEqual(comparableValue);
    }

    [Fact]
    public void IsEqual_NotEqual_ThrowException()
    {
        var value = TimeSpan.FromMinutes(10);
        var comparableValue = value + TimeSpan.FromMinutes(1);

        Assert.Throws<GuardException>(()
            => Guard.Value(value).IsEqual(comparableValue));
    }

    [Fact]
    public void IsEqual_DifferenceLessSpecificTolerance_NoException()
    {
        var value = TimeSpan.FromMinutes(10);
        var difference = TimeSpan.FromSeconds(9);
        var comparableValue = value + difference;
        var tolerance = TimeSpan.FromSeconds(10);

        Guard.Value(value).IsEqual(comparableValue, tolerance);
    }

    [Fact]
    public void IsEqual_DifferenceGreaterSpecificTolerance_ThrowException()
    {
        var value = TimeSpan.FromMinutes(10);
        var difference = TimeSpan.FromSeconds(12);
        var comparableValue = value + difference;
        var tolerance = TimeSpan.FromSeconds(10);

        Assert.Throws<GuardException>(()
            => Guard.Value(value).IsEqual(comparableValue, tolerance));
    }

    [Fact]
    public void IsNotEqual_DifferenceGreaterSpecificTolerance_NoException()
    {
        var value = TimeSpan.FromMinutes(10);
        var difference = TimeSpan.FromSeconds(12);
        var comparableValue = value + difference;
        var tolerance = TimeSpan.FromSeconds(10);

        Guard.Value(value).IsNotEqual(comparableValue, tolerance);
    }

    [Fact]
    public void IsNotEqual_DifferenceLessSpecificTolerance_ThrowException()
    {
        var value = TimeSpan.FromMinutes(10);
        var difference = TimeSpan.FromSeconds(5);
        var comparableValue = value + difference;
        var tolerance = TimeSpan.FromSeconds(10);

        Assert.Throws<GuardException>(()
            => Guard.Value(value).IsNotEqual(comparableValue, tolerance));
    }

    [Fact]
    public void IsDefault_Default_NoException()
        => Guard.Value(default(TimeSpan)).IsDefault();

    [Fact]
    public void IsDefault_NotDefault_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value(TimeSpan.MaxValue).IsDefault());

    [Fact]
    public void IsNotDefault_NotDefault_NoException()
        => Guard.Value(TimeSpan.MaxValue).IsNotDefault();

    [Fact]
    public void IsNotDefault_Default_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value(default(TimeSpan)).IsNotDefault());

    [Fact]
    public void IsGreater_GreaterThanValue_NoException()
    {
        var value = TimeSpan.FromMinutes(10);
        var comparableValue = value - TimeSpan.FromMinutes(2);

        Guard.Value(value).IsGreater(comparableValue);
    }

    [Fact]
    public void IsGreater_LessOrEqualThanValue_ThrowException()
    {
        var value = TimeSpan.FromMinutes(10);
        var comparableValue = value + TimeSpan.FromMinutes(2);

        Assert.Throws<GuardException>(()
            => Guard.Value(value).IsGreater(comparableValue));
    }

    [Fact]
    public void IsGreaterOrEqual_GreaterOrEqualThanValue_NoException()
    {
        var value = TimeSpan.FromMinutes(10);
        var comparableValue = value - TimeSpan.FromMinutes(2);

        Guard.Value(value).IsGreaterOrEqual(value);
        Guard.Value(value).IsGreaterOrEqual(comparableValue);
    }

    [Fact]
    public void IsGreaterOrEqual_LessThanValue_ThrowException()
    {
        var value = TimeSpan.FromMinutes(10);
        var comparableValue = value + TimeSpan.FromMinutes(2);

        Assert.Throws<GuardException>(()
            => Guard.Value(value).IsGreaterOrEqual(comparableValue));
    }

    [Fact]
    public void IsLess_LessThanValue_NoException()
    {
        var value = TimeSpan.FromMinutes(10);
        var comparableValue = value + TimeSpan.FromMinutes(2);

        Guard.Value(value).IsLess(comparableValue);
    }

    [Fact]
    public void IsLess_GreaterOrEqualThanValue_ThrowException()
    {
        var value = TimeSpan.FromMinutes(10);
        var comparableValue = value - TimeSpan.FromMinutes(2);

        Assert.Throws<GuardException>(()
            => Guard.Value(value).IsLess(comparableValue));
    }

    [Fact]
    public void IsLessOrEqual_LessOrEqualThanComparableValue_NoException()
    {
        var value = TimeSpan.FromMinutes(10);
        var comparableValue = value + TimeSpan.FromMinutes(2);

        Guard.Value(value).IsLessOrEqual(value);
        Guard.Value(value).IsLessOrEqual(comparableValue);
    }

    [Fact]
    public void IsLessOrEqual_GreaterThanComparableValue_ThrowException()
    {
        var value = TimeSpan.FromMinutes(10);
        var comparableValue = value - TimeSpan.FromMinutes(2);

        Assert.Throws<GuardException>(()
            => Guard.Value(value).IsLessOrEqual(comparableValue));
    }

    [Theory]
    [InlineData("00:10:00", "00:10:00", "00:15:00", false, false)]
    [InlineData("00:15:00", "00:10:00", "00:15:00", false, false)]
    [InlineData("00:15:00", "00:10:00", "00:15:00", true, false)]
    [InlineData("00:12:00", "00:10:00", "00:15:00", false, true)]
    [InlineData("00:12:00", "00:10:00", "00:15:00", true, true)]
    public void InRange_ValidRange_NoException(DateTime value, DateTime min, DateTime max, bool excludeMin, bool excludeMax)
        => Guard.Value(value).InRange(min, max, excludeMin, excludeMax);

    [Theory]
    [InlineData("00:10:00", "00:10:00", "00:15:00", true, false)]
    [InlineData("00:10:00", "00:15:00", "00:15:00", false, true)]
    [InlineData("00:05:00", "00:10:00", "00:15:00", true, true)]
    [InlineData("00:30:00", "00:10:00", "00:15:00", true, true)]
    public void InRange_InvalidRange_ThrowException(DateTime value, DateTime min, DateTime max, bool excludeMin, bool excludeMax)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).InRange(min, max, excludeMin, excludeMax));
}