namespace ValueGuard;

public sealed class GuardException : Exception
{
    private GuardException(string message) : base(message) { }

    public static GuardException Create<T>(string parameterName, T value, string message)
    {
        if (value is not null && Guard.Settings.ShowParameterValueInException)
        {
            return new($"Parameter '{parameterName}' cannot be '{value}'. {message}");
        }

        return new($"Parameter '{parameterName}'. {message}");
    }
}