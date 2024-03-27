namespace ValueGuard.Exceptions;

public class GuardException : Exception
{
    public static GuardException Create(string parameterName, string message)
        => new($"Parameter '{parameterName}'. {message}");

    public static GuardException Create<T>(string parameterName, T value, string message)
        => new($"Parameter '{parameterName}' cannot be '{value}'. {message}");

    public GuardException() { }

    public GuardException(string message) : base(message) { }

    public GuardException(string message, Exception innerException) : base(message, innerException) { }
}