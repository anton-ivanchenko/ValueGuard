namespace ValueGuard.Internal.Conditions.Abstractions;

internal interface IHaveEqualCondition<T>
{
    bool IsEqual(T left, T right);
}