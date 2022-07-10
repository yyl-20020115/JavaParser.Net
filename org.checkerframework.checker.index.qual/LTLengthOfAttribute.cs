using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.index.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.index.qual.$ProxyLTLengthOf", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.index.qual.LTLengthOf" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class LTLengthOfAttribute : AnnotationAttributeBase, LTLengthOf
{
	[HideFromJava]
	public string[] offset
	{
		[HideFromJava]
		get
		{
			throw new NotImplementedException();
		}
		[HideFromJava]
		set
		{
			setValue("offset", value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public LTLengthOfAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private LTLengthOfAttribute()
		: base(ClassLiteral<LTLengthOf>.Value)
	{
	}

	[HideFromJava]
	public LTLengthOfAttribute(string[] value)
		: this()
	{
		setValue("value", value);
	}

	private string[] value()
	{
		return (string[])getValue("value");
	}

	string[] LTLengthOf.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}

	private string[] offset()
	{
		return (string[])getValue("offset");
	}

	string[] LTLengthOf.offset()
	{
		//ILSpy generated this explicit interface implementation from .override directive in offset
		return this.offset();
	}
}
