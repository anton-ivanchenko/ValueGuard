namespace ValueGuard.Tests.Common;

public sealed class GuardValueExtensionsGuidTests
{
    [Fact]
    public void IsEqual_EqualValue_NoException()
    {
        var value = Guid.NewGuid();
        var comparableValue = value;

        Guard.Value(value).IsEqual(comparableValue);
    }

    [Fact]
    public void IsEqual_NotEqualValue_ThrowException()
    {
        var value = Guid.NewGuid();
        var comparableValue = Guid.NewGuid();

        Assert.Throws<GuardException>(()
            => Guard.Value(value).IsEqual(comparableValue));
    }

    [Fact]
    public void NotEqual_NotEqualValue_NoException()
    {
        var value = Guid.NewGuid();
        var comparableValue = Guid.NewGuid();

        Guard.Value(value).NotEqual(comparableValue);
    }

    [Fact]
    public void NotEqual_EqualValue_ThrowException()
    {
        var value = Guid.NewGuid();
        var comparableValue = value;

        Assert.Throws<GuardException>(()
            => Guard.Value(value).NotEqual(comparableValue));
    }

    [Fact]
    public void IsDefault_DefaultValue_NoException()
    {
        var value = default(Guid);
        Guard.Value(value).IsDefault();
    }

    [Fact]
    public void IsDefault_NotDefaultValue_ThrowException()
    {
        var value = Guid.NewGuid();

        Assert.Throws<GuardException>(()
            => Guard.Value(value).IsDefault());
    }

    [Fact]
    public void NotDefault_NotDefaultValue_NoException()
    {
        var value = Guid.NewGuid();
        Guard.Value(value).NotDefault();
    }

    [Fact]
    public void NotDefault_DefaultValue_ThrowException()
    {
        var value = default(Guid);

        Assert.Throws<GuardException>(()
            => Guard.Value(value).NotDefault());
    }

    [Fact]
    public void IsGreater_GreaterThanValue_NoException()
    {
        var value = Guid.Parse("f4147d65-4816-4f1c-a30c-7f9f643026c8");
        var comparableValue = Guid.Parse("f4147d65-4816-4f1c-a30c-7f9f643026c7");

        Guard.Value(value).IsGreater(comparableValue);
    }

    [Fact]
    public void IsGreater_LessValue_ThrowException()
    {
        var value = Guid.Parse("f4147d65-4816-4f1c-a30c-7f9f643026c8");
        var comparableValue = Guid.Parse("f4147d65-4816-4f1c-a30c-7f9f643026c9");

        Assert.Throws<GuardException>(()
            => Guard.Value(value).IsGreater(comparableValue));
    }

    [Fact]
    public void IsGreaterOrEqual_GreaterValue_NoException()
    {
        var value = Guid.Parse("f4147d65-4816-4f1c-a30c-7f9f643026c8");
        var comparableValue = Guid.Parse("f4147d65-4816-4f1c-a30c-7f9f643026c7");

        Guard.Value(value).IsGreaterOrEqual(value);
        Guard.Value(value).IsGreaterOrEqual(comparableValue);
    }

    [Fact]
    public void IsGreaterOrEqual_LessValue_ThrowException()
    {
        var value = Guid.Parse("f4147d65-4816-4f1c-a30c-7f9f643026c8");
        var comparableValue = Guid.Parse("f4147d65-4816-4f1c-a30c-7f9f643026c9");

        Assert.Throws<GuardException>(()
            => Guard.Value(value).IsGreaterOrEqual(comparableValue));
    }

    [Fact]
    public void IsLess_LessValue_NoException()
    {
        var value = Guid.Parse("f4147d65-4816-4f1c-a30c-7f9f643026c8");
        var comparableValue = Guid.Parse("f4147d65-4816-4f1c-a30c-7f9f643026c9");

        Guard.Value(value).IsLess(comparableValue);
    }

    [Fact]
    public void IsLess_GreaterValue_ThrowException()
    {
        var value = Guid.Parse("f4147d65-4816-4f1c-a30c-7f9f643026c8");
        var comparableValue = Guid.Parse("f4147d65-4816-4f1c-a30c-7f9f643026c7");

        Assert.Throws<GuardException>(()
            => Guard.Value(value).IsLess(comparableValue));
    }

