#if NETSTANDARD2_0

// ReSharper disable once CheckNamespace
namespace System.Diagnostics.CodeAnalysis;

[AttributeUsage(AttributeTargets.Method)]
internal sealed class DoesNotReturnAttribute : Attribute { }

#endif