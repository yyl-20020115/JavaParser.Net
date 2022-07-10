using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.units.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.units.qual.$ProxyMass", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.units.qual.Mass" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class MassAttribute : AnnotationAttributeBase, Mass
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public MassAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public MassAttribute()
		: base(ClassLiteral<Mass>.Value)
	{
	}
}
