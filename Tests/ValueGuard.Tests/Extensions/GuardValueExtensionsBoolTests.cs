namespace ValueGuard.Tests.Extensions;

public sealed class GuardValueExtensionsBoolTests
{
    [Theory]
    [InlineData(true, true)]
    [InlineData(false, false)]
    public void IsEqual_Equal_NoException(bool value, bool expected)
        => Guard.Value(value).IsEqual(expected);

    [Theory]
    [InlineData(true, false)]
    [InlineData(false, true)]
    public void IsEqual_NotEqual_ThrowException(bool value, bool expected)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).IsEqual(expected));

    [Theory]
    [InlineData(true, false)]
    [InlineData(false, true)]
    public void IsNotEqual_NotEqual_NoException(bool value, bool expected)
        => Guard.Value(value).IsNotEqual(expected);

    [Theory]
    [InlineData(true, true)]
    [InlineData(false, false)]
    public void IsNotEqual_Equal_ThrowException(bool value, bool expected)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).IsNotEqual(expected));

    [Fact]
    public void IsTrue_True_NoException()
        => Guard.Value(true).IsTrue();

    [Fact]
    public void IsTrue_False_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value(false).IsTrue());

    [Fact]
    public void IsFalse_True_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value(true).IsFalse());

    [Fact]
    public void IsFalse_False_NoException()
        => Guard.Value(false).IsFalse();
}