namespace ValueGuard.Tests.Common;

public sealed class GuardValueExtensionsBoolTests
{
    [Theory]
    [InlineData(true, true)]
    [InlineData(false, false)]
    public void EqualTo_EqualValue_NoException(bool value, bool expected)
        => Guard.Value(value).EqualTo(expected);

    [Theory]
    [InlineData(true, false)]
    [InlineData(false, true)]
    public void EqualTo_NotEqualValue_ThrowException(bool value, bool expected)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).EqualTo(expected));

    [Theory]
    [InlineData(true, false)]
    [InlineData(false, true)]
    public void NotEqualTo_NotEqualValue_NoException(bool value, bool expected)
        => Guard.Value(value).NotEqualTo(expected);

    [Theory]
    [InlineData(true, true)]
    [InlineData(false, false)]
    public void NotEqualTo_EqualValue_ThrowException(bool value, bool expected)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).NotEqualTo(expected));

    [Fact]
    public void IsTrue_TrueValue_NoException()
        => Guard.Value(true).IsTrue();

    [Fact]
    public void IsTrue_FalseValue_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value(false).IsTrue());

    [Fact]
    public void IsFalse_TrueValue_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value(true).IsFalse());

    [Fact]
    public void IsFalse_FalseValue_NoException()
        => Guard.Value(false).IsFalse();
}