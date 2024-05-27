using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<ushort> EqualTo(this in GuardValue<ushort> guard, ushort value)
        => ref GenericImplementation.EqualTo<ushort, UShortPredicates>(guard, value);

    public static ref readonly GuardValue<ushort> NotEqualTo(this in GuardValue<ushort> guard, ushort value)
        => ref GenericImplementation.NotEqualTo<ushort, UShortPredicates>(guard, value);

    public static ref readonly GuardValue<ushort> IsDefault(this in GuardValue<ushort> guard)
        => ref GenericImplementation.IsDefault<ushort, UShortPredicates>(guard);

    public static ref readonly GuardValue<ushort> NotDefault(this in GuardValue<ushort> guard)
        => ref GenericImplementation.NotDefault<ushort, UShortPredicates>(guard);

    public static ref readonly GuardValue<ushort> GreaterThan(this in GuardValue<ushort> guard, ushort value)
        => ref GenericImplementation.GreaterThan<ushort, UShortPredicates>(guard, value);

    public static ref readonly GuardValue<ushort> GreaterThanOrEqualTo(this in GuardValue<ushort> guard, ushort value)
        => ref GenericImplementation.GreaterThanOrEqualTo<ushort, UShortPredicates>(guard, value);

    public static ref readonly GuardValue<ushort> LessThan(this in GuardValue<ushort> guard, ushort value)
        => ref GenericImplementation.LessThan<ushort, UShortPredicates>(guard, value);

    public static ref readonly GuardValue<ushort> LessThanOrEqualTo(this in GuardValue<ushort> guard, ushort value)
        => ref GenericImplementation.LessThanOrEqualTo<ushort, UShortPredicates>(guard, value);

    public static ref readonly GuardValue<ushort> Between(
        this in GuardValue<ushort> guard,
        ushort min,
        ushort max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref GenericImplementation.Between<ushort, UShortPredicates>(guard, min, max, excludeMin, excludeMax);
}