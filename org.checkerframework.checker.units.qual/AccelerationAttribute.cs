using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.units.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.units.qual.$ProxyAcceleration", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.units.qual.Acceleration" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class AccelerationAttribute : AnnotationAttributeBase, Acceleration
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public AccelerationAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public AccelerationAttribute()
		: base(ClassLiteral<Acceleration>.Value)
	{
	}
}
