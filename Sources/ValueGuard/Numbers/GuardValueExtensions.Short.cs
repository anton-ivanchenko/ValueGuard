using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<short> IsEqual(this in GuardValue<short> guard, short value)
        => ref GenericImplementation.IsEqual<short, ShortPredicates>(guard, value);

    public static ref readonly GuardValue<short> NotEqual(this in GuardValue<short> guard, short value)
        => ref GenericImplementation.NotEqual<short, ShortPredicates>(guard, value);

    public static ref readonly GuardValue<short> IsDefault(this in GuardValue<short> guard)
        => ref GenericImplementation.IsDefault<short, ShortPredicates>(guard);

    public static ref readonly GuardValue<short> NotDefault(this in GuardValue<short> guard)
        => ref GenericImplementation.NotDefault<short, ShortPredicates>(guard);

    public static ref readonly GuardValue<short> IsPositive(this in GuardValue<short> guard)
        => ref GenericImplementation.IsGreater<short, ShortPredicates>(guard, default);

    public static ref readonly GuardValue<short> IsNegative(this in GuardValue<short> guard)
        => ref GenericImplementation.IsLess<short, ShortPredicates>(guard, default);

    public static ref readonly GuardValue<short> IsGreater(this in GuardValue<short> guard, short value)
        => ref GenericImplementation.IsGreater<short, ShortPredicates>(guard, value);

    public static ref readonly GuardValue<short> IsGreaterOrEqual(this in GuardValue<short> guard, short value)
        => ref GenericImplementation.IsGreaterOrEqual<short, ShortPredicates>(guard, value);

    public static ref readonly GuardValue<short> IsLess(this in GuardValue<short> guard, short value)
        => ref GenericImplementation.IsLess<short, ShortPredicates>(guard, value);

    public static ref readonly GuardValue<short> IsLessOrEqual(this in GuardValue<short> guard, short value)
        => ref GenericImplementation.IsLessOrEqual<short, ShortPredicates>(guard, value);

    public static ref readonly GuardValue<short> InRange(
        this in GuardValue<short> guard,
        short min,
        short max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref GenericImplementation.InRange<short, ShortPredicates>(guard, min, max, excludeMin, excludeMax);
}