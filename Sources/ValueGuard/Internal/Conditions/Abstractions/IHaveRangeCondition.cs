namespace ValueGuard.Internal.Conditions.Abstractions;

internal interface IHaveRangeCondition<T>
{
    bool IsGreater(T left, T right);

    bool IsGreaterOrEqual(T left, T right);

    bool IsLess(T left, T right);

    bool IsLessOrEqual(T left, T right);
}