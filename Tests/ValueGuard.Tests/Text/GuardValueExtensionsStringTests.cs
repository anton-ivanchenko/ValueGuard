using System.Text.RegularExpressions;

namespace ValueGuard.Tests.Text;

public sealed class GuardValueExtensionsStringTests
{
    [Fact]
    public void EqualTo_EqualValue_NoException()
        => Guard.Value("text").EqualTo("text");

    [Fact]
    public void EqualTo_NotEqualValue_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value("text").EqualTo("value"));

    [Fact]
    public void NotEqualTo_NotEqualValue_NoException()
        => Guard.Value("text").NotEqualTo("value");

    [Fact]
    public void NotEqualTo_EqualValue_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value("text").NotEqualTo("text"));

    [Fact]
    public void EqualTo_EqualUppercaseValueWithOrdinalIgnoreCaseComparer_NoException()
        => Guard.Value("text").EqualTo("TEXT", StringComparer.OrdinalIgnoreCase);

    [Fact]
    public void EqualTo_NotEqualUppercaseValueWithOrdinalIgnoreCaseComparer_NoException()
        => Assert.Throws<GuardException>(()
            => Guard.Value("text").EqualTo("VALUE", StringComparer.OrdinalIgnoreCase));

    [Fact]
    public void NotEqualTo_NotEqualUppercaseValueWithOrdinalIgnoreCaseComparer_NoException()
        => Guard.Value("text").NotEqualTo("VALUE", StringComparer.OrdinalIgnoreCase);

    [Fact]
    public void NotEqualTo_EqualUppercaseValueWithOrdinalIgnoreCaseComparer_ThrowException()
        => Assert.Throws<GuardException>(()
            => Guard.Value("text").NotEqualTo("TEXT", StringComparer.OrdinalIgnoreCase));

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
    public void HasLengthBetween_InRangeValue_NoException()
        => Guard.Value("value").HasLengthInRange(0, 10);

    [Fact]
    public void HasLengthBetween_GreaterThanRangeValue_NoException()
        => Assert.Throws<GuardException>(()
            => Guard.Value("value").HasLengthInRange(0, 4));

    [Fact]
    public void HasLengthBetween_LessThenRangeValue_NoException()
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