using System.Text.RegularExpressions;

namespace ValueGuard.Tests.Extensions;

public sealed class GuardValueExtensionsStringTests
{
    [Fact]
    public void IsEqual_EqualString_NoException()
        => Guard.Value("text").Equal("text");

    [Fact]
    public void IsEqual_NotEqualString_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value("text").Equal("value"));

    [Fact]
    public void IsNotEqual_NotEqualString_NoException()
        => Guard.Value("text").NotEqual("value");

    [Fact]
    public void IsNotEqual_EqualString_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value("text").NotEqual("text"));

    [Fact]
    public void IsEqual_EqualUppercaseStringWithOrdinalIgnoreCaseComparer_NoException()
        => Guard.Value("text").Equal("TEXT", StringComparer.OrdinalIgnoreCase);

    [Fact]
    public void IsEqual_NotEqualUppercaseStringWithOrdinalIgnoreCaseComparer_NoException()
        => Assert.Throws<GuardException>(()
            => Guard.Value("text").Equal("VALUE", StringComparer.OrdinalIgnoreCase));

    [Fact]
    public void IsNotEqual_NotEqualUppercaseStringWithOrdinalIgnoreCaseComparer_NoException()
        => Guard.Value("text").NotEqual("VALUE", StringComparer.OrdinalIgnoreCase);

    [Fact]
    public void IsNotEqual_EqualUppercaseStringWithOrdinalIgnoreCaseComparer_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value("text").NotEqual("TEXT", StringComparer.OrdinalIgnoreCase));

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

    [Fact]
    public void MinLength_LessThanString_NoException()
        => Guard.Value("value").MinLength(2);

    [Fact]
    public void MinLength_GreaterThenString_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value("value").MinLength(10));

    [Fact]
    public void MaxLength_GreaterThanString_NoException()
        => Guard.Value("value").MaxLength(10);

    [Fact]
    public void MaxLength_LessThenString_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value("value").MaxLength(4));

    [Fact]
    public void ExactLength_EqualThanString_NoException()
        => Guard.Value("value").ExactLength(5);

    [Fact]
    public void ExactLength_NotEqualThenString_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value("value").ExactLength(6));

    [Fact]
    public void LengthInRange_InRangeString_NoException()
        => Guard.Value("value").LengthInRange(0, 10);

    [Fact]
    public void LengthInRange_GreaterThanRangeString_NoException()
        => Assert.Throws<GuardException>(()
            => Guard.Value("value").LengthInRange(0, 4));

    [Fact]
    public void LengthInRange_LessThenRangeString_NoException()
        => Assert.Throws<GuardException>(()
            => Guard.Value("value").LengthInRange(10, 20));

    [Fact]
    public void IsMatchesPattern_MatchStringPattern_NoException()
        => Guard.Value("255").IsMatchesPattern(@"^\d+$");

    [Fact]
    public void IsMatchesPattern_NotMatchStringPattern_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value("W255A").IsMatchesPattern(@"^\d+$"));

    [Fact]
    public void IsMatchesPattern_MatchRegexPattern_NoException()
        => Guard.Value("255").IsMatchesPattern(new Regex(@"^\d+$"));

    [Fact]
    public void IsMatchesPattern_NotMatchRegexPattern_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value("W255A").IsMatchesPattern(new Regex(@"^\d+$")));
}