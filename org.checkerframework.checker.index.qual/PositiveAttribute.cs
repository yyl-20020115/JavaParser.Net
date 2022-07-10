using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.index.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.index.qual.$ProxyPositive", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.index.qual.Positive" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class PositiveAttribute : AnnotationAttributeBase, Positive
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public PositiveAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public PositiveAttribute()
		: base(ClassLiteral<Positive>.Value)
	{
	}
}
