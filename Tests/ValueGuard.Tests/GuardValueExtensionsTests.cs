namespace ValueGuard.Tests;

public sealed class GuardValueExtensionsTests
{
    [Fact]
    public void Is_TrueCondition_NoException()
        => Guard.Value(1).Is(i => i > 0);

    [Fact]
    public void Is_FalseCondition_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value(1).Is(i => i < 0));

    [Fact]
    public void Is_TrueConditionWithMessage_NoException()
        => Guard.Value(1)
            .Is(i => i > 0, "Value cannot be less or equal zero");

    [Fact]
    public void Is_FalseConditionWithMessage_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value(1).Is(i => i < 0, "Value must be less zero"));

    [Fact]
    public void GetValue_ReturnOriginalValue()
    {
        const string value = "hello";

        Assert.Equal(value,
            Guard.NotNull(value).GetValue());
    }
}