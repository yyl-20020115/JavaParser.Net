using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.nullness.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.nullness.qual.$ProxyUnknownKeyFor", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.nullness.qual.UnknownKeyFor" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class UnknownKeyForAttribute : AnnotationAttributeBase, UnknownKeyFor
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public UnknownKeyForAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public UnknownKeyForAttribute()
		: base(ClassLiteral<UnknownKeyFor>.Value)
	{
	}
}
