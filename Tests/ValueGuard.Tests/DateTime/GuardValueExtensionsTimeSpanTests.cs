namespace ValueGuard.Tests.DateTime;

public sealed class GuardValueExtensionsTimeSpanTests
{
    [Fact]
    public void IsEqual_EqualValue_NoException()
    {
        var value = TimeSpan.FromMinutes(10);
        var comparableValue = value;

        Guard.Value(value).IsEqual(comparableValue);
    }

    [Fact]
    public void IsEqual_NotEqualValue_ThrowException()
    {
        var value = TimeSpan.FromMinutes(10);
        var comparableValue = value + TimeSpan.FromMinutes(1);

        Assert.Throws<GuardException>(()
            => Guard.Value(value).IsEqual(comparableValue));
    }

    [Fact]
    public void IsEqual_DifferenceLessSpecificToleranceValue_NoException()
    {
        var value = TimeSpan.FromMinutes(10);
        var difference = TimeSpan.FromSeconds(9);
        var comparableValue = value + difference;
        var tolerance = TimeSpan.FromSeconds(10);

        Guard.Value(value).IsEqual(comparableValue, tolerance);
    }

    [Fact]
    public void IsEqual_DifferenceGreaterSpecificToleranceValue_ThrowException()
    {
        var value = TimeSpan.FromMinutes(10);
        var difference = TimeSpan.FromSeconds(12);
        var comparableValue = value + difference;
        var tolerance = TimeSpan.FromSeconds(10);

        Assert.Throws<GuardException>(()
            => Guard.Value(value).IsEqual(comparableValue, tolerance));
    }

    [Fact]
    public void NotEqual_DifferenceGreaterSpecificToleranceValue_NoException()
    {
        var value = TimeSpan.FromMinutes(10);
        var difference = TimeSpan.FromSeconds(12);
        var comparableValue = value + difference;
        var tolerance = TimeSpan.FromSeconds(10);

        Guard.Value(value).NotEqual(comparableValue, tolerance);
    }

    [Fact]
    public void NotEqual_DifferenceLessSpecificToleranceValue_ThrowException()
    {
        var value = TimeSpan.FromMinutes(10);
        var difference = TimeSpan.FromSeconds(5);
        var comparableValue = value + difference;
        var tolerance = TimeSpan.FromSeconds(10);

        Assert.Throws<GuardException>(()
            => Guard.Value(value).NotEqual(comparableValue, tolerance));
    }

    [Fact]
    public void IsDefault_DefaultValue_NoException()
        => Guard.Value(default(TimeSpan)).IsDefault();

    [Fact]
    public void IsDefault_NotDefaultValue_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value(TimeSpan.MaxValue).IsDefault());

    [Fact]
    public void NotDefault_NotDefaultValue_NoException()
        => Guard.Value(TimeSpan.MaxValue).NotDefault();

    [Fact]
    public void NotDefault_DefaultValue_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value(default(TimeSpan)).NotDefault());

    [Fact]
    public void IsGreater_GreaterValue_NoException()
    {
        var value = TimeSpan.FromMinutes(10);
        var comparableValue = value - TimeSpan.FromMinutes(2);

        Guard.Value(value).IsGreater(comparableValue);
    }

    [Fact]
    public void IsGreater_LessValue_ThrowException()
    {
        var value = TimeSpan.FromMinutes(10);
        var comparableValue = value + TimeSpan.FromMinutes(2);

        Assert.Throws<GuardException>(()
            => Guard.Value(value).IsGreater(comparableValue));
    }

    [Fact]
    public void IsGreaterOrEqual_GreaterValue_NoException()
    {
        var value = TimeSpan.FromMinutes(10);
        var comparableValue = value - TimeSpan.FromMinutes(2);

        Guard.Value(value).IsGreaterOrEqual(value);
        Guard.Value(value).IsGreaterOrEqual(comparableValue);
    }

    [Fact]
    public void IsGreaterOrEqual_LessValue_ThrowException()
    {
        var value = TimeSpan.FromMinutes(10);
        var comparableValue = value + TimeSpan.FromMinutes(2);

        Assert.Throws<GuardException>(()
            => Guard.Value(value).IsGreaterOrEqual(comparableValue));
    }

    [Fact]
    public void IsLess_LessValue_NoException()
    {
        var value = TimeSpan.FromMinutes(10);
        var comparableValue = value + TimeSpan.FromMinutes(2);

        Guard.Value(value).IsLess(comparableValue);
    }

    [Fact]
    public void IsLess_GreaterValue_ThrowException()
    {
        var value = TimeSpan.FromMinutes(10);
        var comparableValue = value - TimeSpan.FromMinutes(2);

        Assert.Throws<GuardException>(()
            => Guard.Value(value).IsLess(comparableValue));
    }

    [Fact]
    public void IsLessOrEqual_LessValue_NoException()
    {
        var value = TimeSpan.FromMinutes(10);
        var comparableValue = value + TimeSpan.FromMinutes(2);

        Guard.Value(value).IsLessOrEqual(value);
        Guard.Value(value).IsLessOrEqual(comparableValue);
    }

    [Fact]
    public void IsLessOrEqual_GreaterValue_ThrowException()
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
    public void InRange_ValidValueRange_NoException(
        System.DateTime value,
        System.DateTime min,
        System.DateTime max,
        bool excludeMin,
        bool excludeMax)
        => Guard.Value(value).InRange(min, max, excludeMin, excludeMax);

    [Theory]
    [InlineData("00:10:00", "00:10:00", "00:15:00", true, false)]
    [InlineData("00:10:00", "00:15:00", "00:15:00", false, true)]
    [InlineData("00:05:00", "00:10:00", "00:15:00", true, true)]
    [InlineData("00:30:00", "00:10:00", "00:15:00", true, true)]
    public void InRange_InvalidValueRange_ThrowException(
        System.DateTime value,
        System.DateTime min,
        System.DateTime max,
        bool excludeMin,
        bool excludeMax)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).InRange(min, max, excludeMin, excludeMax));
}