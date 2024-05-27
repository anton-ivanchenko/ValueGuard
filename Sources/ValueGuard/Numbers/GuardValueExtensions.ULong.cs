using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<ulong> IsEqual(this in GuardValue<ulong> guard, ulong value)
        => ref GenericImplementation.IsEqual<ulong, ULongPredicates>(guard, value);

    public static ref readonly GuardValue<ulong> NotEqual(this in GuardValue<ulong> guard, ulong value)
        => ref GenericImplementation.NotEqual<ulong, ULongPredicates>(guard, value);

    public static ref readonly GuardValue<ulong> IsDefault(this in GuardValue<ulong> guard)
        => ref GenericImplementation.IsDefault<ulong, ULongPredicates>(guard);

    public static ref readonly GuardValue<ulong> NotDefault(this in GuardValue<ulong> guard)
        => ref GenericImplementation.NotDefault<ulong, ULongPredicates>(guard);

    public static ref readonly GuardValue<ulong> IsGreater(this in GuardValue<ulong> guard, ulong value)
        => ref GenericImplementation.IsGreater<ulong, ULongPredicates>(guard, value);

    public static ref readonly GuardValue<ulong> IsGreaterOrEqual(this in GuardValue<ulong> guard, ulong value)
        => ref GenericImplementation.IsGreaterOrEqual<ulong, ULongPredicates>(guard, value);

    public static ref readonly GuardValue<ulong> IsLess(this in GuardValue<ulong> guard, ulong value)
        => ref GenericImplementation.IsLess<ulong, ULongPredicates>(guard, value);

    public static ref readonly GuardValue<ulong> IsLessOrEqual(this in GuardValue<ulong> guard, ulong value)
        => ref GenericImplementation.IsLessOrEqual<ulong, ULongPredicates>(guard, value);

    public static ref readonly GuardValue<ulong> InRange(
        this in GuardValue<ulong> guard,
        ulong min,
        ulong max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref GenericImplementation.InRange<ulong, ULongPredicates>(guard, min, max, excludeMin, excludeMax);
}