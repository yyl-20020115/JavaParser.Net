using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.value.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.value.qual.$ProxyEnumVal", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.value.qual.EnumVal" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class EnumValAttribute : AnnotationAttributeBase, EnumVal
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public EnumValAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private EnumValAttribute()
		: base(ClassLiteral<EnumVal>.Value)
	{
	}

	[HideFromJava]
	public EnumValAttribute(string[] value)
		: this()
	{
		setValue("value", value);
	}

	private string[] value()
	{
		return (string[])getValue("value");
	}

	string[] EnumVal.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
