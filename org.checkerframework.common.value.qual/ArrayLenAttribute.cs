using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.value.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.value.qual.$ProxyArrayLen", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.value.qual.ArrayLen" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class ArrayLenAttribute : AnnotationAttributeBase, ArrayLen
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public ArrayLenAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private ArrayLenAttribute()
		: base(ClassLiteral<ArrayLen>.Value)
	{
	}

	[HideFromJava]
	public ArrayLenAttribute(int[] value)
		: this()
	{
		setValue("value", value);
	}

	private int[] value()
	{
		return (int[])getValue("value");
	}

	int[] ArrayLen.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
