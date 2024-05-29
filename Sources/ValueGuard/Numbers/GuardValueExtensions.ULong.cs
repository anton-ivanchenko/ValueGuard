using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardContext<ulong> EqualTo(this in GuardContext<ulong> guard, ulong value)
        => ref GenericImplementation.EqualTo<ulong, ULongPredicates>(guard, value);

    public static ref readonly GuardContext<ulong> NotEqualTo(this in GuardContext<ulong> guard, ulong value)
        => ref GenericImplementation.NotEqualTo<ulong, ULongPredicates>(guard, value);

    public static ref readonly GuardContext<ulong> IsDefault(this in GuardContext<ulong> guard)
        => ref GenericImplementation.IsDefault<ulong, ULongPredicates>(guard);

    public static ref readonly GuardContext<ulong> NotDefault(this in GuardContext<ulong> guard)
        => ref GenericImplementation.NotDefault<ulong, ULongPredicates>(guard);

    public static ref readonly GuardContext<ulong> GreaterThan(this in GuardContext<ulong> guard, ulong value)
        => ref GenericImplementation.GreaterThan<ulong, ULongPredicates>(guard, value);

    public static ref readonly GuardContext<ulong> GreaterThanOrEqualTo(this in GuardContext<ulong> guard, ulong value)
        => ref GenericImplementation.GreaterThanOrEqualTo<ulong, ULongPredicates>(guard, value);

    public static ref readonly GuardContext<ulong> LessThan(this in GuardContext<ulong> guard, ulong value)
        => ref GenericImplementation.LessThan<ulong, ULongPredicates>(guard, value);

    public static ref readonly GuardContext<ulong> LessThanOrEqualTo(this in GuardContext<ulong> guard, ulong value)
        => ref GenericImplementation.LessThanOrEqualTo<ulong, ULongPredicates>(guard, value);

    public static ref readonly GuardContext<ulong> InRange(
        this in GuardContext<ulong> guard,
        ulong min,
        ulong max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref GenericImplementation.InRange<ulong, ULongPredicates>(guard, min, max, excludeMin, excludeMax);
}