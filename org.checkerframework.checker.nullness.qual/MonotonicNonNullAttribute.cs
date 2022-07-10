using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.nullness.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.nullness.qual.$ProxyMonotonicNonNull", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.nullness.qual.MonotonicNonNull" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class MonotonicNonNullAttribute : AnnotationAttributeBase, MonotonicNonNull
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public MonotonicNonNullAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public MonotonicNonNullAttribute()
		: base(ClassLiteral<MonotonicNonNull>.Value)
	{
	}
}
