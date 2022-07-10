using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.units.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.units.qual.$ProxySubstance", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.units.qual.Substance" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class SubstanceAttribute : AnnotationAttributeBase, Substance
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public SubstanceAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public SubstanceAttribute()
		: base(ClassLiteral<Substance>.Value)
	{
	}
}
