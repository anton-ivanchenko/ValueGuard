namespace ValueGuard.Internal.Conditions.Abstractions;

internal interface IHaveDefaultCondition<T>
{
    bool IsDefault(T value);
}