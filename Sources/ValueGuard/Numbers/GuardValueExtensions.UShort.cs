using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardContext<ushort> EqualTo(this in GuardContext<ushort> guard, ushort value)
        => ref GenericImplementation.EqualTo<ushort, UShortPredicates>(guard, value);

    public static ref readonly GuardContext<ushort> NotEqualTo(this in GuardContext<ushort> guard, ushort value)
        => ref GenericImplementation.NotEqualTo<ushort, UShortPredicates>(guard, value);

    public static ref readonly GuardContext<ushort> IsDefault(this in GuardContext<ushort> guard)
        => ref GenericImplementation.IsDefault<ushort, UShortPredicates>(guard);

    public static ref readonly GuardContext<ushort> NotDefault(this in GuardContext<ushort> guard)
        => ref GenericImplementation.NotDefault<ushort, UShortPredicates>(guard);

    public static ref readonly GuardContext<ushort> GreaterThan(this in GuardContext<ushort> guard, ushort value)
        => ref GenericImplementation.GreaterThan<ushort, UShortPredicates>(guard, value);

    public static ref readonly GuardContext<ushort> GreaterThanOrEqualTo(this in GuardContext<ushort> guard, ushort value)
        => ref GenericImplementation.GreaterThanOrEqualTo<ushort, UShortPredicates>(guard, value);

    public static ref readonly GuardContext<ushort> LessThan(this in GuardContext<ushort> guard, ushort value)
        => ref GenericImplementation.LessThan<ushort, UShortPredicates>(guard, value);

    public static ref readonly GuardContext<ushort> LessThanOrEqualTo(this in GuardContext<ushort> guard, ushort value)
        => ref GenericImplementation.LessThanOrEqualTo<ushort, UShortPredicates>(guard, value);

    public static ref readonly GuardContext<ushort> InRange(
        this in GuardContext<ushort> guard,
        ushort min,
        ushort max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref GenericImplementation.InRange<ushort, UShortPredicates>(guard, min, max, excludeMin, excludeMax);
}