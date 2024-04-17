namespace ValueGuard.Tests;

public sealed class GuardValueExtensionsStringTests
{
    [Fact]
    public void IsEqual_EqualString_NoException()
        => Guard.Value("text").IsEqual("text");

    [Fact]
    public void IsEqual_NotEqualString_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value("text").IsEqual("value"));

    [Fact]
    public void IsNotEqual_NotEqualString_NoException()
        => Guard.Value("text").IsNotEqual("value");

    [Fact]
    public void IsNotEqual_EqualString_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value("text").IsNotEqual("text"));

    [Fact]
    public void IsEqual_EqualUppercaseStringWithOrdinalIgnoreCaseComparer_NoException()
        => Guard.Value("text").IsEqual("TEXT", StringComparer.OrdinalIgnoreCase);

    [Fact]
    public void IsEqual_NotEqualUppercaseStringWithOrdinalIgnoreCaseComparer_NoException()
        => Assert.Throws<GuardException>(()
            => Guard.Value("text").IsEqual("VALUE", StringComparer.OrdinalIgnoreCase));

    [Fact]
    public void IsNotEqual_NotEqualUppercaseStringWithOrdinalIgnoreCaseComparer_NoException()
        => Guard.Value("text").IsNotEqual("VALUE", StringComparer.OrdinalIgnoreCase);

    [Fact]
    public void IsNotEqual_EqualUppercaseStringWithOrdinalIgnoreCaseComparer_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value("text").IsNotEqual("TEXT", StringComparer.OrdinalIgnoreCase));

    [Fact]
    public void IsEmpty_EmptyString_NoException()
        => Guard.NotNull(string.Empty).IsEmpty();

    [Fact]
    public void IsEmpty_NotEmptyString_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.NotNull("Hello world").IsEmpty());

    [Fact]
    public void IsNotEmpty_NotEmptyString_NoException()
        => Guard.NotNull("Hello world").IsNotEmpty();

    [Fact]
    public void IsNotEmpty_EmptyString_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.NotNull(string.Empty).IsNotEmpty());

    [Fact]
    public void IsWhiteSpace_WhiteSpaceString_NoException()
        => Guard.Value(" \t ").IsWhiteSpace();

    [Fact]
    public void IsWhiteSpace_EmptyString_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value(" \t a \t ").IsWhiteSpace());

    [Fact]
    public void IsNotWhiteSpace_NotEmptyString_NoException()
        => Guard.NotNull(" Hello world ").IsNotWhiteSpace();

    [Fact]
    public void IsNotWhiteSpace_EmptyString_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.NotNull(string.Empty).IsNotWhiteSpace());

    [Fact]
    public void IsNotWhiteSpace_SpaceString_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.NotNull(" ").IsNotWhiteSpace());

    [Fact]
    public void IsNotWhiteSpace_TabString_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.NotNull("\t").IsNotWhiteSpace());
}