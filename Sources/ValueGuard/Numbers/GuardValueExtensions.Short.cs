using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<short> EqualTo(this in GuardValue<short> guard, short value)
        => ref GenericImplementation.EqualTo<short, ShortPredicates>(guard, value);

    public static ref readonly GuardValue<short> NotEqualTo(this in GuardValue<short> guard, short value)
        => ref GenericImplementation.NotEqualTo<short, ShortPredicates>(guard, value);

    public static ref readonly GuardValue<short> IsDefault(this in GuardValue<short> guard)
        => ref GenericImplementation.IsDefault<short, ShortPredicates>(guard);

    public static ref readonly GuardValue<short> NotDefault(this in GuardValue<short> guard)
        => ref GenericImplementation.NotDefault<short, ShortPredicates>(guard);

    public static ref readonly GuardValue<short> IsPositive(this in GuardValue<short> guard)
        => ref GenericImplementation.GreaterThan<short, ShortPredicates>(guard, default);

    public static ref readonly GuardValue<short> IsNegative(this in GuardValue<short> guard)
        => ref GenericImplementation.LessThan<short, ShortPredicates>(guard, default);

    public static ref readonly GuardValue<short> GreaterThan(this in GuardValue<short> guard, short value)
        => ref GenericImplementation.GreaterThan<short, ShortPredicates>(guard, value);

    public static ref readonly GuardValue<short> GreaterThanOrEqualTo(this in GuardValue<short> guard, short value)
        => ref GenericImplementation.GreaterThanOrEqualTo<short, ShortPredicates>(guard, value);

    public static ref readonly GuardValue<short> LessThan(this in GuardValue<short> guard, short value)
        => ref GenericImplementation.LessThan<short, ShortPredicates>(guard, value);

    public static ref readonly GuardValue<short> LessThanOrEqualTo(this in GuardValue<short> guard, short value)
        => ref GenericImplementation.LessThanOrEqualTo<short, ShortPredicates>(guard, value);

    public static ref readonly GuardValue<short> Between(
        this in GuardValue<short> guard,
        short min,
        short max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref GenericImplementation.Between<short, ShortPredicates>(guard, min, max, excludeMin, excludeMax);
}