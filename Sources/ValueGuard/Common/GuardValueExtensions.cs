namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardContext<T> Must<T>(this in GuardContext<T> guard, Func<T, bool> predicate)
        => ref guard.Must(predicate, "The value does not satisfy the specified predicate.");

    public static ref readonly GuardContext<T> Must<T>(this in GuardContext<T> guard, Func<T, bool> predicate, string errorMessage)
    {
        if (!predicate.Invoke(guard.Value))
        {
            guard.ThrowException(errorMessage);
        }

        return ref guard;
    }

    public static T GetValue<T>(this in GuardContext<T> guard) => guard.Value;
}