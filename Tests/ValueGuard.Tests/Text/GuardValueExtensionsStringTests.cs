using System.Text.RegularExpressions;

namespace ValueGuard.Tests.Text;

public sealed class GuardValueExtensionsStringTests
{
    [Fact]
    public void IsEqual_EqualValue_NoException()
        => Guard.Value("text").IsEqual("text");

    [Fact]
    public void IsEqual_NotEqualValue_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value("text").IsEqual("value"));

    [Fact]
    public void NotEqual_NotEqualValue_NoException()
        => Guard.Value("text").NotEqual("value");

    [Fact]
    public void NotEqual_EqualValue_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value("text").NotEqual("text"));

    [Fact]
    public void IsEqual_EqualUppercaseValueWithOrdinalIgnoreCaseComparer_NoException()
        => Guard.Value("text").IsEqual("TEXT", StringComparer.OrdinalIgnoreCase);

    [Fact]
    public void IsEqual_NotEqualUppercaseValueWithOrdinalIgnoreCaseComparer_NoException()
        => Assert.Throws<GuardException>(()
            => Guard.Value("text").IsEqual("VALUE", StringComparer.OrdinalIgnoreCase));

    [Fact]
    public void NotEqual_NotEqualUppercaseValueWithOrdinalIgnoreCaseComparer_NoException()
        => Guard.Value("text").NotEqual("VALUE", StringComparer.OrdinalIgnoreCase);

    [Fact]
    public void NotEqual_EqualUppercaseValueWithOrdinalIgnoreCaseComparer_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value("text").NotEqual("TEXT", StringComparer.OrdinalIgnoreCase));

    [Fact]
    public void IsEmpty_EmptyValue_NoException()
        => Guard.NotNull(string.Empty).IsEmpty();

    [Fact]
    public void IsEmpty_NotEmptyValue_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.NotNull("Hello world").IsEmpty());

    [Fact]
    public void NotEmpty_NotEmptyValue_NoException()
        => Guard.NotNull("Hello world").NotEmpty();

    [Fact]
    public void NotEmpty_EmptyValue_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.NotNull(string.Empty).NotEmpty());

    [Fact]
    public void IsWhiteSpace_WhiteSpaceValue_NoException()
        => Guard.Value(" \t ").IsWhiteSpace();

    [Fact]
    public void IsWhiteSpace_EmptyValue_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value(" \t a \t ").IsWhiteSpace());

    [Fact]
    public void NotWhiteSpace_NotEmptyValue_NoException()
        => Guard.NotNull(" Hello world ").NotWhiteSpace();

    [Fact]
    public void NotWhiteSpace_EmptyValue_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.NotNull(string.Empty).NotWhiteSpace());

    [Fact]
    public void NotWhiteSpace_SpaceValue_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.NotNull(" ").NotWhiteSpace());

    [Fact]
    public void NotWhiteSpace_TabValue_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.NotNull("\t").NotWhiteSpace());

    [Fact]
    public void HasMinLength_LessThanValue_NoException()
        => Guard.Value("value").HasMinLength(2);

    [Fact]
    public void HasMinLength_GreaterThenValue_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value("value").HasMinLength(10));

    [Fact]
    public void HasMaxLength_GreaterThanValue_NoException()
        => Guard.Value("value").HasMaxLength(10);

    [Fact]
    public void HasMaxLength_LessThenValue_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value("value").HasMaxLength(4));

    [Fact]
    public void HasExactLength_EqualThanValue_NoException()
        => Guard.Value("value").HasExactLength(5);

    [Fact]
    public void HasExactLength_NotEqualThenValue_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value("value").HasExactLength(6));

    [Fact]
    public void HasLengthInRange_InRangeValue_NoException()
        => Guard.Value("value").HasLengthInRange(0, 10);

    [Fact]
    public void HasLengthInRange_GreaterThanRangeValue_NoException()
        => Assert.Throws<GuardException>(()
            => Guard.Value("value").HasLengthInRange(0, 4));

    [Fact]
    public void HasLengthInRange_LessThenRangeValue_NoException()
        => Assert.Throws<GuardException>(()
            => Guard.Value("value").HasLengthInRange(10, 20));

    [Fact]
    public void MatchesPattern_MatchValuePattern_NoException()
        => Guard.Value("255").MatchesPattern(@"^\d+$");

    [Fact]
    public void MatchesPattern_NotMatchValuePattern_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value("W255A").MatchesPattern(@"^\d+$"));

    [Fact]
    public void MatchesPattern_MatchRegexPattern_NoException()
        => Guard.Value("255").MatchesPattern(new Regex(@"^\d+$"));

    [Fact]
    public void MatchesPattern_NotMatchRegexPattern_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value("W255A").MatchesPattern(new Regex(@"^\d+$")));
}