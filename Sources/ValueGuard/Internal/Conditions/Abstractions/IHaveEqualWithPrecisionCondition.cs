namespace ValueGuard.Internal.Conditions.Abstractions;

internal interface IHaveEqualWithPrecisionCondition<T>
{
    bool IsEqual(T left, T right, T tolerance);
}