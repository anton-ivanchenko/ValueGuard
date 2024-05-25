namespace ValueGuard.Tests.DateTime;

public sealed class GuardValueExtensionsDateTimeTests
{
    [Fact]
    public void IsEqual_EqualValue_NoException()
    {
        var value = System.DateTime.UtcNow;
        var comparableValue = value;

        Guard.Value(value).IsEqual(comparableValue);
    }

    [Fact]
    public void IsEqual_NotEqualValue_ThrowException()
    {
        var value = System.DateTime.UtcNow;
        var comparableValue = value.AddMilliseconds(1);

        Assert.Throws<GuardException>(()
            => Guard.Value(value).IsEqual(comparableValue));
    }

    [Fact]
    public void IsEqual_DifferenceLessSpecificToleranceValue_NoException()
    {
        var value = System.DateTime.UtcNow;
        var difference = TimeSpan.FromSeconds(9);
        var comparableValue = value + difference;
        var tolerance = TimeSpan.FromSeconds(10);

        Guard.Value(value).IsEqual(comparableValue, tolerance);
    }

    [Fact]
    public void IsEqual_DifferenceGreaterSpecificToleranceValue_ThrowException()
    {
        var value = System.DateTime.UtcNow;
        var difference = TimeSpan.FromSeconds(12);
        var comparableValue = value + difference;
        var tolerance = TimeSpan.FromSeconds(10);

        Assert.Throws<GuardException>(()
            => Guard.Value(value).IsEqual(comparableValue, tolerance));
    }

    [Fact]
    public void NotEqual_DifferenceGreaterSpecificToleranceValue_NoException()
    {
        var value = System.DateTime.UtcNow;
        var difference = TimeSpan.FromSeconds(12);
        var comparableValue = value + difference;
        var tolerance = TimeSpan.FromSeconds(10);

        Guard.Value(value).NotEqual(comparableValue, tolerance);
    }

    [Fact]
    public void NotEqual_DifferenceLessSpecificToleranceValue_ThrowException()
    {
        var value = System.DateTime.UtcNow;
        var difference = TimeSpan.FromSeconds(5);
        var comparableValue = value + difference;
        var tolerance = TimeSpan.FromSeconds(10);

        Assert.Throws<GuardException>(()
            => Guard.Value(value).NotEqual(comparableValue, tolerance));
    }

    [Fact]
    public void IsDefault_DefaultValue_NoException()
        => Guard.Value(default(System.DateTime)).IsDefault();

    [Fact]
    public void IsDefault_NotDefaultValue_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value(System.DateTime.UtcNow).IsDefault());

    [Fact]
    public void NotDefault_NotDefaultValue_NoException()
        => Guard.Value(System.DateTime.UtcNow).NotDefault();

    [Fact]
    public void NotDefault_DefaultValue_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value(default(System.DateTime)).NotDefault());

    [Fact]
    public void IsGreater_GreaterValue_NoException()
    {
        var value = System.DateTime.UtcNow;
        var comparableValue = value.AddMilliseconds(-2);

        Guard.Value(value).IsGreater(comparableValue);
    }

    [Fact]
    public void IsGreater_LessValue_ThrowException()
    {
        var value = System.DateTime.UtcNow;
        var comparableValue = value.AddMilliseconds(2);

        Assert.Throws<GuardException>(()
            => Guard.Value(value).IsGreater(comparableValue));
    }

    [Fact]
    public void IsGreaterOrEqual_GreaterValue_NoException()
    {
        var value = System.DateTime.UtcNow;
        var comparableValue = value.AddMilliseconds(-2);

        Guard.Value(value).IsGreaterOrEqual(value);
        Guard.Value(value).IsGreaterOrEqual(comparableValue);
    }

    [Fact]
    public void IsGreaterOrEqual_LessValue_ThrowException()
    {
        var value = System.DateTime.UtcNow;
        var comparableValue = value.AddMilliseconds(2);

        Assert.Throws<GuardException>(()
            => Guard.Value(value).IsGreaterOrEqual(comparableValue));
    }

    [Fact]
    public void IsLess_LessValue_NoException()
    {
        var value = System.DateTime.UtcNow;
        var comparableValue = value.AddMilliseconds(2);

        Guard.Value(value).IsLess(comparableValue);
    }

    [Fact]
    public void IsLess_GreaterValue_ThrowException()
    {
        var value = System.DateTime.UtcNow;
        var comparableValue = value.AddMilliseconds(-2);

        Assert.Throws<GuardException>(()
            => Guard.Value(value).IsLess(comparableValue));
    }

    [Fact]
    public void IsLessOrEqual_LessValue_NoException()
    {
        var value = System.DateTime.UtcNow;
        var comparableValue = value.AddMilliseconds(2);

        Guard.Value(value).IsLessOrEqual(value);
        Guard.Value(value).IsLessOrEqual(comparableValue);
    }

    [Fact]
    public void IsLessOrEqual_GreaterValue_ThrowException()
    {
        var value = System.DateTime.UtcNow;
        var comparableValue = value.AddMilliseconds(-2);

        Assert.Throws<GuardException>(()
            => Guard.Value(value).IsLessOrEqual(comparableValue));
    }

    [Theory]
    [InlineData("2020-01-01", "2020-01-01", "2020-01-05", false, false)]
    [InlineData("2020-01-05", "2020-01-01", "2020-01-15", false, false)]
    [InlineData("2020-01-15", "2020-01-01", "2020-01-15", true, false)]
    [InlineData("2020-01-05", "2020-01-01", "2020-01-15", false, true)]
    [InlineData("2020-01-05", "2020-01-01", "2020-01-15", true, true)]
    public void InRange_ValidValueRange_NoException(
        System.DateTime value,
        System.DateTime min,
        System.DateTime max,
        bool excludeMin,
        bool excludeMax)
        => Guard.Value(value).InRange(min, max, excludeMin, excludeMax);

    [Theory]
    [InlineData("2020-01-01", "2020-01-01", "2020-01-05", true, false)]
    [InlineData("2020-01-01", "2020-01-05", "2020-01-05", false, true)]
    [InlineData("2019-01-01", "2020-01-01", "2020-01-05", true, true)]
    [InlineData("2021-01-01", "2020-01-01", "2020-01-05", true, true)]
    public void InRange_InvalidValueRange_ThrowException(
        System.DateTime value,
        System.DateTime min,
        System.DateTime max,
        bool excludeMin,
        bool excludeMax)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).InRange(min, max, excludeMin, excludeMax));
}