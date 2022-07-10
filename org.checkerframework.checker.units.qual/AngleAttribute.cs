using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.units.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.units.qual.$ProxyAngle", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.units.qual.Angle" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class AngleAttribute : AnnotationAttributeBase, Angle
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public AngleAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public AngleAttribute()
		: base(ClassLiteral<Angle>.Value)
	{
	}
}
