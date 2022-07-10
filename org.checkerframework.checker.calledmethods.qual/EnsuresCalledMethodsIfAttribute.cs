using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.calledmethods.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.calledmethods.qual.$ProxyEnsuresCalledMethodsIf", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.calledmethods.qual.EnsuresCalledMethodsIf" })]
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method)]
public sealed class EnsuresCalledMethodsIfAttribute : AnnotationAttributeBase, EnsuresCalledMethodsIf
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public EnsuresCalledMethodsIfAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private EnsuresCalledMethodsIfAttribute()
		: base(ClassLiteral<EnsuresCalledMethodsIf>.Value)
	{
	}

	[HideFromJava]
	public EnsuresCalledMethodsIfAttribute(string[] expression, bool result, string[] methods)
		: this()
	{
		setValue("expression", expression);
		setValue("result", result);
		setValue("methods", methods);
	}

	private string[] expression()
	{
		return (string[])getValue("expression");
	}

	string[] EnsuresCalledMethodsIf.expression()
	{
		//ILSpy generated this explicit interface implementation from .override directive in expression
		return this.expression();
	}

	private bool result()
	{
		return getBooleanValue("result");
	}

	bool EnsuresCalledMethodsIf.result()
	{
		//ILSpy generated this explicit interface implementation from .override directive in result
		return this.result();
	}

	private string[] methods()
	{
		return (string[])getValue("methods");
	}

	string[] EnsuresCalledMethodsIf.methods()
	{
		//ILSpy generated this explicit interface implementation from .override directive in methods
		return this.methods();
	}
}
