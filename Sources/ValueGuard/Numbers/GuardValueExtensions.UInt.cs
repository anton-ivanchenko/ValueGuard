using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<uint> IsEqual(this in GuardValue<uint> guard, uint value)
        => ref GenericImplementation.IsEqual<uint, UIntPredicates>(guard, value);

    public static ref readonly GuardValue<uint> NotEqual(this in GuardValue<uint> guard, uint value)
        => ref GenericImplementation.NotEqual<uint, UIntPredicates>(guard, value);

    public static ref readonly GuardValue<uint> IsDefault(this in GuardValue<uint> guard)
        => ref GenericImplementation.IsDefault<uint, UIntPredicates>(guard);

    public static ref readonly GuardValue<uint> NotDefault(this in GuardValue<uint> guard)
        => ref GenericImplementation.NotDefault<uint, UIntPredicates>(guard);

    public static ref readonly GuardValue<uint> IsGreater(this in GuardValue<uint> guard, uint value)
        => ref GenericImplementation.IsGreater<uint, UIntPredicates>(guard, value);

    public static ref readonly GuardValue<uint> IsGreaterOrEqual(this in GuardValue<uint> guard, uint value)
        => ref GenericImplementation.IsGreaterOrEqual<uint, UIntPredicates>(guard, value);

    public static ref readonly GuardValue<uint> IsLess(this in GuardValue<uint> guard, uint value)
        => ref GenericImplementation.IsLess<uint, UIntPredicates>(guard, value);

    public static ref readonly GuardValue<uint> IsLessOrEqual(this in GuardValue<uint> guard, uint value)
        => ref GenericImplementation.IsLessOrEqual<uint, UIntPredicates>(guard, value);

    public static ref readonly GuardValue<uint> InRange(
        this in GuardValue<uint> guard,
        uint min,
        uint max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref GenericImplementation.InRange<uint, UIntPredicates>(guard, min, max, excludeMin, excludeMax);
}