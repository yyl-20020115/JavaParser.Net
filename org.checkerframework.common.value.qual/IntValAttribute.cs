using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.value.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.value.qual.$ProxyIntVal", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.value.qual.IntVal" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class IntValAttribute : AnnotationAttributeBase, IntVal
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public IntValAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private IntValAttribute()
		: base(ClassLiteral<IntVal>.Value)
	{
	}

	[HideFromJava]
	public IntValAttribute(long[] value)
		: this()
	{
		setValue("value", value);
	}

	private long[] value()
	{
		return (long[])getValue("value");
	}

	long[] IntVal.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
