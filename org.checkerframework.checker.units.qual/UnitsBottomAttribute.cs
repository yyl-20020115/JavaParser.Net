using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.units.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.units.qual.$ProxyUnitsBottom", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.units.qual.UnitsBottom" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class UnitsBottomAttribute : AnnotationAttributeBase, UnitsBottom
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public UnitsBottomAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public UnitsBottomAttribute()
		: base(ClassLiteral<UnitsBottom>.Value)
	{
	}
}