    [Fact]
    public void IsLessOrEqual_LessValue_NoException()
    {
        var value = Guid.Parse("f4147d65-4816-4f1c-a30c-7f9f643026c8");
        var comparableValue = Guid.Parse("f4147d65-4816-4f1c-a30c-7f9f643026c9");

        Guard.Value(value).IsLessOrEqual(comparableValue);
    }

    [Fact]
    public void IsLessOrEqual_GreaterValue_ThrowException()
    {
        var value = Guid.Parse("f4147d65-4816-4f1c-a30c-7f9f643026c8");
        var comparableValue = Guid.Parse("f4147d65-4816-4f1c-a30c-7f9f643026c7");

        Assert.Throws<GuardException>(()
            => Guard.Value(value).IsLessOrEqual(comparableValue));
    }

    [Theory]
    [InlineData("f4147d65-4816-4f1c-a30c-7f9f643026c8",
        "f4147d65-4816-4f1c-a30c-7f9f643026c8",
        "f4147d65-4816-4f1c-a30c-7f9f643027c0",
        false, false)]
    [InlineData("f4147d65-4816-4f1c-a30c-7f9f643027c0",
        "f4147d65-4816-4f1c-a30c-7f9f643026c8",
        "f4147d65-4816-4f1c-a30c-7f9f643027c0",
        false, false)]
    [InlineData("f4147d65-4816-4f1c-a30c-7f9f643026c9",
        "f4147d65-4816-4f1c-a30c-7f9f643026c8",
        "f4147d65-4816-4f1c-a30c-7f9f643027c0",
        false, false)]
    [InlineData("f4147d65-4816-4f1c-a30c-7f9f643026c9",
        "f4147d65-4816-4f1c-a30c-7f9f643026c8",
        "f4147d65-4816-4f1c-a30c-7f9f643027c0",
        true, false)]
    [InlineData("f4147d65-4816-4f1c-a30c-7f9f643026c9",
        "f4147d65-4816-4f1c-a30c-7f9f643026c8",
        "f4147d65-4816-4f1c-a30c-7f9f643027c0",
        false, true)]
    [InlineData("f4147d65-4816-4f1c-a30c-7f9f643026c9",
        "f4147d65-4816-4f1c-a30c-7f9f643026c8",
        "f4147d65-4816-4f1c-a30c-7f9f643027c0",
        true, true)]
    public void InRange_ValidValueRanges_NoException(Guid value, Guid min, Guid max, bool excludeMin, bool excludeMax)
    {
        Guard.Value(value).InRange(min, max, excludeMin, excludeMax);
    }

    [Theory]
    [InlineData("f4147d65-4816-4f1c-a30c-7f9f643026c8",
        "f4147d65-4816-4f1c-a30c-7f9f643026c8",
        "f4147d65-4816-4f1c-a30c-7f9f643027c0",
        true, false)]
    [InlineData("f4147d65-4816-4f1c-a30c-7f9f643027c0",
        "f4147d65-4816-4f1c-a30c-7f9f643026c8",
        "f4147d65-4816-4f1c-a30c-7f9f643027c0",
        false, true)]
    [InlineData("f4147d65-4816-4f1c-a30c-7f9f643023a2",
        "f4147d65-4816-4f1c-a30c-7f9f643026c8",
        "f4147d65-4816-4f1c-a30c-7f9f643027c0",
        true, true)]
    [InlineData("f4147d65-4816-4f1c-a30c-7f9f643039c5",
        "f4147d65-4816-4f1c-a30c-7f9f643026c8",
        "f4147d65-4816-4f1c-a30c-7f9f643027c0",
        true, true)]
    public void InRange_InvalidValueRange_ThrowException(Guid value, Guid min, Guid max, bool excludeMin, bool excludeMax)
    {
        Assert.Throws<GuardException>(()
            => Guard.Value(value).InRange(min, max, excludeMin, excludeMax));
    }
}