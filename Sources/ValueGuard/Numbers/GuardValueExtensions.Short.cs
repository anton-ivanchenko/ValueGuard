using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardContext<short> EqualTo(this in GuardContext<short> guard, short value)
        => ref GenericImplementation.EqualTo<short, ShortPredicates>(guard, value);

    public static ref readonly GuardContext<short> NotEqualTo(this in GuardContext<short> guard, short value)
        => ref GenericImplementation.NotEqualTo<short, ShortPredicates>(guard, value);

    public static ref readonly GuardContext<short> IsDefault(this in GuardContext<short> guard)
        => ref GenericImplementation.IsDefault<short, ShortPredicates>(guard);

    public static ref readonly GuardContext<short> NotDefault(this in GuardContext<short> guard)
        => ref GenericImplementation.NotDefault<short, ShortPredicates>(guard);

    public static ref readonly GuardContext<short> IsPositive(this in GuardContext<short> guard)
        => ref GenericImplementation.GreaterThan<short, ShortPredicates>(guard, default);

    public static ref readonly GuardContext<short> IsNegative(this in GuardContext<short> guard)
        => ref GenericImplementation.LessThan<short, ShortPredicates>(guard, default);

    public static ref readonly GuardContext<short> GreaterThan(this in GuardContext<short> guard, short value)
        => ref GenericImplementation.GreaterThan<short, ShortPredicates>(guard, value);

    public static ref readonly GuardContext<short> GreaterThanOrEqualTo(this in GuardContext<short> guard, short value)
        => ref GenericImplementation.GreaterThanOrEqualTo<short, ShortPredicates>(guard, value);

    public static ref readonly GuardContext<short> LessThan(this in GuardContext<short> guard, short value)
        => ref GenericImplementation.LessThan<short, ShortPredicates>(guard, value);

    public static ref readonly GuardContext<short> LessThanOrEqualTo(this in GuardContext<short> guard, short value)
        => ref GenericImplementation.LessThanOrEqualTo<short, ShortPredicates>(guard, value);

    public static ref readonly GuardContext<short> InRange(
        this in GuardContext<short> guard,
        short min,
        short max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref GenericImplementation.InRange<short, ShortPredicates>(guard, min, max, excludeMin, excludeMax);
}