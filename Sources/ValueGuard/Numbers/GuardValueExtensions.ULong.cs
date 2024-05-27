using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<ulong> EqualTo(this in GuardValue<ulong> guard, ulong value)
        => ref GenericImplementation.EqualTo<ulong, ULongPredicates>(guard, value);

    public static ref readonly GuardValue<ulong> NotEqualTo(this in GuardValue<ulong> guard, ulong value)
        => ref GenericImplementation.NotEqualTo<ulong, ULongPredicates>(guard, value);

    public static ref readonly GuardValue<ulong> IsDefault(this in GuardValue<ulong> guard)
        => ref GenericImplementation.IsDefault<ulong, ULongPredicates>(guard);

    public static ref readonly GuardValue<ulong> NotDefault(this in GuardValue<ulong> guard)
        => ref GenericImplementation.NotDefault<ulong, ULongPredicates>(guard);

    public static ref readonly GuardValue<ulong> GreaterThan(this in GuardValue<ulong> guard, ulong value)
        => ref GenericImplementation.GreaterThan<ulong, ULongPredicates>(guard, value);

    public static ref readonly GuardValue<ulong> GreaterThanOrEqualTo(this in GuardValue<ulong> guard, ulong value)
        => ref GenericImplementation.GreaterThanOrEqualTo<ulong, ULongPredicates>(guard, value);

    public static ref readonly GuardValue<ulong> LessThan(this in GuardValue<ulong> guard, ulong value)
        => ref GenericImplementation.LessThan<ulong, ULongPredicates>(guard, value);

    public static ref readonly GuardValue<ulong> LessThanOrEqualTo(this in GuardValue<ulong> guard, ulong value)
        => ref GenericImplementation.LessThanOrEqualTo<ulong, ULongPredicates>(guard, value);

    public static ref readonly GuardValue<ulong> Between(
        this in GuardValue<ulong> guard,
        ulong min,
        ulong max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref GenericImplementation.Between<ulong, ULongPredicates>(guard, min, max, excludeMin, excludeMax);
}