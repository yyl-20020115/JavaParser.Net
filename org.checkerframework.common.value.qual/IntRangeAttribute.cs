using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.value.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.value.qual.$ProxyIntRange", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.value.qual.IntRange" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class IntRangeAttribute : AnnotationAttributeBase, IntRange
{
	[HideFromJava]
	public long from
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
	public long to
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
	public IntRangeAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public IntRangeAttribute()
		: base(ClassLiteral<IntRange>.Value)
	{
	}

	private long from()
	{
		return getLongValue("from");
	}

	long IntRange.from()
	{
		//ILSpy generated this explicit interface implementation from .override directive in from
		return this.from();
	}

	private long to()
	{
		return getLongValue("to");
	}

	long IntRange.to()
	{
		//ILSpy generated this explicit interface implementation from .override directive in to
		return this.to();
	}
}
