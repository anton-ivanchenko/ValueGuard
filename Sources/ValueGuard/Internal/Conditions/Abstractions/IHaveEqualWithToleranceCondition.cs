namespace ValueGuard.Internal.Conditions.Abstractions;

internal interface IHaveEqualWithToleranceCondition<TValue, TTolerance>
{
    bool IsEqual(TValue left, TValue right, TTolerance tolerance);
}