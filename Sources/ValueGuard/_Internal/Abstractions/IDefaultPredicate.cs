namespace ValueGuard._Internal.Abstractions;

internal interface IDefaultPredicate<T>
{
    bool IsDefault(T value);
}