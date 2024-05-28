using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<Guid> EqualTo(this in GuardValue<Guid> guard, Guid value)
        => ref GenericImplementation.EqualTo<Guid, GuidPredicates>(guard, value);

    public static ref readonly GuardValue<Guid> NotEqualTo(this in GuardValue<Guid> guard, Guid value)
        => ref GenericImplementation.NotEqualTo<Guid, GuidPredicates>(guard, value);

    public static ref readonly GuardValue<Guid> IsDefault(this in GuardValue<Guid> guard)
        => ref GenericImplementation.IsDefault<Guid, GuidPredicates>(guard);

    public static ref readonly GuardValue<Guid> NotDefault(this in GuardValue<Guid> guard)
        => ref GenericImplementation.NotDefault<Guid, GuidPredicates>(guard);

    public static ref readonly GuardValue<Guid> GreaterThan(this in GuardValue<Guid> guard, Guid value)
        => ref GenericImplementation.GreaterThan<Guid, GuidPredicates>(guard, value);

    public static ref readonly GuardValue<Guid> GreaterThanOrEqualTo(this in GuardValue<Guid> guard, Guid value)
        => ref GenericImplementation.GreaterThanOrEqualTo<Guid, GuidPredicates>(guard, value);

    public static ref readonly GuardValue<Guid> LessThan(this in GuardValue<Guid> guard, Guid value)
        => ref GenericImplementation.LessThan<Guid, GuidPredicates>(guard, value);

    public static ref readonly GuardValue<Guid> LessThanOrEqualTo(this in GuardValue<Guid> guard, Guid value)
        => ref GenericImplementation.LessThanOrEqualTo<Guid, GuidPredicates>(guard, value);

    public static ref readonly GuardValue<Guid> InRange(
        this in GuardValue<Guid> guard,
        Guid min,
        Guid max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref GenericImplementation.InRange<Guid, GuidPredicates>(guard, min, max, excludeMin, excludeMax);
}