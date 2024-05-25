using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<ushort> IsEqual(this in GuardValue<ushort> guard, ushort value)
        => ref GenericImplementation.IsEqual<ushort, UShortPredicates>(guard, value);

    public static ref readonly GuardValue<ushort> NotEqual(this in GuardValue<ushort> guard, ushort value)
        => ref GenericImplementation.NotEqual<ushort, UShortPredicates>(guard, value);

    public static ref readonly GuardValue<ushort> IsDefault(this in GuardValue<ushort> guard)
        => ref GenericImplementation.IsDefault<ushort, UShortPredicates>(guard);

    public static ref readonly GuardValue<ushort> NotDefault(this in GuardValue<ushort> guard)
        => ref GenericImplementation.NotDefault<ushort, UShortPredicates>(guard);

    public static ref readonly GuardValue<ushort> IsGreater(this in GuardValue<ushort> guard, ushort value)
        => ref GenericImplementation.IsGreater<ushort, UShortPredicates>(guard, value);

    public static ref readonly GuardValue<ushort> IsGreaterOrEqual(this in GuardValue<ushort> guard, ushort value)
        => ref GenericImplementation.IsGreaterOrEqual<ushort, UShortPredicates>(guard, value);

    public static ref readonly GuardValue<ushort> IsLess(this in GuardValue<ushort> guard, ushort value)
        => ref GenericImplementation.IsLess<ushort, UShortPredicates>(guard, value);

    public static ref readonly GuardValue<ushort> IsLessOrEqual(this in GuardValue<ushort> guard, ushort value)
        => ref GenericImplementation.IsLessOrEqual<ushort, UShortPredicates>(guard, value);

    public static ref readonly GuardValue<ushort> InRange(
        this in GuardValue<ushort> guard,
        ushort min,
        ushort max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref GenericImplementation.InRange<ushort, UShortPredicates>(guard, min, max, excludeMin, excludeMax);
}