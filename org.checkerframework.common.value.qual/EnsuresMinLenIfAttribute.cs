using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.value.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.value.qual.$ProxyEnsuresMinLenIf", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.value.qual.EnsuresMinLenIf" })]
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method)]
public sealed class EnsuresMinLenIfAttribute : AnnotationAttributeBase, EnsuresMinLenIf
{
	[HideFromJava]
	public int targetValue
	{
		[HideFromJava]
		get
		{
			throw new NotImplementedException();
		}
		[HideFromJava]
		set
		{
			setValue("targetValue", value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public EnsuresMinLenIfAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private EnsuresMinLenIfAttribute()
		: base(ClassLiteral<EnsuresMinLenIf>.Value)
	{
	}

	[HideFromJava]
	public EnsuresMinLenIfAttribute(string[] expression, bool result)
		: this()
	{
		setValue("expression", expression);
		setValue("result", result);
	}

	private string[] expression()
	{
		return (string[])getValue("expression");
	}

	string[] EnsuresMinLenIf.expression()
	{
		//ILSpy generated this explicit interface implementation from .override directive in expression
		return this.expression();
	}

	private bool result()
	{
		return getBooleanValue("result");
	}

	bool EnsuresMinLenIf.result()
	{
		//ILSpy generated this explicit interface implementation from .override directive in result
		return this.result();
	}

	private int targetValue()
	{
		return getIntValue("targetValue");
	}

	int EnsuresMinLenIf.targetValue()
	{
		//ILSpy generated this explicit interface implementation from .override directive in targetValue
		return this.targetValue();
	}
}
