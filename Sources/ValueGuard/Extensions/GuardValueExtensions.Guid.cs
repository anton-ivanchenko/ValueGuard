using ValueGuard.Internal;
using ValueGuard.Internal.Conditions;

namespace ValueGuard;

public static partial class GuardValueExtensions
{
    public static ref readonly GuardValue<Guid> Equal(this in GuardValue<Guid> guard, Guid value)
        => ref guard.Equal<Guid, GuidConditions>(value);

    public static ref readonly GuardValue<Guid> NotEqual(this in GuardValue<Guid> guard, Guid value)
        => ref guard.NotEqual<Guid, GuidConditions>(value);

    public static ref readonly GuardValue<Guid> IsDefault(this in GuardValue<Guid> guard)
        => ref guard.IsDefault<Guid, GuidConditions>();

    public static ref readonly GuardValue<Guid> IsNotDefault(this in GuardValue<Guid> guard)
        => ref guard.IsNotDefault<Guid, GuidConditions>();

    public static ref readonly GuardValue<Guid> Greater(this in GuardValue<Guid> guard, Guid value)
        => ref guard.Greater<Guid, GuidConditions>(value);

    public static ref readonly GuardValue<Guid> GreaterOrEqual(this in GuardValue<Guid> guard, Guid value)
        => ref guard.GreaterOrEqual<Guid, GuidConditions>(value);

    public static ref readonly GuardValue<Guid> Less(this in GuardValue<Guid> guard, Guid value)
        => ref guard.Less<Guid, GuidConditions>(value);

    public static ref readonly GuardValue<Guid> LessOrEqual(this in GuardValue<Guid> guard, Guid value)
        => ref guard.LessOrEqual<Guid, GuidConditions>(value);

    public static ref readonly GuardValue<Guid> InRange(
        this in GuardValue<Guid> guard,
        Guid min,
        Guid max,
        bool excludeMin = false,
        bool excludeMax = false)
        => ref guard.InRange<Guid, GuidConditions>(min, max, excludeMin, excludeMax);
}