using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.units.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.units.qual.$ProxyC", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.units.qual.C" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class CAttribute : AnnotationAttributeBase, C
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public CAttribute()
		: base(ClassLiteral<C>.Value)
	{
	}
}
