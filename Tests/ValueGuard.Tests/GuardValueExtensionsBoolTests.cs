using ValueGuard.Exceptions;

namespace ValueGuard.Tests;

public class GuardValueExtensionsBoolTests
{
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