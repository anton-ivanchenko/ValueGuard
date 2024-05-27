namespace ValueGuard.Tests.Common;

public sealed class GuardValueExtensionsTests
{
    [Fact]
    public void Is_TruePredicate_NoException()
        => Guard.Value(1).Is(i => i > 0);

    [Fact]
    public void Is_FalsePredicate_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value(1).Is(i => i < 0));

    [Fact]
    public void Is_TruePredicate_Message_NoException()
        => Guard.Value(1)
            .Is(i => i > 0, "Value cannot be less or equal zero");

    [Fact]
    public void Is_FalsePredicate_Message_ThrowException()
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