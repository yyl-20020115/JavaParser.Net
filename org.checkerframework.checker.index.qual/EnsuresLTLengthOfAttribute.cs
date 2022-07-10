using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.index.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.index.qual.$ProxyEnsuresLTLengthOf", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.index.qual.EnsuresLTLengthOf" })]
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method)]
public sealed class EnsuresLTLengthOfAttribute : AnnotationAttributeBase, EnsuresLTLengthOf
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
	public EnsuresLTLengthOfAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private EnsuresLTLengthOfAttribute()
		: base(ClassLiteral<EnsuresLTLengthOf>.Value)
	{
	}

	[HideFromJava]
	public EnsuresLTLengthOfAttribute(string[] value, string[] targetValue)
		: this()
	{
		setValue("value", value);
		setValue("targetValue", targetValue);
	}

	private string[] value()
	{
		return (string[])getValue("value");
	}

	string[] EnsuresLTLengthOf.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}

	private string[] targetValue()
	{
		return (string[])getValue("targetValue");
	}

	string[] EnsuresLTLengthOf.targetValue()
	{
		//ILSpy generated this explicit interface implementation from .override directive in targetValue
		return this.targetValue();
	}

	private string[] offset()
	{
		return (string[])getValue("offset");
	}

	string[] EnsuresLTLengthOf.offset()
	{
		//ILSpy generated this explicit interface implementation from .override directive in offset
		return this.offset();
	}
}
