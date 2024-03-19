namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static T GetValue<T>(this in GuardValue<T> guard) => guard.Value;
}