using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;

namespace org.checkerframework.framework.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.framework.qual.$ProxyRequiresQualifier", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.framework.qual.RequiresQualifier" })]
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method)]
public sealed class RequiresQualifierAttribute : AnnotationAttributeBase, RequiresQualifier
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public RequiresQualifierAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private RequiresQualifierAttribute()
		: base(ClassLiteral<RequiresQualifier>.Value)
	{
	}

	[HideFromJava]
	public RequiresQualifierAttribute(string[] expression, Type qualifier)
		: this()
	{
		setValue("expression", expression);
		setValue("qualifier", qualifier);
	}

	private string[] expression()
	{
		return (string[])getValue("expression");
	}

	string[] RequiresQualifier.expression()
	{
		//ILSpy generated this explicit interface implementation from .override directive in expression
		return this.expression();
	}

	private Class qualifier()
	{
		return (Class)getValue("qualifier");
	}

	Class RequiresQualifier.qualifier()
	{
		//ILSpy generated this explicit interface implementation from .override directive in qualifier
		return this.qualifier();
	}
}
