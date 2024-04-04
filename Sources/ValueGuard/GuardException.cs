namespace ValueGuard;

public sealed class GuardException : Exception
{
    public GuardException(string message) : base(message) { }

    public GuardException(string message, Exception innerException) : base(message, innerException) { }

    public static GuardException Create(string parameterName, string message)
        => new($"Parameter '{parameterName}'. {message}");

    public static GuardException Create<T>(string parameterName, T value, string message)
        => new($"Parameter '{parameterName}' cannot be '{value}'. {message}");
}