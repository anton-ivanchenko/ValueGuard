namespace ValueGuard.Tests;

public sealed class GuardTests
{
    [Theory]
    [InlineData(null)]
    public void IsNull_ValueType_NullValue_NoException(int? number)
        => Guard.IsNull(number);

    [Theory]
    [InlineData(0)]
    public void IsNull_ValueType_NotNullValue_ThrowException(int? number)
        => Assert.Throws<GuardException>(()
            => Guard.IsNull(number));

    [Theory]
    [InlineData(null)]
    public void IsNull_ReferenceType_NullValue_NoException(object? instance)
        => Guard.IsNull(instance);

    [Theory]
    [InlineData(0)]
    public void IsNull_ReferenceType_NotNullValue_ThrowException(object? instance)
        => Assert.Throws<GuardException>(()
            => Guard.IsNull(instance));

    [Theory]
    [InlineData(null)]
    public void NotNull_ValueType_NullValue_ThrowException(int? number)
        => Assert.Throws<GuardException>(()
            => Guard.NotNull(number));

    [Theory]
    [InlineData(0)]
    public void NotNull_ValueType_NotNullValue_NoException(int? number)
        => Guard.NotNull(number);

    [Theory]
    [InlineData(null)]
    public void NotNull_ReferenceType_NullValue_ThrowException(object? instance)
        => Assert.Throws<GuardException>(()
            => Guard.NotNull(instance));

    [Theory]
    [InlineData(0)]
    public void NotNull_ReferenceType_NotNullValue_NoException(object? instance)
        => Guard.NotNull(instance);

    [Theory]
    [InlineData(0)]
    public void Value_ValueType_NoException(int number)
        => Guard.Value(number);

    [Theory]
    [InlineData(0)]
    public void Value_ReferenceType_NoException(object instance)
        => Guard.Value(instance);
}