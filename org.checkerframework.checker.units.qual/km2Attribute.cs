using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.units.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.units.qual.$Proxykm2", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.units.qual.km2" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class km2Attribute : AnnotationAttributeBase, km2
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public km2Attribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public km2Attribute()
		: base(ClassLiteral<km2>.Value)
	{
	}
}
