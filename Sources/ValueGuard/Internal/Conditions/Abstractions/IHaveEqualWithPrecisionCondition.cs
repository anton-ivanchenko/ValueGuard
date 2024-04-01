namespace ValueGuard.Internal.Conditions.Abstractions;

public interface IHaveEqualWithPrecisionCondition<T>
{
    bool IsEqual(T left, T right, T tolerance);
}