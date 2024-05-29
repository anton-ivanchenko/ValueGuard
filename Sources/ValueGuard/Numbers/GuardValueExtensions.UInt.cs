using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardContext<uint> EqualTo(this in GuardContext<uint> guard, uint value)
        => ref GenericImplementation.EqualTo<uint, UIntPredicates>(guard, value);

    public static ref readonly GuardContext<uint> NotEqualTo(this in GuardContext<uint> guard, uint value)
        => ref GenericImplementation.NotEqualTo<uint, UIntPredicates>(guard, value);

    public static ref readonly GuardContext<uint> IsDefault(this in GuardContext<uint> guard)
        => ref GenericImplementation.IsDefault<uint, UIntPredicates>(guard);

    public static ref readonly GuardContext<uint> NotDefault(this in GuardContext<uint> guard)
        => ref GenericImplementation.NotDefault<uint, UIntPredicates>(guard);

    public static ref readonly GuardContext<uint> GreaterThan(this in GuardContext<uint> guard, uint value)
        => ref GenericImplementation.GreaterThan<uint, UIntPredicates>(guard, value);

    public static ref readonly GuardContext<uint> GreaterThanOrEqualTo(this in GuardContext<uint> guard, uint value)
        => ref GenericImplementation.GreaterThanOrEqualTo<uint, UIntPredicates>(guard, value);

    public static ref readonly GuardContext<uint> LessThan(this in GuardContext<uint> guard, uint value)
        => ref GenericImplementation.LessThan<uint, UIntPredicates>(guard, value);

    public static ref readonly GuardContext<uint> LessThanOrEqualTo(this in GuardContext<uint> guard, uint value)
        => ref GenericImplementation.LessThanOrEqualTo<uint, UIntPredicates>(guard, value);

    public static ref readonly GuardContext<uint> InRange(
        this in GuardContext<uint> guard,
        uint min,
        uint max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref GenericImplementation.InRange<uint, UIntPredicates>(guard, min, max, excludeMin, excludeMax);
}