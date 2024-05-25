namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<T> Is<T>(this in GuardValue<T> guard, Func<T, bool> predicate)
        => ref guard.Is(predicate, "The condition is not met for this value");

    public static ref readonly GuardValue<T> Is<T>(this in GuardValue<T> guard, Func<T, bool> predicate, string errorMessage)
    {
        if (!predicate.Invoke(guard.Value))
        {
            guard.ThrowException(errorMessage);
        }

        return ref guard;
    }

    public static T GetValue<T>(this in GuardValue<T> guard) => guard.Value;
}