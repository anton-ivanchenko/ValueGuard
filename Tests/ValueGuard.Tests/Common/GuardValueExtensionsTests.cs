namespace ValueGuard.Tests.Common;

public sealed class GuardValueExtensionsTests
{
    [Fact]
    public void Must_TruePredicate_NoException()
        => Guard.Value(1).Must(i => i > 0);

    [Fact]
    public void Must_FalsePredicate_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value(1).Must(i => i < 0));

    [Fact]
    public void Must_TruePredicate_Message_NoException()
        => Guard.Value(1)
            .Must(i => i > 0, "Value cannot be less or equal zero");

    [Fact]
    public void Must_FalsePredicate_Message_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value(1).Must(i => i < 0, "Value must be less zero"));

    [Fact]
    public void GetValue_ReturnOriginalValue()
    {
        const string value = "hello";

        Assert.Equal(value,
            Guard.NotNull(value).GetValue());
    }
}