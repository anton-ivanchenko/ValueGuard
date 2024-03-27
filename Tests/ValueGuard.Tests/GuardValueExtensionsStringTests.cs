using ValueGuard.Exceptions;

namespace ValueGuard.Tests;

public sealed class GuardValueExtensionsStringTests
{
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