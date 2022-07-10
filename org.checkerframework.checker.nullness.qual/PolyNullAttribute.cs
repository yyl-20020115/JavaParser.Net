using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.nullness.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.nullness.qual.$ProxyPolyNull", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.nullness.qual.PolyNull" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class PolyNullAttribute : AnnotationAttributeBase, PolyNull
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public PolyNullAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public PolyNullAttribute()
		: base(ClassLiteral<PolyNull>.Value)
	{
	}
}
