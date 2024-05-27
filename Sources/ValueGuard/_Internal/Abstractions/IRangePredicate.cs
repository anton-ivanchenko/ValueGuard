namespace ValueGuard._Internal.Abstractions;

internal interface IRangePredicate<T>
{
    bool IsGreater(T left, T right);

    bool IsGreaterOrEqual(T left, T right);

    bool IsLess(T left, T right);

    bool IsLessOrEqual(T left, T right);
}