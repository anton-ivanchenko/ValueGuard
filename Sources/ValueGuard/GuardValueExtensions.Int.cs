namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<int> IsZero(this in GuardValue<int> guard)
    {
        if (guard.Value != 0)
        {
            guard.ThrowException("The value must be zero");
        }

        return ref guard;
    }

    public static ref readonly GuardValue<int> IsNotZero(this in GuardValue<int> guard)
    {
        if (guard.Value == 0)
        {
            guard.ThrowException("The value must not be zero");
        }

        return ref guard;
    }

    public static ref readonly GuardValue<int> IsPositive(this in GuardValue<int> guard)
    {
        if (guard.Value <= 0)
        {
            guard.ThrowException("The value must be positive");
        }

        return ref guard;
    }

    public static ref readonly GuardValue<int> IsNegative(this in GuardValue<int> guard)
    {
        if (guard.Value >= 0)
        {
            guard.ThrowException("The value must be negative");
        }

        return ref guard;
    }

    public static ref readonly GuardValue<int> Greater(this in GuardValue<int> guard, int value)
    {
        if (guard.Value <= value)
        {
            guard.ThrowException($"The value must be greater than {value}");
        }

        return ref guard;
    }

    public static ref readonly GuardValue<int> GreaterOrEqual(this in GuardValue<int> guard, int value)
    {
        if (guard.Value < value)
        {
            guard.ThrowException($"The value must be greater than or equal to {value}");
        }

        return ref guard;
    }

    public static ref readonly GuardValue<int> Less(this in GuardValue<int> guard, int value)
    {
        if (guard.Value >= value)
        {
            guard.ThrowException($"The value must be less than {value}");
        }

        return ref guard;
    }

    public static ref readonly GuardValue<int> LessOrEqual(this in GuardValue<int> guard, int value)
    {
        if (guard.Value > value)
        {
            guard.ThrowException($"The value must be less than or equal to {value}");
        }

        return ref guard;
    }

    public static ref readonly GuardValue<int> InRange(this in GuardValue<int> guard, int min, int max, bool excludeMin = false, bool excludeMax = false)
    {
        switch (excludeMin, excludeMax)
        {
            case (true, true) when guard.Value <= min || guard.Value >= max:
                guard.ThrowException($"The value must be in the range {min} to {max}, exclusive");
                break;

            case (true, false) when guard.Value <= min || guard.Value > max:
                guard.ThrowException($"The value must be in the range {min} to {max}, excluding min but including max");
                break;

            case (false, true) when guard.Value < min || guard.Value >= max:
                guard.ThrowException($"The value must be in the range {min} to {max}, including min but excluding max");
                break;

            case (false, false) when guard.Value < min || guard.Value > max:
                guard.ThrowException($"The value must be in the range {min} to {max}, inclusive");
                break;
        }

        return ref guard;
    }
}