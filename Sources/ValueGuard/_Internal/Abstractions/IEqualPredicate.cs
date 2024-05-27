namespace ValueGuard._Internal.Abstractions;

internal interface IEqualPredicate<T>
{
    bool IsEqual(T left, T right);
}