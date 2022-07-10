using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.tainting.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.tainting.qual.$ProxyPolyTainted", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.tainting.qual.PolyTainted" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class PolyTaintedAttribute : AnnotationAttributeBase, PolyTainted
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public PolyTaintedAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public PolyTaintedAttribute()
		: base(ClassLiteral<PolyTainted>.Value)
	{
	}
}
