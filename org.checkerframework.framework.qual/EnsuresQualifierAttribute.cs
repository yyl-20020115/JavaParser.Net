using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;

namespace org.checkerframework.framework.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.framework.qual.$ProxyEnsuresQualifier", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.framework.qual.EnsuresQualifier" })]
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method)]
public sealed class EnsuresQualifierAttribute : AnnotationAttributeBase, EnsuresQualifier
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public EnsuresQualifierAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private EnsuresQualifierAttribute()
		: base(ClassLiteral<EnsuresQualifier>.Value)
	{
	}

	[HideFromJava]
	public EnsuresQualifierAttribute(string[] expression, Type qualifier)
		: this()
	{
		setValue("expression", expression);
		setValue("qualifier", qualifier);
	}

	private string[] expression()
	{
		return (string[])getValue("expression");
	}

	string[] EnsuresQualifier.expression()
	{
		//ILSpy generated this explicit interface implementation from .override directive in expression
		return this.expression();
	}

	private Class qualifier()
	{
		return (Class)getValue("qualifier");
	}

	Class EnsuresQualifier.qualifier()
	{
		//ILSpy generated this explicit interface implementation from .override directive in qualifier
		return this.qualifier();
	}
}
