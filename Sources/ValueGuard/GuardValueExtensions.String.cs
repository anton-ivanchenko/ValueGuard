namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<string> IsEmpty(this in GuardValue<string> guard)
    {
        if (guard.Value.Length > 0)
        {
            guard.ThrowException("String must be empty");
        }

        return ref guard;
    }

    public static ref readonly GuardValue<string> IsNotEmpty(this in GuardValue<string> guard)
    {
        if (string.IsNullOrEmpty(guard.Value))
        {
            guard.ThrowException("String cannot be empty");
        }

        return ref guard;
    }

    public static ref readonly GuardValue<string> IsNotWhiteSpace(this in GuardValue<string> guard)
    {
        if (string.IsNullOrWhiteSpace(guard.Value))
        {
            guard.ThrowException("String cannot be null and must have at least one not white space character");
        }

        return ref guard;
    }
}