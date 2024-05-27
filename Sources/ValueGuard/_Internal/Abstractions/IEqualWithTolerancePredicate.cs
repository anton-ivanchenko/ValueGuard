namespace ValueGuard._Internal.Abstractions;

internal interface IEqualWithTolerancePredicate<TValue, TTolerance>
{
    bool IsValidTolerance(TTolerance tolerance);

    bool IsEqual(TValue left, TValue right, TTolerance tolerance);
}