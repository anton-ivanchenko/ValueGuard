namespace ValueGuard.Tests;

public sealed class GuardTests
{
    [Fact]
    public void Null_ValueType_NullValue_NoException()
        => Guard.Null((int?)null);

    [Fact]
    public void Null_ValueType_NotNullValue_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Null((int?)0));

    [Fact]
    public void Null_ReferenceType_NullValue_NoException()
        => Guard.Null((object?)null);

    [Fact]
    public void Null_ReferenceType_NotNullValue_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Null(new object()));

    [Fact]
    public void NotNull_ValueType_NullValue_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.NotNull((int?)null));

    [Fact]
    public void NotNull_ValueType_NotNullValue_NoException()
        => Guard.NotNull((int?)0);

    [Fact]
    public void NotNull_ReferenceType_NullValue_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.NotNull((object?)null));

    [Fact]
    public void NotNull_ReferenceType_NotNullValue_NoException()
        => Guard.NotNull(new object());

    [Fact]
    public void Value_ValueType_NoException()
        => Guard.Value(0);

    [Fact]
    public void Value_ReferenceType_NoException()
        => Guard.Value(new object());
}