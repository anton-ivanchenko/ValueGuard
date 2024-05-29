#if NETSTANDARD2_0 || NETSTANDARD2_1

// ReSharper disable once CheckNamespace
namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Parameter)]
internal class CallerArgumentExpressionAttribute : Attribute
{
    public CallerArgumentExpressionAttribute(string name)
    {
        Name = name;
    }

    public string Name { get; }
}

#endif