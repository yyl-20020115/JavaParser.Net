using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.units.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.units.qual.$ProxySpeed", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.units.qual.Speed" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class SpeedAttribute : AnnotationAttributeBase, Speed
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public SpeedAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public SpeedAttribute()
		: base(ClassLiteral<Speed>.Value)
	{
	}
}
