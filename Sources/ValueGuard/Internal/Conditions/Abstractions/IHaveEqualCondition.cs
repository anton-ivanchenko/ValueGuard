namespace ValueGuard.Internal.Conditions.Abstractions;

public interface IHaveEqualCondition<T>
{
    bool IsEqual(T left, T right);
}