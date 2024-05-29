using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardContext<Guid> EqualTo(this in GuardContext<Guid> guard, Guid value)
        => ref GenericImplementation.EqualTo<Guid, GuidPredicates>(guard, value);

    public static ref readonly GuardContext<Guid> NotEqualTo(this in GuardContext<Guid> guard, Guid value)
        => ref GenericImplementation.NotEqualTo<Guid, GuidPredicates>(guard, value);

    public static ref readonly GuardContext<Guid> IsDefault(this in GuardContext<Guid> guard)
        => ref GenericImplementation.IsDefault<Guid, GuidPredicates>(guard);

    public static ref readonly GuardContext<Guid> NotDefault(this in GuardContext<Guid> guard)
        => ref GenericImplementation.NotDefault<Guid, GuidPredicates>(guard);

    public static ref readonly GuardContext<Guid> GreaterThan(this in GuardContext<Guid> guard, Guid value)
        => ref GenericImplementation.GreaterThan<Guid, GuidPredicates>(guard, value);

    public static ref readonly GuardContext<Guid> GreaterThanOrEqualTo(this in GuardContext<Guid> guard, Guid value)
        => ref GenericImplementation.GreaterThanOrEqualTo<Guid, GuidPredicates>(guard, value);

    public static ref readonly GuardContext<Guid> LessThan(this in GuardContext<Guid> guard, Guid value)
        => ref GenericImplementation.LessThan<Guid, GuidPredicates>(guard, value);

    public static ref readonly GuardContext<Guid> LessThanOrEqualTo(this in GuardContext<Guid> guard, Guid value)
        => ref GenericImplementation.LessThanOrEqualTo<Guid, GuidPredicates>(guard, value);

    public static ref readonly GuardContext<Guid> InRange(
        this in GuardContext<Guid> guard,
        Guid min,
        Guid max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref GenericImplementation.InRange<Guid, GuidPredicates>(guard, min, max, excludeMin, excludeMax);
}