using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.units.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.units.qual.$Proxymm2", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.units.qual.mm2" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class mm2Attribute : AnnotationAttributeBase, mm2
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public mm2Attribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public mm2Attribute()
		: base(ClassLiteral<mm2>.Value)
	{
	}
}
