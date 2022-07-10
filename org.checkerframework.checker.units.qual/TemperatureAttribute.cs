using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.units.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.units.qual.$ProxyTemperature", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.units.qual.Temperature" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class TemperatureAttribute : AnnotationAttributeBase, Temperature
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public TemperatureAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public TemperatureAttribute()
		: base(ClassLiteral<Temperature>.Value)
	{
	}
}
