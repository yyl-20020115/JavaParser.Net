using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.value.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.value.qual.$ProxyDoubleVal", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.value.qual.DoubleVal" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class DoubleValAttribute : AnnotationAttributeBase, DoubleVal
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public DoubleValAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private DoubleValAttribute()
		: base(ClassLiteral<DoubleVal>.Value)
	{
	}

	[HideFromJava]
	public DoubleValAttribute(double[] value)
		: this()
	{
		setValue("value", value);
	}

	private double[] value()
	{
		return (double[])getValue("value");
	}

	double[] DoubleVal.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
