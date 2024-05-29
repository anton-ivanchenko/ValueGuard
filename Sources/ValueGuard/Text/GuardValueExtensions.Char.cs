using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardContext<char> EqualTo(this in GuardContext<char> guard, char value)
        => ref GenericImplementation.EqualTo<char, CharPredicates>(guard, value);

    public static ref readonly GuardContext<char> NotEqualTo(this in GuardContext<char> guard, char value)
        => ref GenericImplementation.NotEqualTo<char, CharPredicates>(guard, value);

    public static ref readonly GuardContext<char> IsDigit(this in GuardContext<char> guard)
    {
        if (!char.IsDigit(guard.Value))
        {
            guard.ThrowException("The value must be a digit");
        }

        return ref guard;
    }

    public static ref readonly GuardContext<char> IsLetter(this in GuardContext<char> guard)
    {
        if (!char.IsLetter(guard.Value))
        {
            guard.ThrowException("The value must be a letter");
        }

        return ref guard;
    }

    public static ref readonly GuardContext<char> IsLetterOrDigit(this in GuardContext<char> guard)
    {
        if (!char.IsLetterOrDigit(guard.Value))
        {
            guard.ThrowException("The value must be a letter or digit");
        }

        return ref guard;
    }

    public static ref readonly GuardContext<char> IsWhiteSpace(this in GuardContext<char> guard)
    {
        if (!char.IsWhiteSpace(guard.Value))
        {
            guard.ThrowException("The value must be a whitespace");
        }

        return ref guard;
    }

    public static ref readonly GuardContext<char> IsUpperCase(this in GuardContext<char> guard)
    {
        if (!char.IsUpper(guard.Value))
        {
            guard.ThrowException("The value must be in uppercase");
        }

        return ref guard;
    }

    public static ref readonly GuardContext<char> IsLowerCase(this in GuardContext<char> guard)
    {
        if (!char.IsLower(guard.Value))
        {
            guard.ThrowException("The value must be in lowercase");
        }

        return ref guard;
    }
}