using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.@lock.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.lock.qual.$ProxyEnsuresLockHeldIf", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.lock.qual.EnsuresLockHeldIf" })]
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method)]
public sealed class EnsuresLockHeldIfAttribute : AnnotationAttributeBase, EnsuresLockHeldIf
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public EnsuresLockHeldIfAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private EnsuresLockHeldIfAttribute()
		: base(ClassLiteral<EnsuresLockHeldIf>.Value)
	{
	}

	[HideFromJava]
	public EnsuresLockHeldIfAttribute(string[] expression, bool result)
		: this()
	{
		setValue("expression", expression);
		setValue("result", result);
	}

	private string[] expression()
	{
		return (string[])getValue("expression");
	}

	string[] EnsuresLockHeldIf.expression()
	{
		//ILSpy generated this explicit interface implementation from .override directive in expression
		return this.expression();
	}

	private bool result()
	{
		return getBooleanValue("result");
	}

	bool EnsuresLockHeldIf.result()
	{
		//ILSpy generated this explicit interface implementation from .override directive in result
		return this.result();
	}
}
