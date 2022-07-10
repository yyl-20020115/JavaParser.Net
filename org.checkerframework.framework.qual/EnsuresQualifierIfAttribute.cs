using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;

namespace org.checkerframework.framework.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.framework.qual.$ProxyEnsuresQualifierIf", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.framework.qual.EnsuresQualifierIf" })]
[AttributeUsage(AttributeTargets.Method)]
public sealed class EnsuresQualifierIfAttribute : AnnotationAttributeBase, EnsuresQualifierIf
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public EnsuresQualifierIfAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private EnsuresQualifierIfAttribute()
		: base(ClassLiteral<EnsuresQualifierIf>.Value)
	{
	}

	[HideFromJava]
	public EnsuresQualifierIfAttribute(string[] expression, Type qualifier, bool result)
		: this()
	{
		setValue("expression", expression);
		setValue("qualifier", qualifier);
		setValue("result", result);
	}

	private string[] expression()
	{
		return (string[])getValue("expression");
	}

	string[] EnsuresQualifierIf.expression()
	{
		//ILSpy generated this explicit interface implementation from .override directive in expression
		return this.expression();
	}

	private Class qualifier()
	{
		return (Class)getValue("qualifier");
	}

	Class EnsuresQualifierIf.qualifier()
	{
		//ILSpy generated this explicit interface implementation from .override directive in qualifier
		return this.qualifier();
	}

	private bool result()
	{
		return getBooleanValue("result");
	}

	bool EnsuresQualifierIf.result()
	{
		//ILSpy generated this explicit interface implementation from .override directive in result
		return this.result();
	}
}
