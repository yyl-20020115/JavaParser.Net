using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.value.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.value.qual.$ProxyBoolVal", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.value.qual.BoolVal" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class BoolValAttribute : AnnotationAttributeBase, BoolVal
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public BoolValAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private BoolValAttribute()
		: base(ClassLiteral<BoolVal>.Value)
	{
	}

	[HideFromJava]
	public BoolValAttribute(bool[] value)
		: this()
	{
		setValue("value", value);
	}

	private bool[] value()
	{
		return (bool[])getValue("value");
	}

	bool[] BoolVal.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
