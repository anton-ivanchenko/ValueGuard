namespace ValueGuard.Tests.Common;

public sealed class GuardValueExtensionsBoolTests
{
    [Theory]
    [InlineData(true, true)]
    [InlineData(false, false)]
    public void IsEqual_EqualValue_NoException(bool value, bool expected)
        => Guard.Value(value).IsEqual(expected);

    [Theory]
    [InlineData(true, false)]
    [InlineData(false, true)]
    public void IsEqual_NotEqualValue_ThrowException(bool value, bool expected)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).IsEqual(expected));

    [Theory]
    [InlineData(true, false)]
    [InlineData(false, true)]
    public void NotEqual_NotEqualValue_NoException(bool value, bool expected)
        => Guard.Value(value).NotEqual(expected);

    [Theory]
    [InlineData(true, true)]
    [InlineData(false, false)]
    public void NotEqual_EqualValue_ThrowException(bool value, bool expected)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).NotEqual(expected));

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