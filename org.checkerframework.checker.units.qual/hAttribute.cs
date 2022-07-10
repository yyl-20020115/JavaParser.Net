using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.units.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.units.qual.$Proxyh", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.units.qual.h" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class hAttribute : AnnotationAttributeBase, h
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public hAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public hAttribute()
		: base(ClassLiteral<h>.Value)
	{
	}
}
