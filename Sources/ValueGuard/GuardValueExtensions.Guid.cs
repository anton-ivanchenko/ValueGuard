using ValueGuard.Internal;
using ValueGuard.Internal.Conditions;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<Guid> IsEqual(this in GuardValue<Guid> guard, Guid value)
        => ref guard.IsEqual<Guid, GuidConditions>(value);

    public static ref readonly GuardValue<Guid> IsNotEqual(this in GuardValue<Guid> guard, Guid value)
        => ref guard.IsNotEqual<Guid, GuidConditions>(value);

    public static ref readonly GuardValue<Guid> IsDefault(this in GuardValue<Guid> guard)
        => ref guard.IsDefault<Guid, GuidConditions>();

    public static ref readonly GuardValue<Guid> IsNotDefault(this in GuardValue<Guid> guard)
        => ref guard.IsNotDefault<Guid, GuidConditions>();

    public static ref readonly GuardValue<Guid> IsGreater(this in GuardValue<Guid> guard, Guid value)
        => ref guard.IsGreater<Guid, GuidConditions>(value);

    public static ref readonly GuardValue<Guid> IsGreaterOrEqual(this in GuardValue<Guid> guard, Guid value)
        => ref guard.IsGreaterOrEqual<Guid, GuidConditions>(value);

    public static ref readonly GuardValue<Guid> IsLess(this in GuardValue<Guid> guard, Guid value)
        => ref guard.IsLess<Guid, GuidConditions>(value);

    public static ref readonly GuardValue<Guid> IsLessOrEqual(this in GuardValue<Guid> guard, Guid value)
        => ref guard.IsLessOrEqual<Guid, GuidConditions>(value);

    public static ref readonly GuardValue<Guid> InRange(
        this in GuardValue<Guid> guard,
        Guid min,
        Guid max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref guard.InRange<Guid, GuidConditions>(min, max, excludeMin, excludeMax);
}