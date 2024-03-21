namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<bool> IsTrue(this in GuardValue<bool> guard)
    {
        if (!guard.Value)
        {
            guard.ThrowException("The value must be \"true\"");
        }

        return ref guard;
    }

    public static ref readonly GuardValue<bool> IsFalse(this in GuardValue<bool> guard)
    {
        if (guard.Value)
        {
            guard.ThrowException("The value must be \"false\"");
        }

        return ref guard;
    }
}