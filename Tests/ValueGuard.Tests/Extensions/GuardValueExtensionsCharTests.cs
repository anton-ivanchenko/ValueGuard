namespace ValueGuard.Tests.Extensions;

public sealed class GuardValueExtensionsCharTests
{
    [Theory]
    [InlineData('a', 'a')]
    public void IsEqual_Equals_NoException(char value, char expected)
        => Guard.Value(value).Equal(expected);

    [Theory]
    [InlineData('a', 'b')]
    public void IsEqual_NotEquals_ThrowException(char value, char expected)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).Equal(expected));

    [Theory]
    [InlineData('a', 'b')]
    public void IsNotEqual_NotEquals_NoException(char value, char expected)
        => Guard.Value(value).NotEqual(expected);

    [Theory]
    [InlineData('a', 'a')]
    public void IsNotEqual_Equals_ThrowException(char value, char expected)
        => Assert.Throws<GuardException>(()
            => Guard.Value(value).NotEqual(expected));

    [Fact]
    public void IsDigit_Digit_NoException()
        => Guard.Value('0').IsDigit();

    [Fact]
    public void IsDigit_Letter_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value('a').IsDigit());

    [Fact]
    public void IsLetter_Letter_NoException()
        => Guard.Value('a').IsLetter();

    [Fact]
    public void IsLetter_Digit_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value('0').IsLetter());

    [Fact]
    public void IsLetterOrDigit_Digit_NoException()
        => Guard.Value('0').IsLetterOrDigit();

    [Fact]
    public void IsLetterOrDigit_Letter_NoException()
        => Guard.Value('a').IsLetterOrDigit();

    [Fact]
    public void IsLetterOrDigit_Whitespace_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value(' ').IsLetterOrDigit());

    [Fact]
    public void IsWhiteSpace_WhiteSpace_NoException()
        => Guard.Value(' ').IsWhiteSpace();

    [Fact]
    public void IsWhiteSpace_WhiteSpace_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value('a').IsWhiteSpace());

    [Fact]
    public void IsUpperCase_UpperChar_NoException()
        => Guard.Value('A').IsUpperCase();

    [Fact]
    public void IsUpperCase_LowerChar_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value('a').IsUpperCase());

    [Fact]
    public void IsLowerCase_LowerChar_NoException()
        => Guard.Value('a').IsLowerCase();

    [Fact]
    public void IsLowerCase_UpperChar_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value('A').IsLowerCase());
}