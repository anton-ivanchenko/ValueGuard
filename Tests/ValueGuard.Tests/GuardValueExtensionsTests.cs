namespace ValueGuard.Tests;

public class GuardValueExtensionsTests
{
    [Fact]
    public void GetValue_ReturnOriginalValue()
        => Assert.Equal("hello world",
            Guard.NotNull("hello world").GetValue());
}