namespace ValueGuard.Tests.DateTime;

public sealed class GuardValueExtensionsTimeSpanTests
{
    [Fact]
    public void EqualTo_EqualValue_NoException()
    {
        var value = TimeSpan.FromMinutes(10);
        var comparableValue = value;

        Guard.Value(value).EqualTo(comparableValue);
    }

    [Fact]
    public void EqualTo_NotEqualValue_ThrowException()
    {
        var value = TimeSpan.FromMinutes(10);
        var comparableValue = value + TimeSpan.FromMinutes(1);

        Assert.Throws<GuardException>(()
            => Guard.Value(value).EqualTo(comparableValue));
    }

    [Fact]
    public void EqualTo_DifferenceLessSpecificToleranceValue_NoException()
    {
        var value = TimeSpan.FromMinutes(10);
        var difference = TimeSpan.FromSeconds(9);
        var comparableValue = value + difference;
        var tolerance = TimeSpan.FromSeconds(10);

        Guard.Value(value).EqualTo(comparableValue, tolerance);
    }

    [Fact]
    public void EqualTo_DifferenceGreaterSpecificToleranceValue_ThrowException()
    {
        var value = TimeSpan.FromMinutes(10);
        var difference = TimeSpan.FromSeconds(12);
        var comparableValue = value + difference;
        var tolerance = TimeSpan.FromSeconds(10);

        Assert.Throws<GuardException>(()
            => Guard.Value(value).EqualTo(comparableValue, tolerance));
    }

    [Fact]
    public void NotEqualTo_DifferenceGreaterSpecificToleranceValue_NoException()
    {
        var value = TimeSpan.FromMinutes(10);
        var difference = TimeSpan.FromSeconds(12);
        var comparableValue = value + difference;
        var tolerance = TimeSpan.FromSeconds(10);

        Guard.Value(value).NotEqualTo(comparableValue, tolerance);
    }

    [Fact]
    public void NotEqualTo_DifferenceLessSpecificToleranceValue_ThrowException()
    {
        var value = TimeSpan.FromMinutes(10);
        var difference = TimeSpan.FromSeconds(5);
        var comparableValue = value + difference;
        var tolerance = TimeSpan.FromSeconds(10);

        Assert.Throws<GuardException>(()
            => Guard.Value(value).NotEqualTo(comparableValue, tolerance));
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
    public void GreaterThan_GreaterValue_NoException()
    {
        var value = TimeSpan.FromMinutes(10);
        var comparableValue = value - TimeSpan.FromMinutes(2);

        Guard.Value(value).GreaterThan(comparableValue);
    }

    [Fact]
    public void GreaterThan_LessValue_ThrowException()
    {
        var value = TimeSpan.FromMinutes(10);
        var comparableValue = value + TimeSpan.FromMinutes(2);

        Assert.Throws<GuardException>(()
            => Guard.Value(value).GreaterThan(comparableValue));
    }

    [Fact]
    public void GreaterThanOrEqualTo_GreaterValue_NoException()
    {
        var value = TimeSpan.FromMinutes(10);
        var comparableValue = value - TimeSpan.FromMinutes(2);

        Guard.Value(value).GreaterThanOrEqualTo(value);
        Guard.Value(value).GreaterThanOrEqualTo(comparableValue);
    }

    [Fact]
    public void GreaterThanOrEqualTo_LessValue_ThrowException()
    {
        var value = TimeSpan.FromMinutes(10);
        var comparableValue = value + TimeSpan.FromMinutes(2);

        Assert.Throws<GuardException>(()
            => Guard.Value(value).GreaterThanOrEqualTo(comparableValue));
    }

    [Fact]
    public void LessThan_LessValue_NoException()
    {
        var value = TimeSpan.FromMinutes(10);
        var comparableValue = value + TimeSpan.FromMinutes(2);

        Guard.Value(value).LessThan(comparableValue);
    }

    [Fact]
    public void LessThan_GreaterValue_ThrowException()
    {
        var value = TimeSpan.FromMinutes(10);
        var comparableValue = value - TimeSpan.FromMinutes(2);

        Assert.Throws<GuardException>(()
            => Guard.Value(value).LessThan(comparableValue));
    }

    [Fact]
    public void LessThanOrEqualTo_LessValue_NoException()
    {
        var value = TimeSpan.FromMinutes(10);
        var comparableValue = value + TimeSpan.FromMinutes(2);

        Guard.Value(value).LessThanOrEqualTo(value);
        Guard.Value(value).LessThanOrEqualTo(comparableValue);
    }

    [Fact]
    public void LessThanOrEqualTo_GreaterValue_ThrowException()
    {
        var value = TimeSpan.FromMinutes(10);
        var comparableValue = value - TimeSpan.FromMinutes(2);

        Assert.Throws<GuardException>(()
            => Guard.Value(value).LessThanOrEqualTo(comparableValue));
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