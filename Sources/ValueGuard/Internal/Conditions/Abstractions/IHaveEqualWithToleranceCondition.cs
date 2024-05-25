namespace ValueGuard.Internal.Conditions.Abstractions;

internal interface IHaveEqualWithToleranceCondition<TValue, TTolerance>
{
    bool IsValidTolerance(TTolerance tolerance);
    
    bool IsEqual(TValue left, TValue right, TTolerance tolerance);
}