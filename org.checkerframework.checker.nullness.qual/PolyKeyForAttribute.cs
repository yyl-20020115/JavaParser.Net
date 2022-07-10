using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.nullness.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.nullness.qual.$ProxyPolyKeyFor", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.nullness.qual.PolyKeyFor" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class PolyKeyForAttribute : AnnotationAttributeBase, PolyKeyFor
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public PolyKeyForAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public PolyKeyForAttribute()
		: base(ClassLiteral<PolyKeyFor>.Value)
	{
	}
}
