using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.units.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.units.qual.$ProxyPolyUnit", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.units.qual.PolyUnit" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class PolyUnitAttribute : AnnotationAttributeBase, PolyUnit
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public PolyUnitAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public PolyUnitAttribute()
		: base(ClassLiteral<PolyUnit>.Value)
	{
	}
}
