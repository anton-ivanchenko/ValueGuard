namespace ValueGuard;

// TODO: Perhaps more methods need to be implemented for this type

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<char> IsDigit(this in GuardValue<char> guard)
    {
        if (!char.IsDigit(guard.Value))
        {
            guard.ThrowException("The value must be a digit");
        }

        return ref guard;
    }

    public static ref readonly GuardValue<char> IsLetter(this in GuardValue<char> guard)
    {
        if (!char.IsLetter(guard.Value))
        {
            guard.ThrowException("The value must be a letter");
        }

        return ref guard;
    }

    public static ref readonly GuardValue<char> IsLetterOrDigit(this in GuardValue<char> guard)
    {
        if (!char.IsLetterOrDigit(guard.Value))
        {
            guard.ThrowException("The value must be a letter or digit");
        }

        return ref guard;
    }

    public static ref readonly GuardValue<char> IsWhiteSpace(this in GuardValue<char> guard)
    {
        if (!char.IsWhiteSpace(guard.Value))
        {
            guard.ThrowException("The value must be a whitespace");
        }

        return ref guard;
    }

    public static ref readonly GuardValue<char> IsUpperCase(this in GuardValue<char> guard)
    {
        if (!char.IsUpper(guard.Value))
        {
            guard.ThrowException("The value must be in uppercase");
        }

        return ref guard;
    }

    public static ref readonly GuardValue<char> IsLowerCase(this in GuardValue<char> guard)
    {
        if (!char.IsLower(guard.Value))
        {
            guard.ThrowException("The value must be in lowercase");
        }

        return ref guard;
    }
}