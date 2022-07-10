using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.index.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.index.qual.$ProxyEnsuresLTLengthOfIf", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.index.qual.EnsuresLTLengthOfIf" })]
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method)]
public sealed class EnsuresLTLengthOfIfAttribute : AnnotationAttributeBase, EnsuresLTLengthOfIf
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
	public EnsuresLTLengthOfIfAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private EnsuresLTLengthOfIfAttribute()
		: base(ClassLiteral<EnsuresLTLengthOfIf>.Value)
	{
	}

	[HideFromJava]
	public EnsuresLTLengthOfIfAttribute(string[] expression, bool result, string[] targetValue)
		: this()
	{
		setValue("expression", expression);
		setValue("result", result);
		setValue("targetValue", targetValue);
	}

	private string[] expression()
	{
		return (string[])getValue("expression");
	}

	string[] EnsuresLTLengthOfIf.expression()
	{
		//ILSpy generated this explicit interface implementation from .override directive in expression
		return this.expression();
	}

	private bool result()
	{
		return getBooleanValue("result");
	}

	bool EnsuresLTLengthOfIf.result()
	{
		//ILSpy generated this explicit interface implementation from .override directive in result
		return this.result();
	}

	private string[] targetValue()
	{
		return (string[])getValue("targetValue");
	}

	string[] EnsuresLTLengthOfIf.targetValue()
	{
		//ILSpy generated this explicit interface implementation from .override directive in targetValue
		return this.targetValue();
	}

	private string[] offset()
	{
		return (string[])getValue("offset");
	}

	string[] EnsuresLTLengthOfIf.offset()
	{
		//ILSpy generated this explicit interface implementation from .override directive in offset
		return this.offset();
	}
}
