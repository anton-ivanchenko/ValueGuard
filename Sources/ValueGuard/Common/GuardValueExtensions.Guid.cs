using ValueGuard._Internal;
using ValueGuard.Predicates;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<Guid> IsEqual(this in GuardValue<Guid> guard, Guid value)
        => ref GenericImplementation.IsEqual<Guid, GuidPredicates>(guard, value);

    public static ref readonly GuardValue<Guid> NotEqual(this in GuardValue<Guid> guard, Guid value)
        => ref GenericImplementation.NotEqual<Guid, GuidPredicates>(guard, value);

    public static ref readonly GuardValue<Guid> IsDefault(this in GuardValue<Guid> guard)
        => ref GenericImplementation.IsDefault<Guid, GuidPredicates>(guard);

    public static ref readonly GuardValue<Guid> NotDefault(this in GuardValue<Guid> guard)
        => ref GenericImplementation.NotDefault<Guid, GuidPredicates>(guard);

    public static ref readonly GuardValue<Guid> IsGreater(this in GuardValue<Guid> guard, Guid value)
        => ref GenericImplementation.IsGreater<Guid, GuidPredicates>(guard, value);

    public static ref readonly GuardValue<Guid> IsGreaterOrEqual(this in GuardValue<Guid> guard, Guid value)
        => ref GenericImplementation.IsGreaterOrEqual<Guid, GuidPredicates>(guard, value);

    public static ref readonly GuardValue<Guid> IsLess(this in GuardValue<Guid> guard, Guid value)
        => ref GenericImplementation.IsLess<Guid, GuidPredicates>(guard, value);

    public static ref readonly GuardValue<Guid> IsLessOrEqual(this in GuardValue<Guid> guard, Guid value)
        => ref GenericImplementation.IsLessOrEqual<Guid, GuidPredicates>(guard, value);

    public static ref readonly GuardValue<Guid> InRange(
        this in GuardValue<Guid> guard,
        Guid min,
        Guid max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref GenericImplementation.InRange<Guid, GuidPredicates>(guard, min, max, excludeMin, excludeMax);
}