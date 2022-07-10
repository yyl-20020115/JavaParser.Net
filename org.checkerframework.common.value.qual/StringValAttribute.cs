using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.value.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.value.qual.$ProxyStringVal", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.value.qual.StringVal" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class StringValAttribute : AnnotationAttributeBase, StringVal
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public StringValAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private StringValAttribute()
		: base(ClassLiteral<StringVal>.Value)
	{
	}

	[HideFromJava]
	public StringValAttribute(string[] value)
		: this()
	{
		setValue("value", value);
	}

	private string[] value()
	{
		return (string[])getValue("value");
	}

	string[] StringVal.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
