using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.value.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.value.qual.$ProxyMinLen", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.value.qual.MinLen" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class MinLenAttribute : AnnotationAttributeBase, MinLen
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public MinLenAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public MinLenAttribute()
		: base(ClassLiteral<MinLen>.Value)
	{
	}

	[HideFromJava]
	public MinLenAttribute(int value)
		: this()
	{
		setValue("value", value);
	}

	private int value()
	{
		return getIntValue("value");
	}

	int MinLen.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
