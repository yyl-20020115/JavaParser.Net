using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.nullness.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.nullness.qual.$ProxyEnsuresNonNullIf", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.nullness.qual.EnsuresNonNullIf" })]
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method)]
public sealed class EnsuresNonNullIfAttribute : AnnotationAttributeBase, EnsuresNonNullIf
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public EnsuresNonNullIfAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private EnsuresNonNullIfAttribute()
		: base(ClassLiteral<EnsuresNonNullIf>.Value)
	{
	}

	[HideFromJava]
	public EnsuresNonNullIfAttribute(string[] expression, bool result)
		: this()
	{
		setValue("expression", expression);
		setValue("result", result);
	}

	private string[] expression()
	{
		return (string[])getValue("expression");
	}

	string[] EnsuresNonNullIf.expression()
	{
		//ILSpy generated this explicit interface implementation from .override directive in expression
		return this.expression();
	}

	private bool result()
	{
		return getBooleanValue("result");
	}

	bool EnsuresNonNullIf.result()
	{
		//ILSpy generated this explicit interface implementation from .override directive in result
		return this.result();
	}
}
