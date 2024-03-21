using ValueGuard.Exceptions;

namespace ValueGuard.Tests;

public sealed class GuardValueExtensionsStringTests
{
    [Fact]
    public void Empty_EmptyString_NoException()
        => Guard.NotNull(string.Empty).Empty();

    [Fact]
    public void Empty_NotEmptyString_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.NotNull("Hello world").Empty());

    [Fact]
    public void NotEmpty_NotEmptyString_NoException()
        => Guard.NotNull("Hello world").NotEmpty();

    [Fact]
    public void NotEmpty_EmptyString_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.NotNull(string.Empty).NotEmpty());

    [Fact]
    public void NotWhiteSpace_NotEmptyString_NoException()
        => Guard.NotNull(" Hello world ").NotWhiteSpace();

    [Fact]
    public void NotWhiteSpace_EmptyString_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.NotNull(string.Empty).NotWhiteSpace());

    [Fact]
    public void NotWhiteSpace_SpaceString_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.NotNull(" ").NotWhiteSpace());

    [Fact]
    public void NotWhiteSpace_TabString_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.NotNull("\t").NotWhiteSpace());
}