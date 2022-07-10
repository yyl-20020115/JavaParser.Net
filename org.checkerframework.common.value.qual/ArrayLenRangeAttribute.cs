using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.value.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.value.qual.$ProxyArrayLenRange", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.value.qual.ArrayLenRange" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class ArrayLenRangeAttribute : AnnotationAttributeBase, ArrayLenRange
{
	[HideFromJava]
	public int from
	{
		[HideFromJava]
		get
		{
			throw new NotImplementedException();
		}
		[HideFromJava]
		set
		{
			setValue("from", value);
		}
	}

	[HideFromJava]
	public int to
	{
		[HideFromJava]
		get
		{
			throw new NotImplementedException();
		}
		[HideFromJava]
		set
		{
			setValue("to", value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public ArrayLenRangeAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public ArrayLenRangeAttribute()
		: base(ClassLiteral<ArrayLenRange>.Value)
	{
	}

	private int from()
	{
		return getIntValue("from");
	}

	int ArrayLenRange.from()
	{
		//ILSpy generated this explicit interface implementation from .override directive in from
		return this.from();
	}

	private int to()
	{
		return getIntValue("to");
	}

	int ArrayLenRange.to()
	{
		//ILSpy generated this explicit interface implementation from .override directive in to
		return this.to();
	}
}
